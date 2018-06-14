using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie // clase zombie
{
	string conpcol;//string conpcol para la comparacion de los colores
	public Zombie ()//constructor de zombie
	{
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube); // esta linea me agrega la primitiva de cubo al gameobject que llame go        
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10));// esta linea me define una posicion aleatoria de un vector3 que llame pos 
		go.transform.position = pos; // en esta linea le estoy diciendo al gameobject go que sea igual a vector3 pos 
		int coler = Random.Range (0, 3); // un entero llamado coler que me toma un rango de 0 a 2 
		// un consicional if que me dice que si es igual a 0 el go va ser igual a cyan si es 1 green (verde) sino es magenta 
		if (coler == 0)  
		{
			go.GetComponent<Renderer>().material.color = Color.cyan; // go sera igual a color cyan
			conpcol = "cyan"; // conpcol me imprimira un string que diga "cyan"
		}
		else if(coler == 1)
		{
			go.GetComponent<Renderer>().material.color = Color.green; // go sera igual a color green
			conpcol = "green"; // conpcol me imprimira un string que diga "green"
		}
		else 
		{
			go.GetComponent<Renderer>().material.color = Color.magenta; // go sera igual a color magenta
			conpcol = "magenta"; // conpcol me imprimira un string que diga "magenta"
		}

		Debug.Log (Hablar());
	}

	public string Hablar() // metodo de tipo string que me imprimira un mensage
	{
		string mensaje = "soy un Zombi de color " + conpcol; // string mensage que me imprimira que es un zombie y el color que tenga conpcol 
		return mensaje; // retorna el mensage
	}
}


