﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    Collider2D myCollider;
    [SerializeField] float bulletDamage = 10f;
    [SerializeField] GameObject ExplodeVfx;
    void Start()
    {
        myCollider = GetComponent<Collider2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void DoDamage()
    {
        Destroy(gameObject);
        GameObject deathVfx = Instantiate(ExplodeVfx, transform.position, Quaternion.identity);
        Destroy(deathVfx, 1f);

    }
}
