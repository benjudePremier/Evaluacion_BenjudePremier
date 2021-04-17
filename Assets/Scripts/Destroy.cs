using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
   // Declaraciones de datos
    public Rigidbody2D rigitbody;
    public GameObject rats;

    // Ejecuta al inicio al momento de darle Play!
    private void Start()
    {
        rigitbody = GetComponent<Rigidbody2D>();

    }

    // Aqui uso Onconllisiony fucncion para destruir enemigo cuando se toca con objeto
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("rat"))
        {
            Destroy(collision.gameObject);
                
        }
        if (collision.collider.CompareTag("force"))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(4, 100));
            
        }
        



    }
   }




    
       
        
      


