using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CarGenerator : MonoBehaviour
{
    public GameObject [] cars;
    public Material [] colors;
    // Start is called before the first frame update
    void Start()
    {
        MeshFilter meshFilter =  gameObject.GetComponent(typeof(MeshFilter)) as MeshFilter;
        MeshFilter randomMesh =  cars[Random.Range(0, cars.Length)].GetComponent(typeof(MeshFilter)) as MeshFilter;
        meshFilter.mesh = randomMesh.sharedMesh;
        
        MeshRenderer meshRenderer =  gameObject.GetComponent(typeof(MeshRenderer)) as MeshRenderer;
        Material randomColor1 = colors[Random.Range(0, colors.Length)];
        Material randomColor2 = colors[Random.Range(0, colors.Length)];

        Material [] currentMat = meshRenderer.materials;
        currentMat[0] = randomColor1;
        currentMat[1] = randomColor2;
        currentMat[2] = currentMat[2];
        currentMat[3] = currentMat[3];
        meshRenderer.materials = currentMat;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
