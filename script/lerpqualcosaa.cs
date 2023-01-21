using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lerpqualcosaa : MonoBehaviour
{
    private Vector3 newposition;
    public float smoothing=0;
    float t=0;
    // Start is called before the first frame update
    void Start()
    {
        newposition=new Vector3(0,0.5F,0);   
    }

    // Update is called once per frame
    void Update()
    {
        t+=smoothing*Time.deltaTime;
        if(Input.GetKeyDown(KeyCode.V))
            newposition=new Vector3(Random.value*10,0.5F,Random.value*10);
        transform.position=Vector3.Lerp(transform.position,newposition,t);   
    }
}
