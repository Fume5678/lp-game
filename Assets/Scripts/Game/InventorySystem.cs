using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{

    private ArrayList<Item> inventory;
    private Hashtable<long, Sprite> sprites;

    private EquipPanel<Equipable> panel;
    private Equipable hand;

    // Start is called before the first frame update
    void Start()
    {
        LoadPanel();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LoadInvetory(){

    }

    void LoadPanel(){
        
    }

}
