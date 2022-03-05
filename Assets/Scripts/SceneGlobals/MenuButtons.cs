using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    private AssetBundle myLoadedAssetBundle;
    private string[] scenePaths;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play(){
        SceneManager.LoadScene("Street",  LoadSceneMode.Single);
    }

    public void Exit(){
        Debug.Log("Exit");
        Application.Quit();
    }

    public void Settings(){
        SceneManager.LoadScene("Settings", LoadSceneMode.Single);
    }
}
