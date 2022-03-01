using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLooter : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject gear;
    bool isLooted;
    bool canLoot;
    bool startLooting;
    public float delay = 4.0f;
    float time; 
    
    void Start()
    {
        gear = gameObject.transform.Find("Gear").gameObject;
        gear.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(canLoot && !isLooted){
            if (Input.GetKeyDown(KeyCode.E)){
                startLooting = true;
            }

            if (Input.GetKeyUp(KeyCode.E)){
                time = 0.0f;
                startLooting = false;
            }

            if(startLooting)
            {
                time += Time.deltaTime;

                if(time > delay){
                    LootAction();
                }
            }
            
        }
        
    }

    private void OnTriggerEnter(Collider other) {
        if(other.name == "Player" && !isLooted){
            gear.SetActive(true);
            canLoot = true;
            time = 0.0f;
        }
    }

    private void OnTriggerExit(Collider other) {
        if(other.name == "Player"){
            gear.SetActive(false);
            canLoot = false;
        }
    }

    void LootAction(){
        isLooted = true;
        gear.SetActive(false);
    }

}
