using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTitle : MonoBehaviour
{
    // Start is called before the first frame update

    private TextLoader textLoader = TextLoader.GetInstance();

    void Start()
    {
        var text = gameObject.GetComponent(typeof(UnityEngine.UI.Text));
        Debug.Log(text.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
