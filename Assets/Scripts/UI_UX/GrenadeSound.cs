using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeSound : MonoBehaviour
{
    AudioSource drop_sound;
    bool m_Play;
    // Start is called before the first frame update
    void Start()
    {
        drop_sound = GetComponent<AudioSource>();
        drop_sound.Stop();
        m_Play = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) {
        drop_sound.Play();    
    }

}
