using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public enum POWER_UP_TYPE
    {
        DOUBLE_SPEED,
        DOUBLE_CANON,
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
                   
                    PowerUpManager.instance.SpeedDouble();
                    break;
                case POWER_UP_TYPE.DOUBLE_CANON:

                    PowerUpManager.instance.DoubleCanon();
                    break;
            }
            Destroy(gameObject);
        }
    }

}
