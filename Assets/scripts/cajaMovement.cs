using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajaMovement : MonoBehaviour
{
    public float speed = 0.1f;
    public float aceleracion = 0.01f;
    // Update is called once per frame
    void Update()
    {
        transform.Translate(0,-speed,0);
    }
    public void acelerationOfCaja()
    {
        speed = speed + aceleracion;
    }
}
