using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "miSoObstaculos", menuName = "ScriptableObjects/miSO", order = 1)]
public class miSO : ScriptableObject
{

	// List<List<GameObject>> miListaTest = new List<List<GameObject>>();
	// List<GameObject> otraLista = new List<GameObject>();
	// miListaTest.Add(otraLista);

	public List<List<GameObject>> listaObstaculos = new List<List<GameObject>>();
	private List<GameObject> obsChicos = new List<GameObject>();
	private List<GameObject> obsGrandes = new List<GameObject>();
    public void OnEnable()
    {
		if (listaObstaculos.Count != 0)
		{
			Debug.Log("La lista ya está cargada");
			return;
		}
		var testTest = Resources.LoadAll<GameObject>("Targets/grandes");
		for (int i = 0; i < testTest.Length; i++) 
		{
			obsGrandes.Add(testTest[i]);
		}
		listaObstaculos.Add(obsGrandes);
		
		// listaObstaculos.Add(obsChicos);
        Debug.Log(testTest.Length);
    }
  //   public void OnEnable()
  //   {
		// // if (listaObstaculos.Count != 0)
		// // {
		// // 	Debug.Log("La lista ya está cargada");
		// // 	return;
		// // }
		// private List<GameObject> obsChicos = new List<GameObject>();
		// private List<GameObject> obsGrandes = new List<GameObject>(Resources.LoadAll<GameObject>("Targets/grandes"));
		// // listaObstaculos.Add(obsChicos);
		// // listaObstaculos.Add(obsGrandes);
		// // Debug.Log(listaObstaculos.Count);
  // //       Debug.Log("OnEnable");
  //   }

	// public void agregarListas()
	// {
	// 	if (listaObstaculos.Count != 0)
	// 	{
	// 		Debug.Log("La lista ya está cargada");
	// 		return;
	// 	}
	// 	listaObstaculos.Add(obsChicos);
	// 	listaObstaculos.Add(obsGrandes);
	// 	Debug.Log(listaObstaculos.Count);
	// }
	

}
