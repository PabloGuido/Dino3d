using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "miSoObstaculos", menuName = "ScriptableObjects/miSO", order = 1)]
public class miSO : ScriptableObject
{
	public List<List<GameObject>> listaObstaculos = new List<List<GameObject>>(); // Lista de lista de obstáctulos para varian entre grandes y chicos.
	private List<GameObject> obsChicos = new List<GameObject>(); // Lista de los obstáculos chicos.
	private List<GameObject> obsGrandes = new List<GameObject>(); // Lista de los obstáculos grandes.

    public void Awake()
    {
    	if (listaObstaculos.Count == 0) // Si la lista de obstáculos está vacía cargar los recursos.
    	{
    		// Carga los recursos que están en el editor y los agrega a su respectiva tabla de chico ó grande y luego a la lista de listas.
    		// ↓ Obs grandes.
			var carga_obs_grandes = Resources.LoadAll<GameObject>("Targets/grandes");
			for (int i = 0; i < carga_obs_grandes.Length; i++) 
			{
				obsGrandes.Add(carga_obs_grandes[i]);
			}
			listaObstaculos.Add(obsGrandes);

			// ↓ Obs chicos.
			var carga_obs_chicos = Resources.LoadAll<GameObject>("Targets/chicos");
			for (int i = 0; i < carga_obs_chicos.Length; i++) 
			{
				obsChicos.Add(carga_obs_chicos[i]);
			}
			listaObstaculos.Add(obsChicos);
			
	        // Debug.Log("++ " + carga_obs_chicos.Length + " ++");
	    }
    }
}
