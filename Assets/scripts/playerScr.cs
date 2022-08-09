using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScr : MonoBehaviour
{
    // [HideInInspector][SerializeField] public float numero;
    public CharacterController cc;
    public float buttonTime = 0.3f;
    float jumpTime;
    public float gravity;
    public float gravityScale;
    public float jumpHeight;
    float velocity;
    // Start is called before the first frame update
    void Start()
    {
        gravity = -20f;
        gravityScale = 4;
        jumpHeight = 4;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space)) 
        {
            jumpTime += Time.deltaTime;
            Debug.Log("asd");
        }
        if (jumpTime > buttonTime)
        {
            jumpHeight = 4;
            if (cc.isGrounded && Input.GetKeyDown(KeyCode.Space) || cc.isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
            {
            gravity = -20f;
            velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
                    jumpTime = 0;
            }
        }
        // else{
        //     jumpHeight = 2;
        //     if (cc.isGrounded && Input.GetKeyDown(KeyCode.Space) || cc.isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        //     {
        //     gravity = -20f;
        //     velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
        //             jumpTime = 0;
        //     }
        // }

        if (!cc.isGrounded && Input.GetKeyDown(KeyCode.DownArrow))
        {
            gravity = -120f;
            velocity = Mathf.Sqrt(-0f * (gravity * gravityScale));
        }
        velocity += gravity * gravityScale * Time.deltaTime;
        MovePlayer();  
    }
    void MovePlayer()
    {
        cc.Move(new Vector3(0, velocity, 0) * Time.deltaTime);

    }
}
