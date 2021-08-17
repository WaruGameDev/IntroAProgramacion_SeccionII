using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HolaMundo : MonoBehaviour
{
    public int edad = 89;
    public float altura = 1.5f;
    public string nombre = "Juan";
    public bool hambre;
    [SerializeField]
    private int valorEscondido;
    public Camera cameraObject;
    public Transform theTransform;
    public float velocidadGiro = 10;

    // Start is called before the first frame update
    void Start()
    {
        cameraObject.backgroundColor = Color.yellow;
    }

    // Update is called once per frame
    void Update()
    {
        theTransform.Rotate(Vector3.up *
            velocidadGiro * Time.deltaTime);
        Debug.Log("Hola mundo");
    }
}
