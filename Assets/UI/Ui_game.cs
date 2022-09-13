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
    int cuenta_blink = 0;
    bool blink = false;
    public Datos datos;
    AudioSource audioData;

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
        audioData = GetComponent<AudioSource>();
        
    }
    
    public void update_score(string cantidad)
    {
        if (!blink)
        {
            score.text = ceros.Remove(0, cantidad.Length) + cantidad;
        }
        
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
        CancelInvoke("blink_score");
        score.enabled = true;
        blink = false;
        string score_nueva_var = datos.score.ToString();
        score.text = ceros.Remove(0, score_nueva_var.Length) + score_nueva_var;
        if (datos.score >= datos.hi_score)
        {
            datos.hi_score = datos.score;
            update_hi_score();    
        }    
    }

    public void restart_game()
    {
        game_over.enabled = false;
    }
    public void invocar_blink()
    {
        audioData.Play();
        InvokeRepeating("blink_score", 0 , 0.5f);
    }
    public void blink_score()
    {
        blink = true;
        cuenta_blink += 1;
        if (cuenta_blink >= 6)
        {
           CancelInvoke("blink_score");
           score.enabled = true;
           cuenta_blink = 0;
           blink = false;
           return;
        }
        if (score.enabled)
        {
            score.enabled = false;
        }
        else
        {
            score.enabled = true;
        }
        
    }
}
