using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/miSO", order = 1)]
public class miSO : ScriptableObject
{
	public List<List<GameObject>> miListaTest = new List<List<GameObject>>();
	public string hola;
}
