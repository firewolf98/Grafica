using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generazionee : MonoBehaviour
{
    public GameObject block;
    public int width=10;
    public int height=4;
    // Start is called before the first frame update
    void Start()
    {
        for(int y=0;y<height;++y) {
            for(int x=0;x<width;++x) {
                Instantiate(block,new Vector3(x+1,y,0),Quaternion.identity);
                Quaternion.Euler(new Vector3(transform.rotation.x+x*20,transform.rotation.y+y*10,transform.rotation.z));
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
