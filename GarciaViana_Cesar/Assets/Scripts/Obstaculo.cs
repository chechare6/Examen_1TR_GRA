using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstaculo : MonoBehaviour
{
    private CrearObstaculo crearObstaculo;
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            Destroy(this.gameObject);
                      
        }
        crearObstaculo.contador = crearObstaculo.contador - 1; 
    }
}
