using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : Projectile {

    protected override void OnCollisionEnter(Collision col)
    {
        //Is destroyed when it collides with something
        base.OnCollisionEnter(col);
    }
}
