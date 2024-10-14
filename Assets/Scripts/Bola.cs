using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Bola : MonoBehaviour
{
    int gol1;
    int gol2;
    [SerializeField]private TMP_Text goals1;
    [SerializeField]private TMP_Text goals2;
    private Vector3 positionbola;
    Rigidbody2D rb ;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<Rigidbody2D>().AddForce(new Vector3(1,1,0).normalized * 10 , ForceMode2D.Impulse );
        positionbola = transform.position;
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //esto hace que muestre que se ha marcado un gol en porteria1
        if (collision.gameObject.CompareTag("gol1"))
        {
            gol1++;
            goals1.SetText("goals" + goals1);
            transform.position = positionbola;//esto hace que vuelva a la posicion inical
            ReiniciarBola();
        }
        //esto hace que muestre que se ha marcado un gol en porteria2
        else if (collision.gameObject.CompareTag("gol2"))
        {
            gol2++;
            goals2.SetText("goals" + goals2);
            transform.position = positionbola; //esto hace que vuelva a la posicion inical
            ReiniciarBola();
        }
        
    }  
    void ReiniciarBola()
    {
        rb.velocity = new Vector3(0,0,0);

        int positionXaleatoria = Random.Range(0, 6);
        int positionYaleatoria = Random.Range(0, 6);

       

        while (positionXaleatoria == 0) 
        {
             positionXaleatoria = Random.Range(0, 6);
             positionYaleatoria = Random.Range(0, 6);
        }
        rb.AddForce(new Vector3(positionXaleatoria, positionYaleatoria).normalized * 5, ForceMode2D.Impulse);

    }
}

