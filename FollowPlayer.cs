using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    private double offset = 0f;
    
    [SerializeField] Transform camera;
    [SerializeField] Transform player;
    
    // Update is called once per frame
    void Update()
    {
        camera.position = new Vector3(player.position.x + 3, player.position.y + 2, -15);
    }
}
