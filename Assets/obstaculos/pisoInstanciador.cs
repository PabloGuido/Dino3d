using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pisoInstanciador : MonoBehaviour
{
    // public miSO miSOScript;
    GameObject pisoHolder; // Es el objeto que tiene el script con las tablas de obstaculos.
    Piso pisoScript; // Es el script del objeto pisoHolder.
    private Vector3 miPos; // Mi posicion para pasar al child.
    string nombreDeMiObstaculo; // Nombre del obstáculo child para buscarlo y eliminarlo cuando haga falta.
    Transform mi_obstaculo_child; // Nombre para referenciar al obstaculo child y acceder a su script para ejecutar Destroy();.
    private bool hay_un_obstaculo = false; // Variable que sirve para crear el primer obstáculo.
    List<float> offset_obstaculos = new List<float>{1f,1f}; // Este offset es para poner los obstáculos chicos o grandes sobre el piso.
    // Los primers son los grandes los segundos los chicos.

    // Start is called before the first frame update
    void Start()
    {
        // ↓ Busca el pisoHolder y su script para accedar a las tablas de obstáculos.
        pisoHolder = GameObject.Find("pisoHolder");        
        pisoScript = pisoHolder.GetComponent<Piso>();
        // 
        var r = GetComponent<Renderer>();
        var bounds = r.localBounds;
        // Debug.Log(bounds.extents.y);
    }

    void crear_obstaculo()
    {
        int random_chico_grande = Random.Range(0, 2); //--<0> 
        GameObject miPrefab = pisoScript.miSOScript.listaObstaculos[random_chico_grande][Random.Range(0, 3)]; //--<1> 
        Vector3 miPos = new Vector3(this.transform.position.x, this.transform.position.y + offset_obstaculos[random_chico_grande],this.transform.position.z); //--<2>    
        GameObject miObstaculo = Instantiate(miPrefab, miPos, Quaternion.identity); //--<3>       
        nombreDeMiObstaculo = miObstaculo.name; //--<4>         
        miObstaculo.transform.SetParent(gameObject.transform); //--<5>         
        miObstaculo.transform.GetChild(0).GetComponent<SpriteRenderer>().transform.eulerAngles = new Vector3(0,12.108f,0); //--<6>  

        //<0> ↓ Genera número random para crear obstáculos chicos o grandes.
        //<1> ↓ Buscar un prefab random de la lista para crear.
        //<2> ↓ Actualiza la pos para pasarsela a la instancia.
        //<3> ↓ Se crea la instancia.
        //<4> ↓ Se guarda el nombre la instancia creada.
        //<5> ↓ Se le asigna parent a la instancia.
        //<6> ↓ Se modifica la rotación del sprite de la instancia para que mire directo a la cámara.

    }
    public void refrescarObstaculo()
    {       
        // ↓ Esta comparación es para crear el primer obstáculo.
        if (!hay_un_obstaculo)
        {
            crear_obstaculo();
            hay_un_obstaculo = true;
            return;
        }

        // ↓ Busca el obstáculo child por medio de su nombre y lo elimina.
        mi_obstaculo_child = gameObject.transform.Find(nombreDeMiObstaculo);
        mi_obstaculo_child.GetComponent<obstaculo>().destruir_obstaculo();

        // ↓ Crea un obstáculo nuevo.
        crear_obstaculo();
        
    }
}
