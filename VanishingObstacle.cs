using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.Tilemaps;

public class VanishingObstacle : MonoBehaviour
{
    [SerializeField] VanishManager vm;
    [SerializeField] Tilemap tm;
    
    // Update is called once per frame
    void Update()
    {
        tm.color = new Color(255, 255, 255, vm.getOpacity());
    }
}
