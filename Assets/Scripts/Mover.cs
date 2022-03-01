using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public float speedMove = 0.1f;
    bool isMoving = false;
    public float cameraSens = 0.1f;
    Vector3 direction;
    Vector3 lastMousePos;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {   
        isMoving = false;
        direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1.0f;
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -0.8f;
            isMoving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -0.8f;
             isMoving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 0.8f;
            isMoving = true;
        }


        //rb.AddRelativeForce(direction * speedMove,  ForceMode.Force); 
        //transform.Translate(direction * speedMove);
        Vector3 moveBy = transform.right * direction.x + transform.forward * direction.z;
        rb.MovePosition(transform.position + moveBy * speedMove * Time.deltaTime);
        CamRotate();
    }

    void CamRotate()
    {
        float delta = 0;

        if (Input.GetAxis("Mouse X") != 0)
        {
            Vector3 mousePos = Input.mousePosition;
            delta = mousePos.x - lastMousePos.x;
            transform.Rotate(new Vector3(0, delta * cameraSens, 0), Space.Self);
            rb.velocity = rb.velocity.magnitude*transform.forward;
            lastMousePos = mousePos;
        }
    }

}
