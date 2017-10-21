using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour {
	public Color brickColor;
	public int brickHealth;

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Renderer> ().material.color = brickColor; // cambiar color a material

	}
	
	// Update is called once per frame
	void Update () {

		//Condicional que destruye un cubo si su salud llega a cero
		if (brickHealth == 0) {
			
			Destroy (gameObject); //Funcion que destruye el ladrillo

		}
		
	}

	void OnCollisionEnter(Collision col){

		//condicional que detecta si se ocaciono una colision con una pelota
		if (col.gameObject.tag == "pelota") {

			//resta un punto de salud al ladrillo cuando una pelota colisiona con el
			brickHealth = brickHealth - 1;

		}

	}
}
