using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float velocidadPersonaje = 10;
    public Transform theTransform;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            theTransform.Translate(Vector3.right
                * velocidadPersonaje * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            theTransform.Translate(Vector3.left
                * velocidadPersonaje * Time.deltaTime);
        }
    }
}
