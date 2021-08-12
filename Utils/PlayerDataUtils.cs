using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Modding;
using Modding.Patches;

namespace DandyCore{
    public class PlayerDataUtils{

        public static int ConvertSlotToNumber(SaveSlotButton.SaveSlot saveSlot)
        {
            if(saveSlot == SaveSlotButton.SaveSlot.SLOT_1) {
                return 1;
            }
            if(saveSlot == SaveSlotButton.SaveSlot.SLOT_2) {
                return 2;
            }
            if(saveSlot == SaveSlotButton.SaveSlot.SLOT_3) {
                return 3;
            }
            if(saveSlot == SaveSlotButton.SaveSlot.SLOT_4) {
                return 4;
            }
            return 0;
        }
        public static void GetPlayerDataForSlot(int saveSlot, Action<PlayerData> callback)
        {
        
            Platform.Current.ReadSaveSlot
            (
                saveSlot,
                delegate(byte[] fileBytes)
                {
                    if (fileBytes == null)
                    {
                        if (callback != null)
                        {
                            CoreLoop.InvokeNext(delegate { callback(null); });
                        }

                        return;
                    }

                    try
                    {
                        bool flag = GameManager.instance.gameConfig.useSaveEncryption && !Platform.Current.IsFileSystemProtected;
                        string json;
                        if (flag)
                        {
                            BinaryFormatter binaryFormatter = new BinaryFormatter();
                            MemoryStream serializationStream = new MemoryStream(fileBytes);
                            string encryptedString = (string) binaryFormatter.Deserialize(serializationStream);
                            json = Encryption.Decrypt(encryptedString);
                        }
                        else
                        {
                            json = Encoding.UTF8.GetString(fileBytes);
                        }
                        SaveGameData saveGameData;
                        try
                        {
                            saveGameData = JsonConvert.DeserializeObject<SaveGameData>(json, new JsonSerializerSettings()
                            {
                                ContractResolver = ShouldSerializeContractResolver.Instance,
                                TypeNameHandling = TypeNameHandling.Auto,
                                ObjectCreationHandling = ObjectCreationHandling.Replace,
                                Converters = JsonConverterTypes.ConverterTypes
                            });
                        } 
                        catch (Exception)
                        {
                            // Not a huge deal, this happens on saves with mod data which haven't been converted yet.
                            Modding.Logger.LogWarn($"Failed to get save stats for slot {saveSlot} using Json.NET, falling back");
                            
                            saveGameData = JsonUtility.FromJson<SaveGameData>(json);
                        }
                        
                        PlayerData playerData = saveGameData.playerData;
                        
                        if (callback != null)
                        {
                            CoreLoop.InvokeNext(delegate { callback(playerData); });
                        }
                    }
                    catch (Exception ex)
                    {
                        Debug.LogError
                        (
                            string.Concat
                            (
                                new object[]
                                {
                                    "Error while loading save file for slot ",
                                    saveSlot,
                                    " Exception: ",
                                    ex
                                }
                            )
                        );
                        if (callback != null)
                        {
                            CoreLoop.InvokeNext(delegate { callback(null); });
                        }
                    }
                }
            );
        }
    
    
    }

    
}