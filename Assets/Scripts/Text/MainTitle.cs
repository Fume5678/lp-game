using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainTitle : MonoBehaviour
{
    // Start is called before the first frame update

    // private TextLoader textLoader = TextLoader.instance;

    private bool first_render = true;

    void Start()
    {

        //Debug.Log("Main Title: " + TextLoader.instance.ToString());

    }

    // Update is called once per frame
    void Update()
    {
        if (first_render)
        {
            FirstRender();
        }
    }

    void FirstRender()
    {
        

        first_render = true;
    }
}
