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
    public void DoubleCanon()
    {        
        StartCoroutine(DoubleCanonTime());
    }
    IEnumerator DoubleCanonTime()
    {
        player.doubleCanon = true;
        yield return new WaitForSeconds(5);
        player.doubleCanon = false;
        yield break;
    }
}
