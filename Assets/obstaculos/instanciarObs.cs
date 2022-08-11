using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarObs : MonoBehaviour
{
    public GameObject obstaculoPF;
    List<List<GameObject>> miListaTest = new List<List<GameObject>>();
    // Start is called before the first frame update
    void Start()
    {
        GameObject test = Instantiate(obstaculoPF, new Vector3(0, 1.5f, 0), Quaternion.identity);
        test.transform.SetParent(gameObject.transform);
        // ------------
        
        List<GameObject> otraLista = new List<GameObject>();
        miListaTest.Add(otraLista);
        otraLista.Add(test);
        Debug.Log(miListaTest[0][0].name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
