using UnityEngine;

public class playerColisionScr : MonoBehaviour
{
    public Datos datos;
    
    public bool isGrounded = true;
    Animator animator;
    public Ui_game ui_game;
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "piso")
        {
            isGrounded = true;
            // Debug.Log("piso detector");
        }
        if (collisionInfo.tag == "obstaculo")
        {
            datos.game_over = true;
            Invoke("cambiar_estado_de_restart", 1f);
            if (collisionInfo.transform.parent.GetChild(0).GetComponent<Animator>()) // Detiene la animación de las aves en game over.
            {
                animator = collisionInfo.transform.parent.GetChild(0).GetComponent<Animator>();
                animator.enabled = false;
            }
            gameObject.GetComponent<playerScr>().dino_over_sprite();
            if (datos.score >= datos.hi_score)
            {
                datos.hi_score = datos.score;
                ui_game.update_hi_score();    
            }    
            ui_game.game_over_text();
            Debug.Log("~~~ Game Over ~~~");
            
        }
    }
    void OnTriggerStay(Collider collisionInfo)
    {
        if (collisionInfo.tag == "piso")
        {
            isGrounded = true;
        }
    }
    void OnTriggerExit(Collider collisionInfo)
    {
        if (collisionInfo.tag == "piso")
        {
            isGrounded = false;
        }
    }

    void cambiar_estado_de_restart()
    {
        datos.restart_game = true;
    }
}
