using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piso : MonoBehaviour
{
    Mesh m_Collider;
    Vector3 m_Max;
    void Start()
    {
        m_Collider = GetComponent<MeshFilter>().mesh;
        m_Max = m_Collider.bounds.size;

        Debug.Log(m_Max);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3 (gameObject.transform.position.x-0.055f, gameObject.transform.position.y,gameObject.transform.position.z);
        if (gameObject.transform.position.x <= -50f){
            transform.position = new Vector3(50f, 0, 0);
        }
    }
}
