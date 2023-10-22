using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparador : MonoBehaviour
{
    public GameObject bullet;
    public Transform spawnPoint;
    public float shotForce = 1500;
    
    public float shotRate = 0.5f;
    private float shotRateTime = 0;
    void Update()
    {
        // DISPARAR CON CLICK
        float v = Input.GetAxis("Jump");
        if (v > 0)
        {
            GameObject newBullet;
            newBullet = Instantiate(bullet, spawnPoint.position, spawnPoint.rotation);
            newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * shotForce);
            Destroy(newBullet, 2);
        }
        //DISPARAR CON ESPACIO
        if(Input.GetButtonDown("Fire1"))
        {
            if (Time.time > shotRateTime)
            { 
                GameObject newBullet;
                
                newBullet= Instantiate(bullet,spawnPoint.position,spawnPoint.rotation);
                newBullet.GetComponent<Rigidbody>().AddForce(spawnPoint.forward*shotForce);

                shotRateTime = Time.time + shotRate;
                Destroy(newBullet,2);
                
            }
            
        }
        
    }

}

