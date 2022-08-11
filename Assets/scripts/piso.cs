using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso : MonoBehaviour
{

    [SerializeField] private List<GameObject> objetos;
    GameObject piso01;
    GameObject piso02;
    void Start()
    {
        piso01 = GameObject.Find("piso01");
        piso02 = GameObject.Find("piso02");

        objetos.Add(piso01);
        objetos.Add(piso02);
        // Debug.Log(objetos);

    }

    // Update is called once per frame
    void Update()
    {
        // if (gameObject.transform.position.x <= -40f){
        //     transform.position = new Vector3((gameObject.transform.position.x+otroPiso.position.x)+80f-0.03f,0,0);
        // }
        // else{
        //     transform.position = new Vector3 (gameObject.transform.position.x-0.1f, gameObject.transform.position.y,gameObject.transform.position.z);
        //  }
        foreach(GameObject obj in objetos)
        {

            if (obj.transform.position.x <= -40){
                // obj.transform.position = new Vector3(40f,0,0);
                if (obj.name == "piso01"){
                    obj.transform.position = new Vector3(piso02.transform.position.x+40f ,0,0);
                }
                else{
                    obj.transform.position = new Vector3(piso01.transform.position.x+40f ,0,0);
                }
            }
            var vec = new Vector3(-12.5f,0,0);
            obj.transform.Translate(vec * Time.deltaTime, Space.World);

            // obj.transform.position = new Vector3(obj.transform.position.x-12f*Time.deltaTime,0,0);

            // Debug.Log(obj.transform.position.x);
        }

    }
}
