
using System.IO;
using Newtonsoft.Json;
namespace Satchel.Futils.Serialiser
{
    public static class Serialiser
    {
        /// <summary>
        /// Create a JSON file by  serialising FSM for debugging edited FSMS
        /// </summary>
        /// <param name="fsm"></param>
        public static void EmitJsonFile(this PlayMakerFSM fsm)
        {
            var json = JsonConvert.SerializeObject(new FsmDataInstance(fsm), Formatting.Indented, new JsonSerializerSettings
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                Error = (sender, args) =>
                {
                    Satchel.Instance.LogError(args.ErrorContext.Error.Message);
                    args.ErrorContext.Handled = true;
                },
            });
            File.WriteAllText(
                Path.Combine(
                    Path.GetDirectoryName(
                        System.Reflection.Assembly.GetCallingAssembly().Location
                    ),
                fsm.gameObject.name + "-" + fsm.FsmName + ".json"
            ), json);
        }
    }

}