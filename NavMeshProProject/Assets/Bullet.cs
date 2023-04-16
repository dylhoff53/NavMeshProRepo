using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Rigidbody rig;
    public float bulletSpeed;
    public float counter;
    public void Start()
    {
        rig.velocity = transform.forward * bulletSpeed;
    }

    public void Update()
    {
        counter += Time.deltaTime;
        if(counter >= 5f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            other.GetComponent<PlayerController>().TakeDamage();
        }
    }
}
