using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(-2, 0, 0);
        }  
        if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(2, 0, 0);
        }  

        Vector3 posicionActual = transform.position;
        posicionActual.x = Mathf.Clamp(posicionActual.x, -2f, 2f);
        transform.position = posicionActual;
    }

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("caja"))
        {
            Destroy(gameObject);
        }
    }
}
