using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public int lifeTime; //How long until projectile is destroyed
    protected float destroyTimer; //When it hits 0, projectile is destroyed

    protected virtual void Start()
    {
        destroyTimer = lifeTime;
    }

    protected virtual void Update()
    {
        if (destroyTimer <= 0)
            DestroyObject(gameObject);
        else
            destroyTimer -= .1f;
    }

    protected virtual void OnCollisionEnter(Collision col)
    {
        Destroy(gameObject);
    }
}
