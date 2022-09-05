using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreadorDeNubes : MonoBehaviour
{
    public GameObject nubesPrefab;
    public Datos datos;
    int crear_cada = 250;
    int cuenta_creacion = 0;
    List<GameObject> nubecitas = new List<GameObject>();
    GameObject nube_a_remover;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!datos.game_over)
        {
            cuenta_creacion += 1;
            if (cuenta_creacion > crear_cada)
            {
                GameObject nueva_nube = Instantiate(nubesPrefab, new Vector3(35f, Random.Range(3.65f, 18f), 5f), Quaternion.identity);
                nubecitas.Add(nueva_nube);
                // Debug.Log(nubecitas.Count);

                cuenta_creacion = 0;
                crear_cada = Random.Range(250, 600);
            }
            if (nubecitas.Count >= 1)
            {
                foreach(GameObject obj_nube in nubecitas)
                {
                    var vec = new Vector3(-2.5f,0,0);
                    obj_nube.transform.Translate(vec * Time.deltaTime, Space.World);
                    if (obj_nube.transform.position.x < -17.5f)
                    {
                        // obj_nube.Destruir_nube();
                        // int index = nubecitas.IndexOf(obj_nube);
                        
                        nube_a_remover = obj_nube;
                        // obj_nube.GetComponent<Nube>().Destruir_nube();
                        // int index = nubecitas.IndexOf(obj_nube);
                        // Debug.Log(index);
                        // nubecitas.RemoveAt(index);
                    }
                }
                if (nube_a_remover)
                {
                    nubecitas.Remove(nube_a_remover);
                    nube_a_remover.GetComponent<Nube>().Destruir_nube();
                    nube_a_remover = null;
                    
                }
                
            }
        }
    }
}
