using UnityEngine;

public class playerColisionScr : MonoBehaviour
{
    public playerScr objectWithScript;
    public Datos datos;
    
    public bool isGrounded = true;
    Animator animator;
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "obstaculo")
        {
            datos.game_over = true;
            if (collisionInfo.transform.parent.GetChild(0).GetComponent<Animator>()) // Detiene la animación de las aves en game over.
            {
                animator = collisionInfo.transform.parent.GetChild(0).GetComponent<Animator>();
                animator.enabled = false;
            }
            Debug.Log("~~~ Game Over ~~~");            
        }
    }
}
