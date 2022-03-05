using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerData : MonoBehaviour
{
    public Vector3 streetPos;
    public float health;
    

    public string toString(){
        return JsonUtility.ToJson(this);

    }
}
