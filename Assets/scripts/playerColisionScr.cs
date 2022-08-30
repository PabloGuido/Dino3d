using UnityEngine;

public class playerColisionScr : MonoBehaviour
{
    public playerScr objectWithScript;
    public Datos datos;
    
    public bool isGrounded = true;
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "obstaculo")
        {
            datos.game_over = true;
            Debug.Log("~~~ Game Over ~~~");
        }
        if (collisionInfo.tag == "piso")
        {
            isGrounded = true;
            Debug.Log("~~~ Piso in ~~~");
        }
    }
    void OnTriggerExit(Collider collisionInfo)
    {
        if (collisionInfo.tag == "piso")
        {
            isGrounded = false;
            Debug.Log("~~~ Piso out~~~");
        }
    }

}
