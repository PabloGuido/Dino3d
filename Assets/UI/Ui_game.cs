using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using TMPro;

public class Ui_game : MonoBehaviour
{
    GameObject score;
    TMP_Text score_t;
    string ceros = "00000";
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("score");
        score_t = score.GetComponent<TMP_Text>();      
    }
    
    public void update_score(string cantidad)
    {
        score_t.text = ceros.Remove(0, cantidad.Length) + cantidad;        
    }

}
