namespace Satchel.HkmpPipe{
    static class InGameAddon{
        public static Client client;
        public static Server server;
        private static void RegisterAddons(){
            if(client == null){
                client = new Client();
                Hkmp.Api.Client.ClientAddon.RegisterAddon(client);
            }
            if(server == null){
                server = new Server();
                Hkmp.Api.Server.ServerAddon.RegisterAddon(server);
            }
        }
        public static void SafeRegisterAddons(){
            try{
                RegisterAddons();
            } catch (Exception e){
                Modding.Logger.Log(e.ToString());
            }
        }
    }
}