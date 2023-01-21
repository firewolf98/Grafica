using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collid : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter() {
        Color color=GetComponent<Renderer>().material.color;
        color.r=Random.value;
        color.g=Random.value;
        color.b=Random.value;
        color.a=1F;
        GetComponent<Renderer>().material.color=color;
    }
}
