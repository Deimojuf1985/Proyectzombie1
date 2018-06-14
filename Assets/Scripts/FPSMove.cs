using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSMove : FPSAim
{
	// variable flotante de velocidad con un valor de 0.1
    public float speed = 0.1f;

	void Update ()
    {
	    //  esta es un condicional que idica que si preciono W el objeto avanzara hacia adelante
        if (Input.GetKey(KeyCode.W))
        {
			// la posicion de objeto avanzara acia adelante con la velocidad indicada en la variable speed
            transform.position += transform.forward* speed;
        }
        //  esta es un condicional que idica que si preciono S el objeto avanzara hacia atras
        if (Input.GetKey(KeyCode.S))
        {
			// la posicion de objeto avanzara acia atras con la velocidad indicada en la variable speed
            transform.position -= transform.forward * speed; 
        }
        //  esta es un condicional que idica que si preciono A el objeto avanzara hacia la derecha
        if (Input.GetKey(KeyCode.A))
        {
			// la posicion de objeto avanzara acia la derecha con la velocidad indicada en la variable speed
            transform.position -= transform.right * speed; 
        }
        //  esta es un condicional que idica que si preciono D el objeto avanzara hacia adelante
        if (Input.GetKey(KeyCode.D))
        {
			// la posicion de objeto avanzara acia la izaquierda con la velocidad indicada en la variable speed
            transform.position += transform.right * speed;
        }

		// gira es un metodo que se hereda de la clase FPSAim que me indica que cuando la pocision
		//del mouse en x y y este indicada siga la trayectoria con la que avanza y señala el mouse
		gira ();
	}
}
