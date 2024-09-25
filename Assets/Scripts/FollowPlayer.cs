using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public float velocidad = 20;
    public float inputForward;
    public float inputGiro;

    void Start()
    {
        
    }


    void Update()
    {
        inputForward = Input.GetAxis("Vertical");
        inputGiro = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*inputForward);
        transform.Rotate(Vector3.up, Time.deltaTime*velocidad*inputGiro);
    }
}
