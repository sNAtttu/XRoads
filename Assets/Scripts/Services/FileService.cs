using System;
using System.IO;
using Classes;
using UnityEngine;

namespace Services
{
    public static class FileService
    {
        public static User UserData;

        public static void SaveObject<T>(T Object, string filePath)
        {
            var jsonData = JsonUtility.ToJson(Object);
            var path = Application.persistentDataPath + filePath;
            File.WriteAllText(path, jsonData);
        }

        public static T LoadData<T>(string filePath)
        {
            try
            {
                var path = Application.persistentDataPath + filePath;
                var jsonData = File.ReadAllText(path);
                T loadedObject = JsonUtility.FromJson<T>(jsonData);
                return loadedObject;
            }
            catch(FileNotFoundException fex)
            {
                Debug.LogError(fex);
                throw fex;
            }
            catch(DirectoryNotFoundException dex)
            {
                Debug.LogError(dex);
                throw dex;
            }
            catch (Exception ex)
            {
                Debug.LogError(ex);
                throw ex;
            }
        }
    }
}
