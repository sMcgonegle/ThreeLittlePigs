using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : Weapons {

    protected override void Start()
    {
        //Initializes ammo
        base.Start();
    }

    protected override void Update()
    {
        //Player Input
        //Counts down cooldown timer
        base.Update();
    }

    protected override void FireGun()
    {
        //Create bullet
        //Reduce ammo
        //Set reload timer
        base.FireGun();
    }

    protected override void ReloadGun()
    {
        //Sets ammo to max
        //Starts reload timer
        base.ReloadGun();
    }
}
