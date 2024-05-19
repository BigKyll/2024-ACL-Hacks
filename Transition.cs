using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transition : MonoBehaviour
{

    [SerializeField] LayerMask transition;
    [SerializeField] SceneManage sm;
     [SerializeField] Transform hitbox;
     public int sceneNum;

    // Update is called once per frame
    void Update()
    {
        if(touchingTrigger()) {
            sm.openScene(sceneNum + 1);
        }
    }

    private bool touchingTrigger() {
        return Physics2D.OverlapArea(new Vector2(hitbox.position.x - 0.5f, hitbox.position.y - 0.5f), new Vector2(hitbox.position.x + 0.5f, hitbox.position.y + 0.5f), transition);
    }
}
