using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{
    public float timer = 10;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        timerText.text = timer.ToString();
        StartCoroutine(CountTime());
    }
   
    IEnumerator CountTime()
    {
        while(timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
            timerText.text = timer.ToString();
        }
        // aqui termina el timer
        yield break;
    }
}
