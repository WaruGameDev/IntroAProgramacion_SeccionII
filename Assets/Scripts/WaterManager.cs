using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WaterManager : MonoBehaviour
{
    public static WaterManager instance;
    public GameObject water;
    public Transform waterSpawner;
    public float waterFrecuency;
    public float waterPurityFilter = 40; 
    public TextMeshProUGUI info;
    public int cleanWater, dirtyWater;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        StartCoroutine(CreateWater());
        RefreshUI();
    }
    IEnumerator CreateWater()
    {
        while(true)
        {
            yield return new WaitForSeconds(waterFrecuency);
            Instantiate(water, waterSpawner.position, Quaternion.identity);
        }
    }
    public void AddWater(int i, bool clean)
    {
        if(clean)
        {
            cleanWater += i;
        }
        else
        {
            dirtyWater += i;
        }
        RefreshUI();
    }

    void RefreshUI()
    {
        info.text = "Agua limpia: " + cleanWater + "." + "\n" +
            "Agua sucia: " + dirtyWater + ".";
    }
}
