using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadLine : MonoBehaviour
{    
    RectTransform loadLine;
    object locker = new object();

    // Start is called before the first frame update
    public void  Start()
    {   
        loadLine = gameObject.transform.Find("LoadLine").GetComponentInChildren<RectTransform>();
        if( loadLine == null){
            throw new System.Exception("Failed to found LoadLine");
        }

        gameObject.SetActive(false);
    }

    public void Update(){

    }
    
    public void DrawLoadLine(float percent, bool isEnabled){
        lock (locker){
            if(!isEnabled){
                gameObject.SetActive(false);
                return;
            }
            gameObject.SetActive(true);
            Debug.Log("Loading " + percent);
            
            Vector3 scale = new Vector3(percent, 1, 1);
            loadLine.localScale = scale;
        }
    }
}
