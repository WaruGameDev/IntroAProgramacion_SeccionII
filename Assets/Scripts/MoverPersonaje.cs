using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverPersonaje : MonoBehaviour
{
    public float velocidadPersonaje = 10;
    public Transform theTransform;
    public int hp =10;
    

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
    private void Start()
    {
        print("Iniciado el gato");
        MiMetodo();
        print(Suma());
        SumaDosNumeros(2.5f,3);       
       
    }
    private void FixedUpdate()
    {
        
    }
    private void LateUpdate()
    {
        
    }
    private void OnMouseDown()
    {

        print("Gato clickeado");
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

    public int Suma()
    {
        return 1;
    }
    public void SumaDosNumeros(float a, float b)
    {
        print(a + b);
    }

    //operadores aritmeticos
    // + - * / %
    // Mathf
    // "hola" + " " + "mundo" == "hola mundo"

}
