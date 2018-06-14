using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour 
{
	void Start () 
	{
		int caractr = 0; // entero caractr que nombre para el caso 
		for (int i = 0; i < Random.Range(5, 10); i++) // un for que toma un rango de 5 a 10 instancias
		{           
			// esto es un caso que me tomara las instancias del heroe, zombie y ciudadano
			switch (caractr)                                                           
			{
				case 0:                                                               
					new Heroe (); // crea una nueva instancia del heroe
					break; // en caso de cumprirse el caso detiene el ciclo
				case 1:                                                                
					new Zombie (); // crea una nueva instancia del zombie                   
					break;// en caso de cumprirse el caso detiene el ciclo
				case 2:   
					new Ciudadano ();// crea una nueva instancia del ciudadano
					break;// en caso de cumprirse el caso detiene el ciclo
				default:                                 
					new Ciudadano (); //por defecto crea una nueva instancia del heroe
					break;// en caso de cumprirse el caso detiene el ciclo
			}
			caractr = Random.Range(1, 3);  // caracter toma un rango de 1 a 3 para crear ciudadanos o zombies
		}
	}
}
