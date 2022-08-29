using UnityEngine;

public class playerColision : MonoBehaviour
{
    public playerScr objectWithScript;
    // void OnCollisionEnter(Collision collisionInfo)
    // {
    //     //Output the Collider's GameObject's name
    //     Debug.Log(collisionInfo.gameObject.tag);

    // }
    void FixedUpdate()
    {

    }

        void OnTriggerEnter(Collider collisionInfo)
        {
        Debug.Log(collisionInfo.gameObject.tag);
        }

}
