using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piso : MonoBehaviour
{

    [SerializeField] private List<GameObject> objetos;
    public miSO miSOScript;

    GameObject piso01;
    GameObject piso02;
    float velocidad_inicial = -15f;
    float velocidad;
    // Score
    public Datos datos;
    public Ui_game ui_game;
    int cuenta_score = 0;
    int cuenta_blink = 0;

    void OnEnable()
    {
        playerScr.Restart_Game += restart_score;
    }
    void OnDisable()
    {
        playerScr.Restart_Game -= restart_score;
    }
    void Start()
    {
        velocidad = velocidad_inicial;
        miSOScript = (miSO)ScriptableObject.CreateInstance(typeof(miSO));
        piso01 = GameObject.Find("piso01");
        piso02 = GameObject.Find("piso02");

        objetos.Add(piso01);
        objetos.Add(piso02);
        // Debug.Log(miSOScript.score);

    }

    // Update is called once per frame
    void Update()
    {
        if (!datos.game_over)
        {
            foreach(GameObject obj in objetos)
            {

                if (obj.transform.position.x <= -40){
                    // obj.transform.position = new Vector3(40f,0,0);
                    if (obj.name == "piso01"){
                        obj.transform.position = new Vector3(piso02.transform.position.x+40f ,-0.4f,0);
                        obj.GetComponent<pisoInstanciador>().refrescarObstaculo();
                        // test.funcionDePrueba();
                        return;
                    }
                    else{
                        obj.transform.position = new Vector3(piso01.transform.position.x+40f ,-0.4f,0);
                        // obj.funcionDePrueba();
                        obj.GetComponent<pisoInstanciador>().refrescarObstaculo();
                        return;
                    }
                }
                var vec = new Vector3(velocidad,0,0);
                obj.transform.Translate(vec * Time.deltaTime, Space.World);
                // Antes estaba usando solo el transform y moviendo pero se cambió a Translate. 
            }
            sumar_score();
        }
    }

    void sumar_score()
    {
        cuenta_score += 1;
        if (cuenta_score >= 15)
        {
            datos.score += 1;
            cuenta_blink +=1;
            if (datos.score >= 99999)
            {
                datos.score = 0;
            }
            cuenta_score = 0;
            int score_nueva_var = datos.score;
            ui_game.update_score(score_nueva_var.ToString());
            if (cuenta_blink >= 100)
            {
                ui_game.invocar_blink();
                cuenta_blink = 0;
                if (velocidad >= -25f)
                {
                    velocidad += -1.5f;
                    Debug.Log(velocidad);
                }
                
            }
        }
    }
    void restart_score()
    {
        velocidad = velocidad_inicial;
        datos.score = 0;
        cuenta_blink = 0;
        cuenta_score = 0;
    }


}
