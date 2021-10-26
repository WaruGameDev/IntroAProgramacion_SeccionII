using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterPropeties : MonoBehaviour
{
    public float waterPurity;
    public Material waterClear, waterDirty;
    public MeshRenderer mesh;
    // Start is called before the first frame update
    void Start()
    {
        waterPurity = Random.Range(0, 100);
        if(waterPurity < WaterManager.instance.waterPurityFilter)
        {
            mesh.material = waterDirty;
        }
        else
        {
            mesh.material = waterClear;
        }
    }    
}
