using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{


    public float speedMove = 0.1f;
    public float cameraSens = 0.1f;
    Vector3 direction;

    Vector3 lastMousePos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1.0f;
        }
        if  (Input.GetKey(KeyCode.S))
        {
            direction.z = -0.6f;
        }
        if  (Input.GetKey(KeyCode.A))
        {
            direction.x = -0.6f;
        }
        if  (Input.GetKey(KeyCode.D))
        {
            direction.x = 0.6f;
        }

        transform.Translate(direction * speedMove);
        CamRotate();
    }

    // Update is called once per frame
    void CamRotate()
    {
        float speed = 0;

        if(Input.GetAxis("Mouse X") != 0){
            Vector3 mousePos = Input.mousePosition;
            speed = mousePos.x - lastMousePos.x;
            transform.Rotate(0, speed * cameraSens, 0);

            lastMousePos = mousePos;
        }
    }   

}
