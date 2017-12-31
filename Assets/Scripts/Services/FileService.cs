using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class FileService
{
    public static User UserData;

    public static void SaveObject<T>(T Object, string fileName)
    {
        var jsonData = JsonUtility.ToJson(Object);
        var filePath = Application.persistentDataPath + fileName;
        File.WriteAllText(filePath, jsonData);
    }

    public static T LoadData<T>(string fileName)
    {
        try
        {
            var filePath = Application.persistentDataPath + fileName;
            var jsonData = File.ReadAllText(filePath);
            T loadedObject = JsonUtility.FromJson<T>(jsonData);
            return loadedObject;
        }
        catch(FileNotFoundException fex)
        {
            throw fex;
        }
    }
}
