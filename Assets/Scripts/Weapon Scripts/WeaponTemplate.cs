using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Duplicate this script, rename it, and place on each new weapon
//Each weapon should have it's own script

public class WeaponTemplate : Weapons {
    //Rename WeaponTemplate after duplicating the script to the new name of the script

    protected override void Start()
    {
        //Initializes ammo
        base.Start();
    }

    protected override void Update()
    {
        //Player Input
        //Counts down cooldown timer
        base.Start();   
    }

    protected override void FireGun()
    {
        //Create bullet
        //Reduce ammo
        //Set reload timer
        base.Start();
    }

    protected override void ReloadGun()
    {
        //Sets ammo to max
        //Starts reload timer
        base.ReloadGun();
    }
}
