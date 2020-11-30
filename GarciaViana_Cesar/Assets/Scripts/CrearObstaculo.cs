using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CrearObstaculo : MonoBehaviour
{   
    [SerializeField] Text Tiempo;
    [SerializeField] Text ContadorColumnas;
    public int contador;
    private float tiempo =0;
    private float segundos =0;
    
    [SerializeField] GameObject Obstaculo;

    // Start is called before the first frame update
    void Start()
    {
       StartCoroutine("ObstaculoCoroutine");
    }

    // Update is called once per frame
    void Update()
    {        
        TextoUI();
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

    void TextoUI()
    {
        tiempo += Time.deltaTime;
        segundos = tiempo % 60;
        ContadorColumnas.text = "Nº de columnas: " + contador; 
        Tiempo.text = "Tiempo jugado: " + segundos.ToString("f1") + " segs";
    }

}
