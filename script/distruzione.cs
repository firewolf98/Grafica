using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class distruzione : MonoBehaviour
{
    public float tempo=3.0F;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempo=tempo-Time.deltaTime;
        if(tempo<0)
            Destroy(gameObject);
    }
}
