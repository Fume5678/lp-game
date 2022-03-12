using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextLoader : MonoBehaviour{

    private Hashtable textTable = new Hashtable();

    private Settings settings = Settings.GetInstance(); 

    private static TextLoader instance;
    
    private string lang; 

    private TextLoader(){
        lang = Settings.GetInstance().GetValue("lang");

        Debug.Log(lang);
    }
    
    public static TextLoader GetInstance(){
        if(instance == null){
            instance = new TextLoader();
        }

        return instance;
    }
}