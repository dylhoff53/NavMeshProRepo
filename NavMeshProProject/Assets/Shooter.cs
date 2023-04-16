using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public GameObject bullet;
    public float counter;
    public float interval;

    public void Update()
    {
        counter += Time.deltaTime;
        if(counter >= interval)
        {
            ShootBullet();
            gameObject.transform.position = new Vector3(Random.Range(-9f, 9f), 1, 15);
            counter = 0f;
        }
    }

    public void ShootBullet()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
