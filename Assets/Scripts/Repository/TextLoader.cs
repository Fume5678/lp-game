using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLoader : MonoBehaviour
{

    private Hashtable textTable = new Hashtable();

    private static TextLoader _instance;

    public static TextLoader instance { get { return _instance; } }

    private string lang;

    void Awake()
    {
        if (_instance == null)
        {
            _instance = this;
        }
        else if (_instance == this)
        { // Экземпляр объекта уже существует на сцене
            Destroy(gameObject); // Удаляем объект
        }

        DontDestroyOnLoad(gameObject);

        // И запускаем собственно инициализатор
        InitializeManager();
    }

    private void InitializeManager()
    {
        lang = Settings.instance.GetValue("lang");
        if(lang == null){
            lang = "en";
        }

        Settings.instance.GetValue("data_path");

        Debug.Log("lang: " + lang);
    }
}