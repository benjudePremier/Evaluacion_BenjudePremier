using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    // Declaraciones de datos
    public float fuerzasalto;
    public LayerMask suelo;
    public Transform pie;
    public float radiopie;
    public bool Suelo;

    private Rigidbody2D rigitbody;
    //Ejecuta al inicio al momento de darle Play!
    void Start()
    {
        fuerzasalto = 50f;
        radiopie = 1f;
        Suelo = false;
        rigitbody = GetComponent<Rigidbody2D>();

    }
    void OnCollisionEnter2D(Collision2D coli)
    {
        rigitbody = GetComponent<Rigidbody2D>();
        if (coli.gameObject.tag == "jump")
        {
            rigitbody.velocity = new Vector2(rigitbody.velocity.x, fuerzasalto);


        }
    }

    // Ejecuta a medida que vamos jugando frame x frame
    void Update()
    {
        {
            Suelo = Physics2D.OverlapCircle(pie.position, radiopie, suelo);
            if (Input.GetKey("a") && Suelo == true)
            {
                rigitbody.velocity = new Vector2(rigitbody.velocity.x, fuerzasalto);
            }
        }

    }
}
    


    