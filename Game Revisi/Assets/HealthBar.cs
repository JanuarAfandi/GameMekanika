using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider slider;
    public static int health;
    public int HealthLimit;
    void Start()
    {
        slider = GameObject.FindWithTag("HealthPlayer").GetComponent<Slider>();
        health = HealthLimit;
        slider.value = 1;
    }

    // Update is called once per frame
    void Update()
    {   
        HealthControl();
        print(slider.value);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "BulletEnemy" && !ItemPlayer.shieldActive)
        {
            slider.value -= 0.1f;
        }
    }

    private void HealthControl()
    { 
        if (slider.value <= 0)
        {
      //      Destroy(this.gameObject);
        }

        if(slider.value > 1)
        {
            slider.value = 0.1f;
        }
    }
}
