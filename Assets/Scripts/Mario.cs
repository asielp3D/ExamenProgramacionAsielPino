using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mario : MonoBehaviour
{
    SpriteRenderer spriterenderer;
    Rigidbody2D rbody;
    GroundSensor groundsensor;
    BoxCollider2D boxcollider2D;

    float movimiento;
    public float velocidad;
    public float salto;
    // Start is called before the first frame update
    void Start()
    {
        spriterenderer = GetComponent<SpriteRenderer>();
        rbody = GetComponent<Rigidbody2D>();
        groundsensor = GameObject.Find("GroundSensor").GetComponent<GroundSensor>();

        velocidad = 5.5f;
        salto = 8f;


        
    }

    // Update is called once per frame
    void Update()
    {
        movimiento = Input.GetAxis("Horizontal");

        if(movimiento > 0)
        {
            spriterenderer.flipX = false;
        }

        if(movimiento < 0)
        {
            spriterenderer.flipX = true;
        }

        if(Input.GetButtonDown ("Jump")&& groundsensor.groundsensor)
        {
            rbody.AddForce(Vector2.up * salto, ForceMode2D.Impulse);
        }
    }

   

   void FixedUpdate() 
   {
    rbody.velocity = new Vector2 (movimiento*velocidad, rbody.velocity.y);
   }

}
