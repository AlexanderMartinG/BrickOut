using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agrandar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter(Collision col){

		if (col.gameObject.tag == "Raqueta") {

			Raqueta Raq = col.gameObject.GetComponent<Raqueta> (); //Abreviacion de Acceso a componente Raqueta del Game Object Raqueta en la escena

			Raq.SendMessage ("IniciarCorrutinaAgrandar"); //Enviar instruccion al componente raquera para que inicie la funcion que comenzara la corrutina

			//Destruir el cubo verde tras iniciar el Power Up
			Destroy(gameObject);

		}

		//Destruir Power Up si colisiona con limite inferior
		if (col.gameObject.tag == "BordeInferior"){
			Destroy (gameObject);
		}

	}
}
