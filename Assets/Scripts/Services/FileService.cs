using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public static class FileService
{
    public static readonly string UserFileName = "userData.json";

    public static void SaveObject<T>(T Object)
    {
        var jsonData = JsonUtility.ToJson(Object);
        var filepath = Application.persistentDataPath + UserFileName;
        File.WriteAllText(filepath, jsonData);
    }

    ///// <summary>
    ///// Saves player data as json to persistent data path. 
    ///// Overwrites every single time player data.
    ///// </summary>
    ///// <param name="playerData"></param>
    //public static void SavePlayerData(Player playerData)
    //{
    //    var playerJson = JsonUtility.ToJson(playerData);
    //    var filePath = Application.persistentDataPath + PlayerDataPath;
    //    File.WriteAllText(filePath, playerJson);
    //}
    ///// <summary>
    ///// Handle exceptions better
    ///// </summary>
    ///// <returns></returns>
    //public static Player LoadPlayerData()
    //{
    //    try
    //    {
    //        var filePath = Application.persistentDataPath + PlayerDataPath;
    //        var playerJson = File.ReadAllText(filePath);
    //        Player player = JsonUtility.FromJson<Player>(playerJson);
    //        return player;
    //    }
    //    catch (FileNotFoundException fex)
    //    {
    //        Debug.Log(fex.Message);
    //        throw fex;
    //    }
    //}

}
