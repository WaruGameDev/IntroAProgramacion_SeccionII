using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public TextMeshProUGUI puntajeText;
    public int puntaje;
    [Header("Time mechanics")]
    [Tooltip("Este es el valor del tiempo de duración del juego")] public float timer = 10;
    public TextMeshProUGUI timerText;
    public TextMeshProUGUI textoFeedback;
    public CanvasGroup panelFeedback;


    private void Awake()
    {
        instance = this;        
    }
    private void Start()
    {
        StartCoroutine(CountDown());
        panelFeedback.interactable = false;
        panelFeedback.blocksRaycasts = false;
    }
    private void Update()
    {
        puntajeText.text = puntaje.ToString();
        timerText.text = ""+ (int)timer;
        //if(timer > 0)
        //{
        //    timer -= 1 * Time.deltaTime;
        //}
    }
    public void ResetLevel()
    {
        SceneManager.LoadScene(0);
    }
    public void ShowFeedback(string result)
    {
        //atento
        textoFeedback.text = result;
        panelFeedback.DOFade(1,0.5f);
        panelFeedback.interactable = true;
        panelFeedback.blocksRaycasts = true;
    }

    IEnumerator CountDown()
    {
        while(timer > 0)
        {
            yield return new WaitForSeconds(1);
            timer--;
        }
        // termina el contador
        if(puntaje > 10)
        {
            ShowFeedback("Ganaste! yay");
        }
        else
        {
            ShowFeedback("Perdiste :c");
        }
        
        yield break;
    }

}
