using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum POWER_UP_TYPE
    {
        DOUBLE_SPEED,
        EXPLOSIVE_BALL,
        OTHER
    }
    public POWER_UP_TYPE powerUp;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Bullet"))
        {
            switch(powerUp)
            {
                case POWER_UP_TYPE.DOUBLE_SPEED:
                    Destroy(gameObject);
                    PowerUpManager.instance.SpeedDouble();
                    break;
            }
            
        }
    }

}
