using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPack : MonoBehaviour {

    public int ammoAdded = 3;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
        }
    }

    public int AddAmmo ()
    {
        return ammoAdded;
    }
}
