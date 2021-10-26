using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboManager : MonoBehaviour
{
    public static CuboManager instance;
    public int cubosTocados;
    public List<GameObject> cubos;
    public int controlador = 0;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        EjemploWhile();


        for (int i = 0; i < 10; i++)
        {
            //print("Loop n° " + i);
        }
        foreach(GameObject cubo in cubos)
        {
            cubo.GetComponent<Renderer>().material.color = Color.magenta;
            print("un cubo");
        }
        ForCubos(3);
    }
    public void EjemploWhile()
    {
        while (controlador < 5)
        {
            print("holi");
            controlador++;
        }
    }
    public void ForCubos(int indice)
    {
        for (int i = 0; i < cubos.Count; i++)
        {
            if (i < indice)
            {
                cubos[i].GetComponent<Renderer>().material.color = Color.cyan;
            }
            else
            {
                cubos[i].GetComponent<Renderer>().material.color = Color.black;
            }
        }
    }
}
