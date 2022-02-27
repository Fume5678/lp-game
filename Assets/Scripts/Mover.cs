using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speedMove = 0.1f;
    float speed = 0.0f;
    bool isMoving = false;
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
        isMoving = false;
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1.0f;
            speed += 0.03f;
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -0.8f;
            speed += 0.03f;
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -0.8f;
            speed += 0.03f;
             isMoving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 0.8f;
            speed += 0.03f;
            isMoving = true;
        }

        if(speed > speedMove){
            speed = speedMove;
        }
        if(!isMoving){
            speed = 0.0f;
        }

        transform.Translate(direction * speed / 10);
        CamRotate();
    }

    // Update is called once per frame
    void CamRotate()
    {
        float speed = 0;

        if (Input.GetAxis("Mouse X") != 0)
        {
            Vector3 mousePos = Input.mousePosition;
            speed = mousePos.x - lastMousePos.x;
            transform.Rotate(0, speed * cameraSens, 0);
            lastMousePos = mousePos;
        }
    }

}
