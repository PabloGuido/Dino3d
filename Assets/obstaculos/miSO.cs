using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "miSoObstaculos", menuName = "ScriptableObjects/miSO", order = 1)]
public class miSO : ScriptableObject
{


	public List<List<GameObject>> listaObstaculos = new List<List<GameObject>>();
	private List<GameObject> obsChicos = new List<GameObject>();
	private List<GameObject> obsGrandes = new List<GameObject>();
    public void OnEnable()
    {
		// if (listaObstaculos.Count != 0) 
		// {
		// 	Debug.Log("La lista ya está cargada");
		// 	return;
		// }
		var testTest = Resources.LoadAll<GameObject>("Targets/grandes");
		for (int i = 0; i < testTest.Length; i++) 
		{
			obsGrandes.Add(testTest[i]);
		}
		listaObstaculos.Add(obsGrandes);
		
		// listaObstaculos.Add(obsChicos);
        Debug.Log("++ " + testTest.Length + " ++");
    }

}
