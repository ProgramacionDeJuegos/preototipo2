using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectaColision : MonoBehaviour
{

    void OnTriggerEnter(Collider food)
    {
        Destroy(gameObject);
        Destroy(food.gameObject);
    }

}
