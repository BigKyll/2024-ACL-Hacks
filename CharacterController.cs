using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb;
    [SerializeField] Transform respawn;
    [SerializeField] LayerMask obstacles;
    [SerializeField] Transform hitbox;
    [SerializeField] VanishManager vanish;

    // Update is called once per frame
    void Update()
    {
        if(touchingObstacle() || rb.position.y < -5f) { // dying
            Die();
        }
    }

    void FixedUpdate() {

    }

    private bool touchingObstacle() { // Returns whether or not the hitbox is touching an obstacle
        return Physics2D.OverlapArea(new Vector2(hitbox.position.x - 0.5f, hitbox.position.y - 0.75f), new Vector2(hitbox.position.x + 0.75f, hitbox.position.y + 0.8f), obstacles);
    }

    public void Die() {
        rb.position = respawn.position;
        vanish.resetVanish();
    }
}
