using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MoverPersonaje : MonoBehaviour
{
    public float velocidadPersonaje = 10;
    public Transform theTransform;
    public int hp =10;
    public SpriteRenderer theRen;
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            theTransform.Translate(Vector3.right
                * velocidadPersonaje * Time.deltaTime);
            theRen.flipX = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            theTransform.Translate(Vector3.up
                * velocidadPersonaje * Time.deltaTime);            
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            theTransform.Translate(Vector3.left
                * velocidadPersonaje * Time.deltaTime);
            theRen.flipX = false;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            theTransform.Translate(Vector3.down
                * velocidadPersonaje * Time.deltaTime);
        }
    }
    
    private void OnMouseDown()
    {
        hp--;
        
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
        else if (hp < 5)
        {
            transform.DOShakePosition(.5f);
        }
        else
        {
            transform.DOShakeRotation(.5f);
        }
        
    }
    private void OnMouseDrag()
    {
        print("Gato siendo clickeado");
    }
    private void OnMouseUp()
    {
        print("Al dejar de clickear el gato");
    }

    private void OnMouseEnter()
    {
        print("Cursor entra al gato");
    }
    private void OnMouseOver()
    {
        print("Cursor sobre el gato");
    }
    private void OnMouseExit()
    {
        print("Curso sale del gato");
    }

    public void MiMetodo()
    {
        print("llame a mi metodo");
    }

    public string Suma()
    {
        return "1";
    }
    public void SumaDosNumeros(float a, float b)
    {
        print(a + b);
    }

    //operadores aritmeticos
    // + - * / % 
    // += -= *= /=
    //operadores de comparación
    // == < > <= >= !=
    // Mathf
    // "hola" + " " + "mundo" == "hola mundo"
    //operadores lógicos
    // && ||
    // T && T => T
    // T && F => F
    // T || T => T
    // T || F => T
    // F || F => F
    // if () else () elseif

}
