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


    private LoadLine loadLine;

    void Start()
    {
        gear = gameObject.transform.Find("Gear").gameObject;
        gear.SetActive(false);

        // Debug.Log(obj);
        loadLine = GameObject.Find("Canvas").transform.Find("LoadPanel").GetComponent<LoadLine>();
        //loadLine.Start();
        Debug.Log(loadLine);
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
                loadLine.DrawLoadLine(0.0f, false);
            }

            if(startLooting)
            {
                time += Time.deltaTime;
                loadLine.DrawLoadLine(time/delay, true);

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
        loadLine.DrawLoadLine(0.0f, false);
        gear.SetActive(false);
    }


}
