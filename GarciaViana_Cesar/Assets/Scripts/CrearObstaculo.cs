using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearObstaculo : MonoBehaviour
{   
    [SerializeField] Text ContadorColumnas;
    private int contador;
    [SerializeField] GameObject Obstaculo;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("ObstaculoCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        //AumentoDificultad();
        ContadorColumnas.text = "Nº de columnas: " + contador;    
    }

   void GenerarObstaculo(){
       float randomX = Random.Range(-9.5f,9.5f);
       float randomZ = Random.Range(-9.5f,9.5f);

       Vector3 RndmPos = new Vector3(randomX,0,randomZ);
       Instantiate(Obstaculo, RndmPos, Quaternion.identity);

    }

    IEnumerator ObstaculoCoroutine()
    {
        for(contador=1;contador<=5 ; contador++){
            GenerarObstaculo();
            yield return new WaitForSeconds(2);
        }
        for(contador=contador; contador <= 10 && contador>5; contador++){
            GenerarObstaculo();
            yield return new WaitForSeconds(1);
        }
        for(contador=contador; contador>10;contador++){
            GenerarObstaculo();
            yield return new WaitForSeconds(0.5f);
        }
    }

}
