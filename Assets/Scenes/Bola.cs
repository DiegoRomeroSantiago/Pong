using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Bola : MonoBehaviour
{
    int gol1;
    int gol2;
    void Start()
    {
        GetComponent<Rigidbody2D>().AddForce(new Vector3(1,1,0).normalized * 10 , ForceMode2D.Impulse );
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "gol1") 
        {
            gol1 ++;
        }

        if (collision.gameObject.tag == "gol2")
        {
            gol2++;
        }


    }
     
}   