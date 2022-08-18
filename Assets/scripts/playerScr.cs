using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScr : MonoBehaviour
{
    // [HideInInspector][SerializeField] public float numero;
    public CharacterController cc;

    public float gravity;
    public float gravityScale;
    public float jumpHeight;
    float velocity;

    // Transform dino2dChild;
    public Animator animator;
    public SpriteRenderer sprite_idle;
    public Sprite mi_sprite_idle;
    // Start is called before the first frame update
    void Start()
    {
        gravity = -20f;
        gravityScale = 4;
        jumpHeight = 4;
        // dino2dChild = this.gameObject.transform.GetChild(0);
        // Debug.Log(dino2dChild.name);
        animator = gameObject.transform.GetChild(0).GetComponent<Animator>();
        sprite_idle = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>();
        mi_sprite_idle = gameObject.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite;
        // Debug.Log(sprite_idle.sprite);
        
        // Debug.Log(anim);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cc.isGrounded && Input.GetKeyDown(KeyCode.Space) || cc.isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
            gravity = -20f;
            velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
            animator.enabled = false;
            sprite_idle.sprite = mi_sprite_idle;

        }
        if (!cc.isGrounded && Input.GetKeyDown(KeyCode.DownArrow))
        {
            gravity = -120f;
            velocity = Mathf.Sqrt(-0f * (gravity * gravityScale));
        }
        velocity += gravity * gravityScale * Time.deltaTime;
        MovePlayer();
        if (cc.isGrounded && !animator.enabled)
        {
            animator.enabled = true;
        }
    }
    
    void MovePlayer()
    {
        cc.Move(new Vector3(0, velocity, 0) * Time.deltaTime);

    }
}
