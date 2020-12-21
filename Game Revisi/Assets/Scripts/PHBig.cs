using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PHBig : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        DataItem.phBig = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DataItem.phBig++;
            Destroy(gameObject);
        }
    }
}
