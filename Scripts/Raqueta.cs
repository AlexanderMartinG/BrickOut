using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AgrandarRaqueta(){
		//cambia la escala de x a 10
		transform.localScale = new Vector3 (10,transform.localScale.y, transform.localScale.z);

	}

	void AchicarRaqueta(){
		//cambia la escala de x a 6
		transform.localScale = new Vector3 (6,transform.localScale.y, transform.localScale.z);

	}

	//Inicia la corrutina
	void IniciarCorrutinaAgrandar(){

		StartCoroutine (CorrutinaAgrandar());

	}

	//corrutina agrandar
	IEnumerator CorrutinaAgrandar(){
		AgrandarRaqueta ();
		yield return new WaitForSeconds (10f); //esperar X segundos
		AchicarRaqueta();
	}

}
