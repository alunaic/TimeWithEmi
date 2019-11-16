using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwap : MonoBehaviour
{
    public Camera camOne;
    public Camera camTwo;
    // Start is called before the first frame update
    void Start()
    {
        camOne.enabled = true;
        camTwo.enabled = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -1)
        {
            camTwo.enabled = true;
            camOne.enabled = false;
        }
        else
        {
            camOne.enabled = true;
            camTwo.enabled = false;
        }

    }
}
   
