using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{    
    public GameObject bullet;
    public Transform spawnBullet;

    private float timeBtwShots;
    public float startTimeBtwShots;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (Input.GetMouseButton(0))
            {
                Instantiate(bullet, spawnBullet.position, spawnBullet.rotation);
                timeBtwShots = startTimeBtwShots;
            }
        }
        else
        {
            timeBtwShots-= Time.deltaTime;
        }
    }
}
