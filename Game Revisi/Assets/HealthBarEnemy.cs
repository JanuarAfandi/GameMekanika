using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HealthBarEnemy : MonoBehaviour
{
    // Start is called before the first frame update
    public Slider slider;
    public int health, HealthLimit;
    void Start()
    {
        health = HealthLimit;
    }

    // Update is called once per frame
    void Update()
    {
        slider.minValue = 0;
        slider.maxValue = HealthLimit;
        slider.value = health;
        HealthControl();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BulletPlayer")
        {
            health -= 10;
        }
    }

    private void HealthControl()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
        }
    }
}

