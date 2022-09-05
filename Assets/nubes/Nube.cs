using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nube : MonoBehaviour
{
    public void Destruir_nube()
    {
        Debug.Log("Destroy Nube.");
        Destroy(gameObject); 
    }
}
