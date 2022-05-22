using System.Text;
using System.IO;

namespace Satchel.Futils.Serialiser{
    internal static class ActionReader
    { 
        public static object GetFsmObject(this ActionData actionData, int index, int dataVersion)
        {
            var byteData = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<byte>>(actionData, "byteData");

            BinaryReader r = new BinaryReader(new MemoryStream(byteData.ToArray()));
            //string actionName = actionData.actionNames[index];
            var fsmEnumParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmEnum>>(actionData, "fsmEnumParams");
            var fsmBoolParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmBool>>(actionData, "fsmBoolParams");
            var fsmIntParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmInt>>(actionData, "fsmIntParams");
            var fsmFloatParams= ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmFloat>>(actionData, "fsmFloatParams");
            var fsmVector2Params= ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmVector2>>(actionData, "fsmVector2Params");
            var fsmVector3Params= ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmVector3>>(actionData, "fsmVector3Params");
            var fsmQuaternionParams= ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmQuaternion>>(actionData, "fsmQuaternionParams");
            var fsmColorParams= ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmColor>>(actionData, "fsmColorParams");
            var fsmRectParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmRect>>(actionData, "fsmRectParams");
            
            var fsmGameObjectParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmGameObject>>(actionData, "fsmGameObjectParams");
            var fsmOwnerDefaultParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmOwnerDefault>>(actionData, "fsmOwnerDefaultParams");
            var fsmObjectParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmObject>>(actionData, "fsmObjectParams");
            var fsmVarParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmVar>>(actionData, "fsmVarParams");
            var fsmStringParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmString>>(actionData, "fsmStringParams");
            var stringParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<string>>(actionData, "stringParams");
            var fsmEventTargetParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmEventTarget>>(actionData, "fsmEventTargetParams");
            var fsmArrayParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FsmArray>>(actionData, "fsmArrayParams");
            var unityObjectParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<UnityEngine.Object>>(actionData, "unityObjectParams");
            var functionCallParams = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<FunctionCall>>(actionData, "functionCallParams");

            ParamDataType paramDataType = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<ParamDataType>>(actionData, "paramDataType")[index];
            int paramDataPos = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<int>>(actionData, "paramDataPos")[index];
            int paramByteDataSize = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<int>>(actionData, "paramByteDataSize")[index];

            r.BaseStream.Position = paramDataPos;

            object ret;
            switch (paramDataType)
            {
                case ParamDataType.Integer:
                    ret = r.ReadInt32();
                    break;
                case ParamDataType.FsmInt when dataVersion == 1:
                    ret = new FsmInt() { Value = r.ReadInt32() };
                    break;
                case ParamDataType.Enum:
                    ret = r.ReadInt32();
                    //ret = ((Enum)AssemblyHelper.GetPublicFields(typeDef)[index])[ret];
                    break;
                case ParamDataType.Boolean:
                    ret = r.ReadBoolean();
                    break;
                case ParamDataType.FsmBool when dataVersion == 1:
                    ret = new FsmBool { Value = r.ReadBoolean() };
                    break;
                case ParamDataType.Float:
                    ret = r.ReadSingle();
                    break;
                case ParamDataType.FsmFloat when dataVersion == 1:
                    ret = new FsmFloat { Value = r.ReadSingle() };
                    break;
                case ParamDataType.String:
                    ret = Encoding.UTF8.GetString(r.ReadBytes(paramByteDataSize));
                    break;
                case ParamDataType.FsmEvent when dataVersion == 1:
                    ret = new FsmEvent { name = Encoding.UTF8.GetString(r.ReadBytes(paramByteDataSize)) };
                    break;
                case ParamDataType.Vector2:
                    ret = new Vector2 { x = r.ReadSingle(), y = r.ReadSingle() };
                    break;
                case ParamDataType.FsmVector2 when dataVersion == 1:
                    ret = new FsmVector2 { Value = new Vector2 { x = r.ReadSingle(), y = r.ReadSingle() } };
                    break;
                case ParamDataType.Vector3:
                    ret = new Vector3 { x = r.ReadSingle(), y = r.ReadSingle(), z = r.ReadSingle() };
                    break;
                case ParamDataType.FsmVector3 when dataVersion == 1:
                    ret = new FsmVector3 { Value = new Vector3 { x = r.ReadSingle(), y = r.ReadSingle(), z = r.ReadSingle() } };
                    break;
                case ParamDataType.Quaternion:
                    ret = new Quaternion { x = r.ReadSingle(), y = r.ReadSingle(), z = r.ReadSingle(), w = r.ReadSingle() };
                    break;
                case ParamDataType.FsmQuaternion when dataVersion == 1:
                    ret = new FsmQuaternion { Value = new Quaternion { x = r.ReadSingle(), y = r.ReadSingle(), z = r.ReadSingle(), w = r.ReadSingle() } };
                    break;
                case ParamDataType.Color:
                    ret = new Color { r = r.ReadSingle(), g = r.ReadSingle(), b = r.ReadSingle(), a = r.ReadSingle() };
                    break;
                case ParamDataType.FsmColor when dataVersion == 1:
                    ret = new FsmColor { Value = new Color { r = r.ReadSingle(), g = r.ReadSingle(), b = r.ReadSingle(), a = r.ReadSingle() } };
                    break;
                case ParamDataType.Rect:
                    ret = new Rect { x = r.ReadSingle(), y = r.ReadSingle(), width = r.ReadSingle(), height = r.ReadSingle() };
                    break;
                case ParamDataType.FsmRect when dataVersion == 1:
                    ret = new FsmRect { Value = new Rect { x = r.ReadSingle(), y = r.ReadSingle(), width = r.ReadSingle(), height = r.ReadSingle() } };
                    break;
                /////////////////////////////////////////////////////////
                case ParamDataType.FsmEnum when dataVersion > 1:
                    ret = fsmEnumParams[paramDataPos];
                    break;
                case ParamDataType.FsmBool when dataVersion > 1:
                    ret = fsmBoolParams[paramDataPos];
                    break;
                case ParamDataType.FsmInt when dataVersion > 1:
                    ret = fsmIntParams[paramDataPos];
                    break;
                case ParamDataType.FsmFloat when dataVersion > 1:
                    ret = fsmFloatParams[paramDataPos];
                    break;
                case ParamDataType.FsmVector2 when dataVersion > 1:
                    ret = fsmVector2Params[paramDataPos];
                    break;
                case ParamDataType.FsmVector3 when dataVersion > 1:
                    ret = fsmVector3Params[paramDataPos];
                    break;
                case ParamDataType.FsmQuaternion when dataVersion > 1:
                    ret = fsmQuaternionParams[paramDataPos];
                    break;
                case ParamDataType.FsmColor when dataVersion > 1:
                    ret = fsmColorParams[paramDataPos];
                    break;
                case ParamDataType.FsmRect when dataVersion > 1:
                    ret = fsmRectParams[paramDataPos];
                    break;
                /////////////////////////////////////////////////////////
                case ParamDataType.FsmGameObject:
                    ret = fsmGameObjectParams[paramDataPos];
                    break;
                case ParamDataType.FsmOwnerDefault:
                    ret = fsmOwnerDefaultParams[paramDataPos];
                    break;
                case ParamDataType.FsmObject:
                    ret = fsmObjectParams[paramDataPos];
                    break;
                case ParamDataType.FsmVar:
                    ret = fsmVarParams[paramDataPos];
                    break;
                case ParamDataType.FsmString:
                    ret = fsmStringParams[paramDataPos];
                    break;
                case ParamDataType.FsmEvent:
                    ret = stringParams[paramDataPos];
                    break;
                case ParamDataType.FsmEventTarget:
                    ret = fsmEventTargetParams[paramDataPos];
                    break;
                case ParamDataType.FsmArray:
                    ret = fsmArrayParams[paramDataPos];
                    break;
                case ParamDataType.ObjectReference:
                    ret = $"ObjRef([{unityObjectParams[paramDataPos]}])";
                    break;
                case ParamDataType.FunctionCall:
                    ret = functionCallParams[paramDataPos];
                    break;
                case ParamDataType.Array:
                    ret = "[Array]";
                    break;
                
                default:
                    ret = $"[{paramDataType.ToString()} not implemented]";
                    break;
            }

            if (dataVersion == 1 && ret is NamedVariable nv)
            {
                switch (paramDataType)
                {
                    case ParamDataType.FsmInt:
                    case ParamDataType.FsmBool:
                    case ParamDataType.FsmFloat:
                    case ParamDataType.FsmVector2:
                    case ParamDataType.FsmVector3:
                    case ParamDataType.FsmQuaternion:
                    case ParamDataType.FsmColor:
                        nv.UseVariable = r.ReadBoolean();
                        int nameLength = paramByteDataSize - ((int)r.BaseStream.Position - paramDataPos);
                        nv.Name = Encoding.UTF8.GetString(r.ReadBytes(nameLength));
                        break;
                }
            }

            return ret;
        }
    }
}