using Hkmp.Api.Server;
using Hkmp.Networking.Packet;
using Hkmp.Networking.Packet.Data;
using System.Linq;

namespace Satchel.HkmpPipe{
    public class Server : ServerAddon {

        internal static Server Instance;
        internal IServerApi serverApi;
        internal event EventHandler<RecievedEventArgs> OnRecieve;
        public Server() {
            Instance = this;
        }
        internal void sendToAll(ushort fromPlayer,string _mod,string _eventName,string _eventData,bool _reliable = false){
            var players = serverApi.ServerManager.Players;
            for(var i = 0; i < players.Count ; i++){
                var player = players.ElementAt(i);
                this.send(fromPlayer,player.Id,_mod,_eventName,_eventData,false,true,_reliable);
            }
        }

        internal void send(ushort fromPlayer,ushort toPlayer,string _mod,string _eventName,string _eventData,bool _rebroadcast = false , bool _broadcastToAll = false ,bool _reliable = false){
            Modding.Logger.Log("server send" + _eventName);
            var netSender = serverApi.NetServer.GetNetworkSender<Packets>(this);
            // SendCollectionData using the given packet ID
            netSender.SendCollectionData(Packets.GenericPacket, new GenericPacket {
               _isReliable = _reliable,
               _dropReliableDataIfNewerExists = false,
               mod = _mod,
               rebroadcast = _rebroadcast,
               broadcastToAll = _broadcastToAll,
               fromPlayer = fromPlayer,
               toPlayer = toPlayer,
               eventName = _eventName,
               eventData = _eventData
            },toPlayer);
        }
        public override void Initialize(IServerApi serverApi) {
            this.serverApi = serverApi;
            var netReceiver = serverApi.NetServer.GetNetworkReceiver<Packets>(this,InstantiatePacket);

            netReceiver.RegisterPacketHandler<GenericPacket>(
                Packets.GenericPacket,
                async (id, packetData) => {
                    Modding.Logger.Log("Server recieve" + packetData.eventName);
                    //broadcast the packet to all server addons
                    OnRecieve?.Invoke(this,new RecievedEventArgs{
                        packet = packetData
                    });
                    //rebroadcast the packet to all clients 
                    if(packetData.rebroadcast){
                        if(packetData.broadcastToAll){
                            sendToAll(id,packetData.mod,packetData.eventName,packetData.eventData,packetData._isReliable);
                        } else {
                            send(id,packetData.toPlayer,packetData.mod,packetData.eventName,packetData.eventData,false,packetData._isReliable);
                        }
                    }
                }
            );
        }


        protected override string Name => "Satchel";
        protected override string Version => "0.0.1";
        public override bool NeedsNetwork => true;
        private static IPacketData InstantiatePacket(Packets packetId) {
            switch (packetId) {
                case Packets.GenericPacket:
                    return new PacketDataCollection<GenericPacket>();
            }
            return null;
        }
    }
}