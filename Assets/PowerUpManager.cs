using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public static PowerUpManager instance;
    public CanonController player;

    private void Awake()
    {
        instance = this;
    }
    
    public void SpeedDouble()
    {
        player.speedCanon *= 2;
    }
}
