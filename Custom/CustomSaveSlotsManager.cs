using UnityEngine.UI;

using static Satchel.SceneUtils;

namespace Satchel
{

    public class CustomSaveSlotsManager
    {
        public Dictionary<int,string> RespawnScene = new Dictionary<int,string>();
        public Dictionary<string,CustomSaveSlotParams> CustomSaveSlots = new Dictionary<string,CustomSaveSlotParams>();

        public CustomSaveSlotsManager(){
            On.GameManager.GetSaveStatsForSlot += OnGetSaveStatsForSlot;
            On.UnityEngine.UI.SaveSlotButton.PresentSaveSlot += OnPresetSaveSlot;
        }

        public void Add(CustomSaveSlotParams saveSlot){
            CustomSaveSlots[saveSlot.sceneName] = saveSlot;
        }
        public void OnPresetSaveSlot(On.UnityEngine.UI.SaveSlotButton.orig_PresentSaveSlot orig,SaveSlotButton self,SaveStats saveStats){
            orig(self,saveStats);
            if(RespawnScene.TryGetValue(PlayerDataUtils.ConvertSlotToNumber(self.saveSlot), out var scene) && CustomSaveSlots.TryGetValue(scene , out var customSaveSlot)){
                if(customSaveSlot.sceneTitle != null){
                    self.locationText.text = customSaveSlot.sceneTitle;
                }
                if(customSaveSlot.background != null){
                    self.background.sprite = customSaveSlot.background;
                }
            }
        }
        public void OnGetSaveStatsForSlot(On.GameManager.orig_GetSaveStatsForSlot orig,GameManager self,int SaveSlot,Action<SaveStats> Callback){
           PlayerDataUtils.GetPlayerDataForSlot(SaveSlot, pd => { 
               RespawnScene[SaveSlot] = pd.respawnScene;
            });
           orig(self,SaveSlot,Callback);
        }
    }
}