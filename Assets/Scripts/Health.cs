using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int health =10;
    /// <summary>
    /// Esta funcion le hace daño al personaje y revisa si tiene la vida bajo 0
    /// </summary>
    /// <param name="damage"></param>
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            //TODO: agregar algun efecto al morir.
            //queda sin vida
        }
    }
 
}
