using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using UnityEngine.UI;
using TMPro;

public class Ui_game : MonoBehaviour
{
    TMP_Text score;
    TMP_Text hi_score;
    TMP_Text start;
    TMP_Text game_over;
    string ceros = "00000";
    void OnEnable()
    {
        playerScr.Restart_Game += restart_game;
    }
    void OnDisable()
    {
        playerScr.Restart_Game -= restart_game;
    }
    // Start is called before the first frame update
    void Start()
    {
        score = GameObject.Find("score").GetComponent<TMP_Text>();     
        hi_score = GameObject.Find("hi_score").GetComponent<TMP_Text>();  
        start = GameObject.Find("start").GetComponent<TMP_Text>();
        game_over = GameObject.Find("game_over").GetComponent<TMP_Text>();
        game_over.enabled = false;
    }
    
    public void update_score(string cantidad)
    {
        score.text = ceros.Remove(0, cantidad.Length) + cantidad;        
    }

    public void update_hi_score()
    {
        hi_score.text = "HI " + score.text;
    }

    public void remover_start()
    {
        start.enabled = false;
    }
    
    public void game_over_text()
    {
        game_over.enabled = true;
    }

    public void restart_game()
    {
        game_over.enabled = false;
    }
}
