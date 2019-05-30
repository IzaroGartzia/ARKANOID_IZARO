using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSuelo : MonoBehaviour
{
    public Vector2 posInicial;
    public GameObject bola;
    private Rigidbody2D rbBola;
    public GameObject jugador;
    public ControlBarra jugadorScript;

    void Start()
    {
        rbBola = bola.GetComponent<Rigidbody2D>();
        posInicial = bola.transform.position;
    }

    void OnTriggerEnter2D(Collider2D otro)
    {
        if(otro.tag == "bola")
        {
            bola.transform.position = new Vector3(jugador.transform.position.x,jugador.transform.position.y+0.6f,jugador.transform.position.z);
            bola.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            rbBola.isKinematic = true;
            jugadorScript.bolaMuerta = true;
        }
    }
}
