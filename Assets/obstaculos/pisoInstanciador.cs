using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoInstanciador : MonoBehaviour
{
    public miSO miSOScript;
    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(miSOScript.listaObstaculos[0][0]);
        GameObject miPrefab = miSOScript.listaObstaculos[0][0];
        Vector3 nuevaPosicion = new Vector3(this.transform.position.x, this.transform.position.y + 1.7f,this.transform.position.z);
        GameObject miObstaculo = Instantiate(miPrefab, nuevaPosicion, Quaternion.Euler(0,12.108f,0));
        miObstaculo.transform.SetParent(gameObject.transform);


    }
    public void funcionDePrueba(){
        Debug.Log("funcionDePrueba " + Random.Range(-10.0f, 10.0f));
    }
    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
