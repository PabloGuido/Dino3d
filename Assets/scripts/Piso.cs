using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{

    [SerializeField] private List<GameObject> objetos;
    public miSO miSOScript;

    GameObject piso01;
    GameObject piso02;
    float velocidad = -12.5f;
    public Datos datos;
    void Start()
    {
        miSOScript = (miSO)ScriptableObject.CreateInstance(typeof(miSO));
        piso01 = GameObject.Find("piso01");
        piso02 = GameObject.Find("piso02");

        objetos.Add(piso01);
        objetos.Add(piso02);


    }

    // Update is called once per frame
    void Update()
    {
        if (!datos.game_over)
        {
            foreach(GameObject obj in objetos)
            {

                if (obj.transform.position.x <= -40){
                    // obj.transform.position = new Vector3(40f,0,0);
                    if (obj.name == "piso01"){
                        obj.transform.position = new Vector3(piso02.transform.position.x+40f ,-0.4f,0);
                        obj.GetComponent<pisoInstanciador>().refrescarObstaculo();
                        // test.funcionDePrueba();
                        return;
                    }
                    else{
                        obj.transform.position = new Vector3(piso01.transform.position.x+40f ,-0.4f,0);
                        // obj.funcionDePrueba();
                        obj.GetComponent<pisoInstanciador>().refrescarObstaculo();
                        return;
                    }
                }
                var vec = new Vector3(velocidad,0,0);
                obj.transform.Translate(vec * Time.deltaTime, Space.World);
                // Antes estaba usando solo el transform y moviendo pero se cambió a Translate. 
            }
        }
    }
}
