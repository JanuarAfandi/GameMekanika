using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ItemPlayer : MonoBehaviour
{
    public Text textPHSmall, textPHBig, textShield;
    public Slider slider;

    public static bool shieldActive = false;
    public GameObject myShield;
    void Start()
    {
        myShield.SetActive(false);
       slider = GameObject.FindWithTag("HealthPlayer").GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        print(slider.value);
        textPHSmall.text = DataItem.phSmall.ToString();
        textPHBig.text = DataItem.phBig.ToString();
        textShield.text = DataItem.shield.ToString();

        if (shieldActive)
        {
            myShield.SetActive(true);
        }
        else
        {
            myShield.SetActive(false);
        }
    }

    public void PHSmaallUse()
    {
        print(true);
        if(DataItem.phSmall > 0)
        {
           slider.value += 0.2f;
            DataItem.phSmall--;
        }
    }

    public void PHBigUse()
    {
        if (DataItem.phBig > 0)
        {
            slider.value += 0.5f;
            DataItem.phBig--;
        }
    }

    public void ShieldUse()
    {
        if(DataItem.shield > 0)
        {
            StartCoroutine(ShieldActive());
            DataItem.shield--;
        }
    }

    IEnumerator ShieldActive()
    {
        shieldActive = true;
        yield return new WaitForSeconds(10);
        shieldActive = false;
    }
}
