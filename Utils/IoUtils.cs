using System;
using System.IO;
using System.Diagnostics;
using System.Linq;

using UnityEngine;
using UnityEngine.SceneManagement;
using GlobalEnums;

using Modding;
using static Modding.Logger;

namespace Satchel{

    public static class IoUtils {

        public static void OpenDefault(string path){
            if(path != null && (Directory.Exists(path) || File.Exists(path))){
                Process.Start(path);
            }
        }        

        public static void EnsureDirectory(string directory){
            DirectoryExists(directory,true);
        }
        public static bool DirectoryExists(string directory,bool create = false){
            if(!Directory.Exists(directory)){
                if(!create){
                    return false;
                } 
                Directory.CreateDirectory(directory);
            }
            return true;
        }
        public static bool DirectoryHas(string sourceDirectory,string match = "*",SearchOption op = SearchOption.TopDirectoryOnly){
           return Directory.EnumerateFiles(sourceDirectory, match, op).Any();
        }

        public static void DirectoryCopyAllFiles(string source,string destination,bool create = false){
            if(!Directory.Exists(source) || (!create && !Directory.Exists(destination))){
                return;
            }
            DirectoryExists(destination,create);

            string[] files = Directory.GetFiles(source);
            foreach(string file in files){
                try{
                    File.Copy(file, Path.Combine(destination,Path.GetFileName(file)));
                } catch (Exception e){
                    Log("A File could not be Copied : " + e.ToString());
                }
            }
        }

    } 
}