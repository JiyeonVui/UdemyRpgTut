using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D theRB;
    private float moveSpeed = 3f;
    public Animator playerAnim; 
    void Start()
    {
        theRB = gameObject.GetComponent<Rigidbody2D>();
        playerAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        theRB.velocity = new Vector2(Input.GetAxisRaw("Horizontal"),
                                     Input.GetAxisRaw("Vertical"))*moveSpeed;

        playerAnim.SetFloat("moveX",theRB.velocity.x);
        playerAnim.SetFloat("moveY",theRB.velocity.y);

        if(Input.GetAxisRaw("Horizontal") == 1 || Input.GetAxisRaw("Horizontal") == -1
            || Input.GetAxisRaw("Vertical") == 1 || Input.GetAxisRaw("Vertical") == -1
        ){
            playerAnim.SetFloat("lastMoveX", Input.GetAxisRaw("Horizontal"));
            playerAnim.SetFloat("lastMoveY",Input.GetAxisRaw("Vertical"));
        }
    }
}
