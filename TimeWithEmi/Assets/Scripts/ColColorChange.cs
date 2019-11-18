using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColColorChange : MonoBehaviour
{
    public string ringName; //name the ring in inspect
                            // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        GameObject ring = GameObject.Find(ringName);  //change the color on the ring
        ColorChange colorChanger = ring.GetComponent<ColorChange>();
        colorChanger.ChangeColor();
        AudioSource score = GetComponent<AudioSource>();
        score.Play();
    }
}