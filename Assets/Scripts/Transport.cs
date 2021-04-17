using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transport : MonoBehaviour
{
    // Declaraciones de datos
    public GameObject green1, green2, blue1, blue2, red1, red2;
    public float x, y;


    // Ejecuta al inicio al momneto de darle Play!
    private void Start()
    {
        // Inicializacion valores
        x = 5f;
        y = 11f;
    }

    // Uso de Oncolllision asociado con diferentes tag para la Teletranportacion
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Green")

        {
            this.transform.position = new Vector2(green1.transform.position.x, green2.transform.position.y);

        }
        if (col.gameObject.tag == "Blue")
        {
            this.transform.position = new Vector2(blue1.transform.position.x, blue2.transform.position.z);
        }
        if (col.gameObject.tag == "Red")
        {
            this.transform.position = new Vector2(x, y);

            
        }
    }
}

    




