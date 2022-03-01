using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover2 : MonoBehaviour
{
    // Start is called before the first frame update

    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float cameraSens = 0.5f;
    float rotX = 0.0f;

    void Start()
    {
        Cursor.visible = false;
        controller = gameObject.GetComponent<CharacterController>();
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = Vector3.zero;
        if (Input.GetKey(KeyCode.W))
        {
            direction.z = 1.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direction.z = -0.8f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            direction.x = -0.8f;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direction.x = 0.8f;
        }

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = transform.right * direction.x + transform.forward * direction.z;
        controller.Move(move * Time.deltaTime * playerSpeed);

        // if (direction != Vector3.zero)
        // {
        //     gameObject.transform.forward = direction;
        // }

        controller.Move(playerVelocity * Time.deltaTime);
        CamRotate();
    }

    void CamRotate()
    {
        rotX = Input.GetAxis("Mouse X") * Time.deltaTime * cameraSens * 100;
        transform.Rotate(0, rotX, 0);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.Confined;
        rotX = 0.0f;
    
    }
}
