using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoInstanciador : MonoBehaviour
{
    public miSO miSOScript;
    private Vector3 miPos;
    string nombreDeMiObstaculo;
    // Start is called before the first frame update
    void Start()
    {
        crear_obstaculo();
        // Debug.Log(nombreDeMiObstaculo);

    }

    void crear_obstaculo()
    {
        // Debug.Log(miSOScript.listaObstaculos[0][0]);
        GameObject miPrefab = miSOScript.listaObstaculos[0][0];
        Vector3 miPos = new Vector3(this.transform.position.x, this.transform.position.y + 1.7f,this.transform.position.z);
        GameObject miObstaculo = Instantiate(miPrefab, miPos, Quaternion.Euler(0,12.108f,0));
        nombreDeMiObstaculo = miObstaculo.name;
        miObstaculo.transform.SetParent(gameObject.transform);
    }
    public void refrescarObstaculo()
    {
        // ↓↓ Busca el obstáculo child por medio de su nombre y si existe lo elimina.
        Transform mi_obstaculo_child = gameObject.transform.Find(nombreDeMiObstaculo);
        if (mi_obstaculo_child)
        {
            mi_obstaculo_child.GetComponent<obstaculo>().destruir_obstaculo();
            crear_obstaculo();
        }
    }

}
// Debug.Log("funcionDePrueba " + Random.Range(-10.0f, 10.0f));