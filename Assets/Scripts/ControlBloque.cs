using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBloque : MonoBehaviour
{

    public Material material;
    public Material IrrompibleColor;
    public int puntos = 10;
    public bool Roto = true;
    public int golpesNecesarios = 1;
    public int golpesDados = 0;
    //public Material[] materiales;

   void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "bola" && Roto)
        {
            golpeBloque();
        }
    }

    void golpeBloque()
    {
        golpesDados += 1;

        if(golpesDados == golpesNecesarios)
        {
            Destruir();
        }
    }

    void Destruir()
    {
        Destroy(gameObject);
    }


    public void Aplicarcolor(Material material_, Material[] materiales)
    {
        GetComponent<MeshRenderer>().material = material_;
        material = material_;

        for(int i=1; i<= materiales.Length - 1; i++)
        {

            if (material == materiales[i])
            {
                puntos = (i*10)+10;
            }
        }
    }

    void CambiarAIrrompible()
    {
        Roto = false;
        GetComponent<MeshRenderer>().material = IrrompibleColor;
        puntos = 0;

    }
}
