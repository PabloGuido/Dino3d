using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoInstanciador : MonoBehaviour
{
    public miSO miSOScript;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(miSOScript.listaObstaculos[0][0]);
        // miSOScript.agregarListas();
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
