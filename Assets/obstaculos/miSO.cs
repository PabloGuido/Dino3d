using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "miSoObstaculos", menuName = "ScriptableObjects/miSO", order = 1)]
public class miSO : ScriptableObject
{


	public List<List<GameObject>> listaObstaculos = new List<List<GameObject>>();
	private List<GameObject> obsChicos = new List<GameObject>();
	private List<GameObject> obsGrandes = new List<GameObject>();

    public void Awake()
    {
    	if (listaObstaculos.Count == 0)
    	{
			var carga_obs_grandes = Resources.LoadAll<GameObject>("Targets/grandes");
			for (int i = 0; i < carga_obs_grandes.Length; i++) 
			{
				obsGrandes.Add(carga_obs_grandes[i]);
			}
			listaObstaculos.Add(obsGrandes);

			var carga_obs_chicos = Resources.LoadAll<GameObject>("Targets/chicos");
			for (int i = 0; i < carga_obs_chicos.Length; i++) 
			{
				obsChicos.Add(carga_obs_chicos[i]);
			}
			listaObstaculos.Add(obsChicos);
			

	        Debug.Log("++ " + carga_obs_chicos.Length + " ++");
	    }
    }
}
