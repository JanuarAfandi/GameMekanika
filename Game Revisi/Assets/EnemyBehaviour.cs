﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    public float Hitpoints;
    public float MaxHitpoints = 5;
    public HealthBarBehaviour Healthbar;
    // Start is called before the first frame update
    void Start()
    {
        Hitpoints = MaxHitpoints;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
    }

    public void TakeHit(float damage)
    {
        Hitpoints -= damage;
        Healthbar.SetHealth(Hitpoints, MaxHitpoints);
        if (Hitpoints <= 0)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
