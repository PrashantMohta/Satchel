using System.Diagnostics;
using System.IO;
using System.Linq;
using static Modding.Logger;

namespace Satchel
{
    /// <summary>
    /// Utilities to work with disk IO
    /// </summary>
    public static class IoUtils {

        /// <summary>
        /// Open the file or directory at path in default program for that file
        /// </summary>
        /// <param name="path">path to the file or directory</param>
        public static void OpenDefault(string path){
            if(path != null && (Directory.Exists(path) || File.Exists(path))){
                Process.Start(path);
            }
        }        
        /// <summary>
        /// Ensure a directory exists and create if it does not
        /// </summary>
        /// <param name="directory">path of a directory</param>
        public static void EnsureDirectory(string directory){
            DirectoryExists(directory,true);
        }
        /// <summary>
        /// Ensure a directory exists
        /// </summary>
        /// <param name="directory">Path of a directory</param>
        /// <param name="create">Create if directory does not exist</param>
        /// <returns>boolean indicating if directory exists</returns>
        public static bool DirectoryExists(string directory,bool create = false){
            if(!Directory.Exists(directory)){
                if(!create){
                    return false;
                } 
                Directory.CreateDirectory(directory);
            }
            return true;
        }
        /// <summary>
        /// Check if directory has a file that matches a given pattern
        /// </summary>
        /// <param name="sourceDirectory">Path of a directory</param>
        /// <param name="match">A pattern to match</param>
        /// <param name="op">A SearchOption to use</param>
        /// <returns>boolean indicating if a file matching the pattern exist in the directory</returns>
        public static bool DirectoryHas(string sourceDirectory,string match = "*",SearchOption op = SearchOption.TopDirectoryOnly){
           return Directory.EnumerateFiles(sourceDirectory, match, op).Any();
        }

        /// <summary>
        /// Copy all files frm source into destination
        /// </summary>
        /// <param name="source"></param>
        /// <param name="destination"></param>
        /// <param name="create">Create destination directory if it does not exist</param>
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