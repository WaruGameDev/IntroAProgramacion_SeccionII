using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Filter : MonoBehaviour
{
    public Transform filterCleanWater, filterDirtyWater;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Water"))
        {
            if(other.GetComponent<WaterPropeties>().waterPurity < WaterManager.instance.waterPurityFilter)
            {
                //other.transform.position = filterDirtyWater.position;
                other.transform.DOMove(filterDirtyWater.position, 0.5f);
                WaterManager.instance.AddWater(1, false);
            }
            else
            {
                //other.transform.position = filterCleanWater.position;
                other.transform.DOMove(filterCleanWater.position,0.5f);
                WaterManager.instance.AddWater(1, true);
            }
            Destroy(other.gameObject, 3);
        }
    }
}
