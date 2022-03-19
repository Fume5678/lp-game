using System.Collections;
using System.Collections.Generic;
using System.IO;
using System;
using System;
using Newtonsoft.Json.Linq;
using UnityEngine;
using UnityEditor;

public class Settings : MonoBehaviour
{

    private JObject settingsTable = new JObject();
    public static Settings instance = null;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else if (instance == this)
        { // Экземпляр объекта уже существует на сцене
            Destroy(gameObject); // Удаляем объект
        }

        DontDestroyOnLoad(gameObject);

        // И запускаем собственно инициализатор
        InitializeManager();
    }

    // Метод инициализации менеджера
    private void InitializeManager()
    {
        string assetPath = Application.dataPath + "/";
        string dataPath = Application.dataPath + "/Data/";

        settingsTable["asset_path"] = assetPath;
        settingsTable["data_path"] = dataPath;

        string contents = "";
        using (StreamReader file = new StreamReader(dataPath + "settings.json"))
        {
            string ln;

            while ((ln = file.ReadLine()) != null)
            {
                contents += ln + "\n";
            }
            file.Close();
        }
        JObject stuff = JObject.Parse(contents);
        Debug.Log("contents: " + contents);
        Debug.Log("stuff: " + stuff["lang"]);

        string json = stuff.ToString(Newtonsoft.Json.Formatting.None);
        settingsTable.Add(new JProperty(json, new JObject()));

        Debug.Log("1: " + json);


        // TODO: реализовать систему слкадывания json объектов
        json = settingsTable.ToString(Newtonsoft.Json.Formatting.None);
        Debug.Log("2" + json);

        Debug.Log(assetPath);
    }


    public string GetValue(string key)
    {
        if (settingsTable[key] != null)
        {
            return settingsTable[key].ToString();
        }

        return null;
    }
}