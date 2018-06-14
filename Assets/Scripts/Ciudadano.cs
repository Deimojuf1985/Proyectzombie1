using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ciudadano
{
	public int age; // variable  que se usa para la edad de los cuidadanos
	string nombre; //  variable de tipo vector que agrupa  los nombres de los ciudadanos

	string [] matrisnombre = new string[]  //vector de tipo string que contiene 20 nombres 
	{
		"neponosueno", "william", "stella", "henry", "catalina", "pipe", "Laura", "Joana", "Katherine", "Alejandra",
		"Korina", "patricia", "claudia", "pedro", "Ana", "carolina", "Valentina", "silvana", "juan", "camilo"
	};

	public Ciudadano() // constructor del cuidadano
	{
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Cube); // el game object go toma la primitiva de cubo para el ciudadano      
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10)); // esta linea me define una posicion aleatoria de un vector3 que llame pos 
		go.transform.position = pos; //en esta linea le estoy diciendo al gameobject go que sea igual a vector3 pos 
		nombre = matrisnombre [Random.Range(0, matrisnombre.Length)]; // a la variable nombre le estoy diciendo que sea igual al vector de nombres con un rango de 0 a la longitud del vector
		age = Random.Range (15, 101);//a la variable edad le estoy diciendo que tomo un rango de 15 a 100

		Debug.Log (Hablar()); // me imprime el retorno del metodo hablar()
	}
		
	string Hablar() // metodo de tipo string que me imprimira un mensage
	{
		string mensaje = "Hola soy " + nombre + "  tengo " + age + " años"; // string mensage que me imprimira nombre y edad 
		return mensaje; // retorna el mensage
	}
}

