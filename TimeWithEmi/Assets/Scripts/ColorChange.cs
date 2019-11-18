using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Material[] materials;
    MeshRenderer meshRenderer;
    int materialNumber = 0;
    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>(); 

        meshRenderer.material = materials[0]; //start at 0

    }

    // Update is called once per frame
    void Update()
    {
        
    }

  

    public void ChangeColor()
    {
        materialNumber++; //go through the mat array
        meshRenderer.material = materials[materialNumber % materials.Length];
    }
}
