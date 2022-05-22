
namespace Satchel.Futils.Serialiser{

    public static class utils{
        internal static ActionScriptEntry GetActionData(HutongGames.PlayMaker.FsmState state,ActionScriptEntry ase, int i, int dataVersion){
            var ActionData = state.ActionData;
            var _actionNames = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<string>>(ActionData, "actionNames");
            Modding.Logger.Log(_actionNames[i] + " | " + ase.Name );
            if(ase.Name != _actionNames[i]){ 
                return ase; 
            }
            var _paramName = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<string>>(ActionData, "paramName");
            var _actionStartIndex = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<int>>(ActionData, "actionStartIndex");
            var _paramDataType = ReflectionHelper.GetField<HutongGames.PlayMaker.ActionData, List<ParamDataType>>(ActionData, "paramDataType");

            int startIndex = _actionStartIndex[i];
            int endIndex;
            if (i == _actionNames.Count - 1)
                endIndex = _paramDataType.Count;
            else
                endIndex = _actionStartIndex[i + 1];

            for (int j = startIndex; j < endIndex; j++)
            {
                string paramName = _paramName[j];
                object obj = ActionReader.GetFsmObject(ActionData, j, dataVersion);
            
                ase.Values.Add(new Tuple<string, object>(paramName, obj));
            }
            return ase;
            
        }

        /*private static void GetActionData(List<ActionScriptEntry> list, ActionData actionData, int dataVersion)
        {
            for (int i = 0; i < actionData.actionNames.Count; i++)
            {
                string actionName = actionData.actionNames[i];
                if (actionName.Contains("."))
                    actionName = actionName.Substring(actionName.LastIndexOf(".") + 1);

                int startIndex = actionData.actionStartIndex[i];
                int endIndex;
                if (i == actionData.actionNames.Count - 1)
                    endIndex = actionData.paramDataType.Count;
                else
                    endIndex = actionData.actionStartIndex[i + 1];

                ActionScriptEntry entry = new ActionScriptEntry();
                entry.Values = new List<Tuple<string, object>>();
                for (int j = startIndex; j < endIndex; j++)
                {
                    string paramName = actionData.paramName[j];
                    //object obj = ActionReader.GetFsmObject(actionData, j, dataVersion);
                    entry.Values.Add(new Tuple<string, object>(paramName, obj));
                }

                entry.Name = actionName;
                entry.Enabled = actionData.actionEnabled[i];

                list.Add(entry);
            }
        }*/
    }
    public class FsmState
    {
        public string name;
        public string description;
        public FsmTransition[] transitions;
        public List<ActionScriptEntry> actionData;
        public byte colorIndex;
        public Rect position;
        public bool isBreakpoint;
        public bool isSequence;
        public bool hideUnused;

        public FsmState(HutongGames.PlayMaker.FsmState state){
            name = state.Name;
            description = state.Description;
            colorIndex = (byte)state.ColorIndex;
            position = state.Position;
            isBreakpoint = state.IsBreakpoint;
            isSequence = state.IsSequence;
            hideUnused = state.HideUnused;
            transitions = new FsmTransition[state.Transitions.Length];
            var i = 0;
            foreach(var transition in state.Transitions){
                transitions[i] = new FsmTransition(transition);
                i++;
            }
            actionData = new List<ActionScriptEntry>();

            //create action data based on actual actions list
            i = 0;
            foreach(var action in state.Actions){
                var ase = new ActionScriptEntry();
                ase.Name = action.GetType().ToString();
                ase.Enabled = action.Enabled;
                ase.Values = new List<Tuple<string, object>>();
                actionData.Add(ase);
                i++;
            }
            
            //state.ActionData;
        }
        public override string ToString()
        {
            return $"State {name}";
        }
    }
    public class FsmEvent
    {
            public string name;
            public bool isSystemEvent;
            public bool isGlobal;
        public FsmEvent(){

        }
        public FsmEvent( HutongGames.PlayMaker.FsmEvent ev) {
            name = ev.Name;
            isSystemEvent = ev.IsSystemEvent;
            isGlobal = ev.IsGlobal;
         }

        public override string ToString()
        {
            return $"Event({name})";
        }
    }
    public class FsmTransition
    {
        public FsmEvent fsmEvent;
        public string toState;
        public int linkStyle;
        public int linkConstraint;
        public byte colorIndex;
        public FsmTransition(HutongGames.PlayMaker.FsmTransition transition) {
            toState = transition.ToState;
            fsmEvent = new FsmEvent(transition.FsmEvent);
            linkStyle = (int)transition.LinkStyle;
            linkConstraint = (int)transition.LinkConstraint;
            colorIndex = (byte)transition.ColorIndex;
         }
       
        public override string ToString()
        {
            return $"Transition({fsmEvent.name} -> {toState})";
        }
    }
    /// <summary>
    /// Create a Serializable representation of an FSM
    /// </summary>
    public class FsmDataInstance
    {
        public string fsmName;
        public string goName;
        public List<FsmState> states = new List<FsmState>();
        public List<FsmEvent> events = new List<FsmEvent>();
        public List<FsmVariableData> variables = new List<FsmVariableData>();
        public List<FsmNodeData> globalTransitions = new List<FsmNodeData>();
        public int dataVersion;

        public FsmDataInstance(PlayMakerFSM fsm){
            this.fsmName = fsm.Fsm.Name;
            dataVersion = fsm.Fsm.DataVersion;
            this.goName = fsm.gameObject.name;
            var i = 0;
            fsm.GiveStatesPosition();
            foreach(var state in fsm.Fsm.States){
                states.Add(new FsmState(state));
                //add action data for existing actions from serialised data
                var j = 0;
                foreach(var ase in states[i].actionData){
                    try{
                       utils.GetActionData(state,ase,j,dataVersion);
                    } catch(Exception e){
                        Modding.Logger.Log(e.ToString());
                    }
                    j++;
                }
                
                i++;
            }
            foreach(var ev in fsm.Fsm.Events){
                events.Add(new FsmEvent(ev));
            }   
            var V = fsm.Fsm.Variables;

            variables.Add(new FsmVariableData("Floats",(NamedVariable[])V.FloatVariables));
            variables.Add(new FsmVariableData("Ints",(NamedVariable[])V.IntVariables));
            variables.Add(new FsmVariableData("Bools",(NamedVariable[])V.BoolVariables));
            variables.Add(new FsmVariableData("Strings",(NamedVariable[])V.StringVariables));

            variables.Add(new FsmVariableData("Vector2s",(NamedVariable[])V.Vector2Variables));
            variables.Add(new FsmVariableData("Vector3s",(NamedVariable[])V.Vector3Variables));
            variables.Add(new FsmVariableData("Colors",(NamedVariable[])V.ColorVariables));
            variables.Add(new FsmVariableData("Rects",(NamedVariable[])V.RectVariables));
            variables.Add(new FsmVariableData("Quaternions",(NamedVariable[])V.QuaternionVariables));

            variables.Add(new FsmVariableData("GameObjects",(NamedVariable[])V.GameObjectVariables));
            variables.Add(new FsmVariableData("Objects",(NamedVariable[])V.ObjectVariables));
            variables.Add(new FsmVariableData("Materials",(NamedVariable[])V.MaterialVariables));
            variables.Add(new FsmVariableData("Textures",(NamedVariable[])V.TextureVariables));

        }
    }
    public class FsmVariableData
    {
        public string Type { get; set; }
        public List<Tuple<string, object>> Values { get; set; }
        public FsmVariableData(string type,NamedVariable[] Vars){
            Type = type;
            Values = new List<Tuple<string, object>>();
            foreach(var v in Vars){
                Values.Add(new Tuple<string,object>(v.Name,v.RawValue));
            }
            
        }
    }
    public class FsmGlobalTransition
    {
        public FsmEvent fsmEvent;
        public string toState;
        public int linkStyle;
        public int linkConstraint;
        public byte colorIndex;
    }
    public class ActionScriptEntry
    {
        public string Name ;
        public List<Tuple<string, object>> Values ;
        public bool Enabled ;
    }
    public class FsmNodeData
    {
        public bool isGlobal;
        public string name;
        public FsmTransition[] transitions;
        
        public Rect transform;
        public Color stateColor;
        public Color transitionColor;
        
    }
}