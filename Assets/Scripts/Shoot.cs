using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bulletClass;
    Vector3 spawnPosition;
    Quaternion spawnRotation;
    public int bulletCount = 20;
    const float rateOfFire = 0.2f;
    const float speed = 2000f;
    float fireDelay;
    void FixedUpdate()
    {
        if (Input.GetButton("Fire1") && Time.time > fireDelay && bulletCount > 0)
        {
            spawnPosition = transform.position; spawnRotation = transform.rotation; //* Quaternion.Euler(90,0,0); 
            fireDelay = Time.time + rateOfFire;
            GameObject bulletInstance = Instantiate(bulletClass, spawnPosition, spawnRotation);// transform.up or transform.forward depending on angle of bullet     
            bulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * speed);      //Physics.IgnoreCollision(bulletInstance.GetComponent<Collider>(), GetComponent<Collider>());     
            bulletCount--;
        }
    }
}
