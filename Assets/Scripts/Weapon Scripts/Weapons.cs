using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Weapons : MonoBehaviour {

    public GameObject ammoPrefab;
    public GameObject gunBarrel;

    [HideInInspector]
    public int ammoAmount; //How much ammo the player currently has; reduces by 1 every time the player shoots

    public int ammoCapacity; //How much ammo the gun can hold; different guns have different capacities
    public int bulletVelocity; //How fast the bullets travel; things like rockets move slower

    //Whenever the player shoots, reloadTimer is set to the reloadLength; 
    public float reloadLength; //How long it takes to reload; different guns have different reload speeds
    protected float reloadTimer;
    public float fireRate;
    protected float fireTimer;

    protected virtual void Start()
    {
        //Gun starts loaded, so sets the ammoAmount to the maximum
        ammoAmount = ammoCapacity;
    }

   
    protected virtual void Update()
    {
        //Hanles player input
        if (Input.GetKeyDown("f"))
            if (ammoAmount > 0 && reloadTimer <= 0 && fireTimer <= 0)
                FireGun();
        if (Input.GetKeyDown("r") && ammoAmount != ammoCapacity)
            ReloadGun();

        //Counts down the reload timer
        if (reloadTimer > 0)
            reloadTimer -= .1f;
        if (fireTimer > 0)
            fireTimer -= .1f;
    }

    protected virtual void FireGun()
    {
        GameObject bullet;
        bullet = Instantiate(ammoPrefab, gunBarrel.transform.position, transform.rotation);
        bullet.transform.Rotate(new Vector3(90, 0, 90));
        bullet.GetComponent<Rigidbody>().AddForce(transform.right * bulletVelocity);
        ammoAmount -= 1; 
        fireTimer = fireRate; 
    }

    protected virtual void ReloadGun()
    {
        ammoAmount = ammoCapacity;
        reloadTimer = reloadLength;
    }
}
