using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    float velocidad = 60;
   

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.z > 280) {
            Destroy(gameObject);
        }
        else if (transform.position.z < -100) 
        {
            Destroy(gameObject);
        }


        transform.Translate(Vector3.forward * Time.deltaTime * velocidad);
    }
}