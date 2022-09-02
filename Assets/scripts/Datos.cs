using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Datos : MonoBehaviour
{

    public bool game_over = true;
    public bool primer_salto = true;
    public bool restart_game = false;
    // Cuenta para crear aves
    public int random_ave;
    public int cuenta_ave;
    void OnEnable()
    {
        playerScr.Restart_Game += subscripccion;
        
    }
    void OnDisable()
    {
        playerScr.Restart_Game -= subscripccion;
    }
    void Start()
    {
        nuevo_random_ave();
    }
    public void nuevo_random_ave()
    {
        cuenta_ave = 0;
        random_ave = Random.Range(7, 12);
        // random_ave = Random.Range(0, 5);
    }
    void subscripccion()
    {
        restart_game = false;
        game_over = false;
        Debug.Log("Restaurando Datos.");
    }
}
