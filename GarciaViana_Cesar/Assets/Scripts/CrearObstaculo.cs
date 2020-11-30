using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrearObstaculo : MonoBehaviour
{
    [SerializeField] GameObject Obstaculo;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("ObstaculoCoroutine");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        {
            GenerarObstaculo();
        }
    }

   void GenerarObstaculo(){
       float randomX = Random.Range(-9.5f,9.5f);
       float randomZ = Random.Range(-9.5f,9.5f);

       Vector3 RndmPos = new Vector3(randomX,0,randomZ);
       Instantiate(Obstaculo, RndmPos, Quaternion.identity);

    }

    IEnumerator ObstaculoCoroutine()
    {
        for(int n=0; ; n++){
            
            GenerarObstaculo();
            yield return new WaitForSeconds(1);
        }
    }
}
