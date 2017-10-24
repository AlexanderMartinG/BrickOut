using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickManager : MonoBehaviour {
	public Color brickColor;
	public int brickHealth;

	public GameObject powerUp; //Indica el prefab de Power Up que crea el ladrillo al destruirse
	public bool puedeGenerarPowerUp; //Indica si se generara un power up o no al destruirse el ladrillo

	public float distanciaGeneracionPowerUp; //Distancia en eje X que se agrega al generar el power up para que no pueda colisionar con los ladrillos o la pelota

	// Use this for initialization
	void Start () {

		gameObject.GetComponent<Renderer> ().material.color = brickColor; // cambiar color a material

	}
	
	// Update is called once per frame
	void Update () {

		//Condicional que destruye un cubo si su salud llega a cero
		if (brickHealth == 0) {
			
			Destroy (gameObject); //Funcion que destruye el ladrillo

			if (puedeGenerarPowerUp) {
				Instantiate (powerUp, new Vector3(transform.position.x,transform.position.y,transform.position.z - distanciaGeneracionPowerUp), Quaternion.identity);
			}

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
