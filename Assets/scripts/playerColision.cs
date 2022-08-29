using UnityEngine;

public class playerColision : MonoBehaviour
{
    public playerScr objectWithScript;
    public Datos datos;
    void OnTriggerEnter(Collider collisionInfo)
    {
        if (collisionInfo.tag == "obstaculo")
        {
            datos.game_over = true;
            Debug.Log("~~~ Game Over ~~~");
        }
    }

}
