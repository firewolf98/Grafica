using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparap : MonoBehaviour
{
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        projectile=Resources.Load<GameObject>("proiettile");
    }

    // Update is called once per frame
    void Update()
    {
         if(Input.GetButtonDown("Fire1")) {
            GameObject clone;
            clone=Instantiate(projectile,transform.position,transform.rotation);
            clone.GetComponent<Rigidbody>().velocity=transform.TransformDirection(Vector3.forward*10);
        }
    }
}
