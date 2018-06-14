using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heroe //clase publuca heroe
{
	public Heroe() // este es el contructor de heroe
	{
		GameObject go = GameObject.CreatePrimitive (PrimitiveType.Capsule); // esta linea me agrega la primitiva de capsula al gameobject que llame go     
		go.GetComponent<Renderer>().material.color = Color.red;//esta linea agrega el color rojo al gameobject go accediendo al componente color
		Vector3 pos = new Vector3 (Random.Range(-10, 10), 0, Random.Range(-10, 10)); // esta linea me define una posicion aleatoria de un vector3 que llame pos 
		go.transform.position = pos; // en esta linea le estoy diciendo al gameobject go que sea igual a vector3 pos 
		go.AddComponent<FPSMove>();  // esto me añade script llamado fpsmove al game object go       
		Camera.main.gameObject.transform.localPosition = go.transform.position; //le estoy dando a la main camara la posicion del gameobgect go
		Camera.main.transform.SetParent(go.transform);  //la main camara toma el componente transform de game object go                          
		Camera.main.gameObject.AddComponent<FPSAim>(); // añade el script fpsaim a la main camara
	}
}


