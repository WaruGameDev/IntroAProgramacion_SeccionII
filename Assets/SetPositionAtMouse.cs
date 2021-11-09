using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPositionAtMouse : MonoBehaviour
{
    public Vector3 worldPositionMouse;
    public float depth = -100;
    // Start is called before the first frame update
   
    // Update is called once per frame
    void Update()
    {
        Plane plane = new Plane(Vector3.forward, depth);

        float distance;

        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if(plane.Raycast(ray, out distance))
        {
            worldPositionMouse = ray.GetPoint(distance);
        }
        transform.position = worldPositionMouse;
    }
}
