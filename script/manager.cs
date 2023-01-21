using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class manager : MonoBehaviour
{

    public int health;
    public int maxHealth;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   public void Damage(int damageTaken)
    {
        health -= damageTaken;
        if(health<1)
        {

        }
        if(health>maxHealth)
        {
            health = maxHealth;
        }
    }
}
