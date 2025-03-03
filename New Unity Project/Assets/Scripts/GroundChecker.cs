﻿/* Made by Ushiris */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    PlayerController player;
    float timer = 0f;
    bool flag = false;
    bool hitG = false;
    
    void Start()
    {
        player = GetComponentInParent<PlayerController>();
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag=="Plane")
        {
            player.Ground(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Plane")
        {
            player.Ground(false);
        }
    }
}
