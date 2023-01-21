using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPill : Pill
{
    public int damage = 10;

    protected override void OnPicked(Collider other)
    {
        base.OnPicked(other);
        HealthManager healthManager = other.GetComponent<HealthManager>();
        if(!healthManager) { return; }

        healthManager.Damage(damage);
        Destroy(gameObject, 2);
    }
}
