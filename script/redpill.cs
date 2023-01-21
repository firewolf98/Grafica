using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class redpill : MonoBehaviour
{
    public bool goUp;
    public float speed = 1;
    public float rotationSpeed = 1;
    public int damage = 10;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SwitchDirection());''
    }

    // Update is called once per frame
    void Update()
    {
        if (goUp)
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
        else
            transform.position = transform.position - new Vector3(0, speed * Time.deltaTime, 0);
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime, Space.world);
    }

    IEnumerator SwithDirection()
    {
        while (gameObject.activeSelf)
        {
            yield return new WaitForSeconds(0.5f);
            goUp = !goUp;
        }
    }

    protected virtual void OnPicked(Collider other)
    {
        manager healthManager = other.GetComponent<manager>();
        if(!healthManager) { return; }
        healthManager.Damage(damage);
    }

    void OnTriggereEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            OnPicked();
    }
}
