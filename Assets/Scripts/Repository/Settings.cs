using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEditor;

public class Settings{

    private Hashtable settingsTable = new Hashtable();
    private static Settings instance;

    private Settings(){
        string assetPath  = Application.dataPath + "/Assets/";
        string dataPath  = Application.dataPath + "/Assets/Data/";

        settingsTable.Add("asset_path", assetPath);
        settingsTable.Add("data_path", dataPath);

        string contents = File.ReadAllText(dataPath + "settings.json");
        JObject stuff = JObject.Parse(contents);
        Debug.Log(stuff);

        Debug.Log(assetPath);
    }
    
    public static Settings GetInstance(){
        if(instance == null){
            instance = new Settings();
        }

        return instance;
    }

    public string GetValue(string key){
        if(settingsTable.Contains(key)){
            return settingsTable[key].ToString();
        }

        return null;
    }
}