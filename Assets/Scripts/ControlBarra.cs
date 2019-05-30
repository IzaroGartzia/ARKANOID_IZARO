using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBarra : MonoBehaviour
{

    public float fuerza = 10;
    public float velocidad = 10;
    private Rigidbody2D rb;
    public float velocBola = 10;
    private Rigidbody2D rbBola;
    public GameObject bola;
    public bool bolaMuerta = true;

   
    void Awake ()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rbBola = bola.GetComponent<Rigidbody2D>();   
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space) && bolaMuerta)
        {
            LanzarBola();
        }
    }

    void LanzarBola()
    {
        rbBola.isKinematic = false;
        rbBola.AddForce(new Vector2(0, velocBola));
        bolaMuerta = false;
    }

    void FixedUpdate()
    {
        float h = Input.GetAxis ("Horizontal");

        Vector2 vector = new Vector2(h, 0);

        rb.AddForce (vector * fuerza);
        rb.velocity = new Vector2(Mathf.Clamp(rb.velocity.x, -velocidad, velocidad), 0);

        transform.position = new Vector2(Mathf.Clamp(transform.position.x, -5.7f,5.7f), transform.position.y);

    }

 

}
