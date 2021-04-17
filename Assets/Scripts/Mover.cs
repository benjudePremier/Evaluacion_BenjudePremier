using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
 // Declaraciones de datos
    public float Velocidad, Velocidad2;
    private float Horizontal;
    // Ejecuta al inicio, al momento de darle play!
    void Start()
    {
        Velocidad = 4f;
        Velocidad2 = 9f;
    }

    // Ejecuta a medida que vamos jugando frame x frame
    void Update()
    {
        transform.Translate(Velocidad * Time.deltaTime, 0, 0); // Desplacamiento del objeto


        Horizontal = Input.GetAxis("Horizontal") * Velocidad2; // De izquerda a derecha.
        transform.Translate(Horizontal * Time.deltaTime, 0, 0);

    }
}
