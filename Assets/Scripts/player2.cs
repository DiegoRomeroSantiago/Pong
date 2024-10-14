using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.E))
        {
            transform.Translate(new Vector3(0, 1, 0) * 5 * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, -1, 0) * 5 * Time.deltaTime);
        }
        //todo esto es para que las palas choquen con las paredes 
        float yClamped = Mathf.Clamp(transform.position.y, -3, 3);
        transform.position = new Vector3(transform.position.x, yClamped, transform.position.z);


    }
}
