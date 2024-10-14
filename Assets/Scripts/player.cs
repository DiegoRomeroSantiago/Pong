using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    private float velocidad = 5;
    
    void Start()
    {
        
    }

    void Update()
    {
      
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(0, 1, 0) * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(0, -1, 0) * 5 * Time.deltaTime);
        }

        //todo esto es para que las palas choquen con las paredes 
        float yClamped = Mathf.Clamp(transform.position.y, -3,3);
        transform.position = new Vector3(transform.position.x, yClamped, transform.position.z);


    }
}
