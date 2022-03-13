using Hkmp.Api.Client;
using Hkmp.Networking.Packet;

namespace Satchel.Hkmp{
    public class Client : ClientAddon {
        internal static Client Instance;
        internal static IClientApi clientApi;
        internal event EventHandler<RecievedEventArgs> OnRecieve;

        public Client(IClientApi _clientApi) : base(clientApi) {
            clientApi = _clientApi;
            Instance = this;
        }
        internal void send(ushort fromPlayer,ushort toPlayer,string _mod,string _eventName,string _eventData,bool _rebroadcast = false, bool _broadcastToAll = false ,bool _reliable = false){
            Modding.Logger.Log("client send" + _eventName);
            var netSender = clientApi.NetClient.GetNetworkSender<Packets>(Instance);

            // Send single data using the given packet ID
            //SendSingleData
            //SendCollectionData
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
            });
        }
 
        public override void Initialize() {
            var netReceiver = clientApi.NetClient.GetNetworkReceiver<Packets>(Instance, InstantiatePacket);

            netReceiver.RegisterPacketHandler<GenericPacket>(
                Packets.GenericPacket,
                packetData => {
                    Modding.Logger.Log("Client recieve" + packetData.eventName);
                    //broadcast event to all client addons
                    OnRecieve?.Invoke(this,new RecievedEventArgs{
                        packet = packetData
                    });
                }
            );
        }

        protected override string Name => "Satchel";
        protected override string Version => "0.0.1";
        public override bool NeedsNetwork => true;


        private static IPacketData InstantiatePacket(Packets packetId) {
            switch (packetId) {
                case Packets.GenericPacket:
                    return new GenericPacket();
            }
            return null;
        }
    }
}