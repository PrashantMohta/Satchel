
using Newtonsoft.Json;
using System.IO;
namespace Satchel.Futils.Serialiser{
    public static class Serialiser{
        public static void EmitJsonFile(this PlayMakerFSM fsm){
                var json = JsonConvert.SerializeObject(new FsmDataInstance(fsm), Formatting.Indented, new JsonSerializerSettings 
                { 
                        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                        Error = ( sender,  args) => {
                            Debug.Log(args.ErrorContext.Error.Message);
                            args.ErrorContext.Handled = true;
                        },
                });
                File.WriteAllText(
                    Path.Combine(
                        Path.GetDirectoryName(
                            System.Reflection.Assembly.GetCallingAssembly().Location
                        ),
                    fsm.gameObject.name+"-"+fsm.FsmName+".json"
                ),json);
        }
    }

}