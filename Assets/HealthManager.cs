using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    public static HealthManager instance;

    public int health = 10;

    private void Awake()
    {
        instance = this;
    }
    
}
