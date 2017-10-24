using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raqueta : MonoBehaviour {

	public float movementSpeed; //cantidad de movimiento del objeto cada fotograma

	private Transform raqueta; // Abreviar el acceso al Transform del objeto

	public Transform limiteDerecho; //Marca donde inicia la parte superior de la raqueta

	public Transform limiteIzquierdo; //Marca donde inicia la parte inferior de la raqueta

	public Transform esquinaDerecha; //Marca donde inicia la esquina superior

	public Transform esquinaIzquierda; //Marca donde inicia la esquina inferior

	public float tamañoAgrandadoX; //Escala de X aumentada por el power up Agrandar

	private float tamañoNormalX; // Escala normal de X

	public float duracionAgrandar; //Tiempo que durara el estado agrandado de la raqueta al tomar el Power Up

	// Use this for initialization
	void Start () {
		
		//abreviacion para acceder al Transform Actual
		raqueta = gameObject.transform;

		//Almacena el valor de la escala iniciar en el eje X de la raqueta
		tamañoNormalX = raqueta.transform.localScale.x;

	}
	
	// Update is called once per frame
	void Update () {


			if (Input.GetKey ("left")) {

				raqueta.position = new Vector3 (raqueta.position.x - movementSpeed, raqueta.position.y, raqueta.position.z);

			}

			if (Input.GetKey ("right")) {

				raqueta.position = new Vector3 (raqueta.position.x + movementSpeed, raqueta.position.y, raqueta.position.z);

			}
			
	}

	//Funcion para Incrementar la escala en eje X de la raqueta
	void Agrandar(){
		raqueta.localScale = new Vector3 (tamañoAgrandadoX, raqueta.localScale.y, raqueta.localScale.z);
	}

	//Funcion para regresar la escala en eje X de la raqueta a su tamaño inicial
	void Reducir(){
		raqueta.localScale = new Vector3 (tamañoNormalX, raqueta.localScale.y, raqueta.localScale.z);	
	}

	//Funcion que da Inicio a la CorrutinaAgrandar
	void IniciarCorrutinaAgrandar(){
		StartCoroutine (CorrutinaAgrandar ()); //Ejecuta la corrutina Agrandar
	}

	//Corrutina para activar la funcion Agrandar y Achicar en tiempos determinados
	IEnumerator CorrutinaAgrandar(){
		Agrandar (); //Ejecutar la funcion Agrandar
		yield return new WaitForSeconds (duracionAgrandar); //Esperar una determinada cantidad de segundos
		Reducir(); //Ejecutar la funcion Reducir
	}

}
