using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Girar : MonoBehaviour
{
    public Transform theTransform;
    public float velocidadGiro;
    
    // Update is called once per frame
    void Update()
    {
        theTransform.Rotate(Vector3.up * velocidadGiro * Time.deltaTime);
    }
}
