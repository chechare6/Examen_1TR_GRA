using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovCamara : MonoBehaviour
{
    [SerializeField] Transform spherePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(spherePos.position.x, spherePos.position.y +6, spherePos.position.z -3);
    }
}
