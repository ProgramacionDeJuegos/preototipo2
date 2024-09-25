using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    float inputHorizontal;
    float limitePlayer = 200;
    float velocidad = 100;
    public GameObject proyectilFood;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*60*inputHorizontal);

        if(transform.position.x > limitePlayer) {

            transform.position = new Vector3(limitePlayer, transform.position.y, transform.position.z);

        }else if(transform.position.x < -limitePlayer){

            transform.position = new Vector3(-limitePlayer, transform.position.y, transform.position.z);

        }

            if(Input.GetKeyDown(KeyCode.Space)){
                Debug.Log("Instatiate food");
            Instantiate(proyectilFood, gameObject.transform.position, proyectilFood.transform.rotation);
        }


        inputHorizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * Time.deltaTime * velocidad * inputHorizontal);
    }
}
