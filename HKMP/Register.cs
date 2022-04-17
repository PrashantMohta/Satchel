namespace Satchel.HkmpPipe{
    static class InGameAddon{
        public static object client;
        public static object server;
        private static void RegisterAddons(){
            if(client == null){
                client = new Client();
                Hkmp.Api.Client.ClientAddon.RegisterAddon((Hkmp.Api.Client.ClientAddon)client);
            }
            if(server == null){
                server = new Server();
                Hkmp.Api.Server.ServerAddon.RegisterAddon((Hkmp.Api.Server.ServerAddon)server);
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