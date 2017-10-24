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

	void OnCollisionEnter (Collision col){

		if (col.gameObject.tag == "raqueta") {

			Raqueta raq = col.gameObject.GetComponent<Raqueta>();

			raq.SendMessage ("IniciarCorrutinaAgrandar");

			Destroy (gameObject);

		}

	}
}
