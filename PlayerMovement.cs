using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpPower = 15f;
    private bool facingRight = true;

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private VanishManager vm;
    [SerializeField] private Animator am;
    [SerializeField] private Transform player;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && GroundCheck()) {
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }
    
        horizontal = Input.GetAxisRaw("Horizontal");

        am.SetBool("Vanished", vm.isVanished());
        am.SetFloat("Speed", Mathf.Abs(rb.velocity.x));

        if (horizontal > 0 && !facingRight) {
				// ... flip the player.
				Flip();
			}
			// Otherwise if the input is moving the player left and the player is facing right...
			else if (horizontal < 0 && facingRight) {
				// ... flip the player.
				Flip();
			}
    }

    private bool GroundCheck() {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }

    void FixedUpdate() {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }

    private void Flip()
	{

		facingRight = !facingRight;

		Vector3 theScale = player.localScale;
		theScale.x *= -1;
		player.localScale = theScale;
	}
}
