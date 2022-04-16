using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AskAnim : MonoBehaviour
{
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        Debug.Log("Collide");
        animator.SetTrigger("collide");
    }

    private void OnTriggerExit(Collider other)  {
        Debug.Log("End collide");
        animator.SetTrigger("end_collide");
    }
}
