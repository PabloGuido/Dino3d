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
    private bool primer_salto = true;


    // Transform dino2dChild;
    Animator animator;
    SpriteRenderer sprite_idle;
    Sprite mi_sprite_idle;

    // 
    public Datos datos;
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
        if(!datos.game_over)
        {
            if (cc.isGrounded && Input.GetKeyDown(KeyCode.Space) || cc.isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
            {
                salto_player();
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
            return;
        }

        if (Input.GetKeyDown(KeyCode.Space) && primer_salto == true || Input.GetKeyDown(KeyCode.UpArrow) && primer_salto == true)
        {
            // Debug.Log("Primer salto.");
            primer_salto = false;
            salto_player();
            Invoke("comenzar_el_juego", 0.5f);

        }  
        if (datos.primer_salto == true)
        {
            velocity += gravity * gravityScale * Time.deltaTime;
            MovePlayer();
        }
        animator.enabled = false; // cancela la animación cuando el player perdió.
    }
    
    void MovePlayer()
    {
        cc.Move(new Vector3(0, velocity, 0) * Time.deltaTime);

    }
    void salto_player()
    {
        gravity = -20f;
        velocity = Mathf.Sqrt(jumpHeight * -2f * (gravity * gravityScale));
        animator.enabled = false;
        sprite_idle.sprite = mi_sprite_idle;
    }

    void comenzar_el_juego()
    {

        datos.game_over = false;
        datos.primer_salto = false;
        
    }
}
