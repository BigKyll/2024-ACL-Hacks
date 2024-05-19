using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;

public class VanishManager : MonoBehaviour
{
    private bool vanished;
    private float opacity;
    public int numVanish;
    
    private float vanishTimer;
    public int maxVanish;
    public float vanishLimit; // how long things are vanished

    // Start is called before the first frame update
    void Start()
    {
        int vanishRemaining = numVanish;
        vanished = true;
        opacity = 0;
        numVanish = maxVanish;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space") && vanished && numVanish > 0) {
            vanished = !vanished;
            numVanish--;
        }
    }

    void FixedUpdate() {
        if(!vanished) {
            opacity = 255;
            vanishTimer += Time.deltaTime;
            if(vanishTimer > vanishLimit) {
                opacity = 0;
                vanished = true;
                vanishTimer = 0;
            }
        }
    }

    public Boolean isVanished() {
        return vanished;
    }

    public float getOpacity() {
        return opacity;
    }

    public void resetVanish() {
        numVanish = maxVanish;
        vanishTimer = 0;
        vanished = true;
        opacity = 0;
    }
}
