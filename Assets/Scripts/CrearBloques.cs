using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearBloques : MonoBehaviour
{

    public GameObject BloquePrefab;
    public Material[] materiales;
    public GameObject Bloques;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("CrearBloques_", 0.5f);
    }

      
    void CrearBloques_()
    {
        CrearFilas(6);
        //CrearIrrompibles();
    }

    void CrearFilas(int numFilas)
    {
        for(float i = 0; i<= numFilas; i++)
        {
            CrearFila(4-(i/2));
        }
    }

    void CrearFila(float y)
    {
        for(int i = 0; i <= 7; i++)
        {
            GameObject BloqueTemp = Instantiate(BloquePrefab, new Vector2(i-(7-i), y), Quaternion.identity);
            BloqueTemp.GetComponent<ControlBloque>().Aplicarcolor(materiales[Random.Range(0, materiales.Length)], materiales);
            BloqueTemp.transform.parent = Bloques.transform;
        } 
    }

    /*
    void CrearIrrompibles()
    {
        GameObject[] bloques = GameObject.FindGameObjectsWithTag("Bloque");


        for (int i = 0; i < bloques.Length; i++)
        {
                int aletorio = Random.Range(0, 10);
                if (aletorio == 1)
            {

                bloques[i].GetComponent<ControlBloque>().CambiarAIrrompible();
            }

        }

    }
    */

}


// MIRAR EL BLOQUE PREFAB... A VER POR QUE A MI NO ME HACE CASO....
