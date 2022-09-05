using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeNubes : MonoBehaviour
{
    public GameObject nubesPrefab;
    int cuenta_creacion = 0;
    List<GameObject> nubecitas = new List<GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        cuenta_creacion += 1;
        if (cuenta_creacion > 100)
        {
            GameObject nueva_nube = Instantiate(nubesPrefab, new Vector3(10f, Random.Range(6.4f, 10.5f), -3.22f), Quaternion.identity);
            cuenta_creacion = -500;
            nubecitas.Add(nueva_nube);
            Debug.Log(nubecitas.Count);
        }
    }
}
