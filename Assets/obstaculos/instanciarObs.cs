using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instanciarObs : MonoBehaviour
{
    public GameObject obstaculoPF;
    // Start is called before the first frame update
    void Start()
    {
        GameObject test = Instantiate(obstaculoPF, new Vector3(0, 1.5f, 0), Quaternion.identity);
        test.transform.SetParent(gameObject.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
