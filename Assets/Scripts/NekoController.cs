using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NekoController : MonoBehaviour
{
    public float MoveSpeed, JumpForce;
    public bool Jumping;
    public Rigidbody2D RG2D;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        RG2D = GetComponent<Rigidbody2D>();

        //Jumping = true;
    }

    // Update is called once per frame
    void Update()
    {
        

        float MovX = Input.GetAxisRaw("Horizontal");
        float MovY = Input.GetAxisRaw("Vertical");
        animator.SetFloat("Speed 0", Mathf.Abs(MovX));
        // Horizontal Movement

        if(MovX != 0){
            RG2D.velocity = new Vector2(MoveSpeed * MovX, RG2D.velocity.y);
        }

        //Jumping
        
        if(MovY == 1 && !Jumping){
            RG2D.velocity = new Vector2(RG2D.velocity.x, JumpForce);
            Jumping = true;
        }
    }
    void OnCollisionEnter2D(Collision2D col) {
            Jumping = false;
        }  
}
