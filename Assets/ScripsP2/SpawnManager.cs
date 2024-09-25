using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] animales = new GameObject[3];


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnAnimales", 2F, 2F);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnAnimales()
    {
        int indice = Random.Range(0, animales.Length);
            int rango = Random.Range(-195, 195);
            Vector3 pos = new Vector3(rango, 0, 160);
            Instantiate(animales[indice], pos,
                animales[indice].transform.rotation);
    }
}
