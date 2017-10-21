using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Acceso a las librerias de Interfaz de Usuario predefinidas en Unity

public class GameManager : MonoBehaviour {

	public int lives; //variable que almacena un contador de las vidas restantes del jugador
	public Text livesText; //Variable de tipo texto que mostrara de forma grafica las vidas restantes del jugador

	public GameObject ball; //Variable que almacena el prefab de la pelota que se generara
	public Transform ballSpawnPosition; //Variable que almacena un Transform que indicara la posicion donde se generaran las nuevas pelotas

	public Text defeatText; // Variable de tipo texto que mostrara un mensaje de derrota si las vidas llegan a 0

	// Use this for initialization
	void Start () {
		
		//Define la cantidad de vidas iniciales en la interfaz de usuario
		livesText.text = "Vidas: " + lives;
		
	}
	
	// Update is called once per frame
	void Update () {

		//condicional que detecta si las vidas llegan a 0 y ejecuta la funcion GameOver
		if (lives == 0) {

			GameOver ();

		}
		
	}

	//Funcion que hace perder una vida al jugador
	void LooseLife(){

		lives = lives - 1;

		livesText.text = "Vidas: " + lives;

	}

	//Funcion que genera un nuevo clon del prefab pelota
	void SpawnBall(){

		//condicional para generar nuevas pelotas solo si la variable lives es mayor o igual a uno
		if (lives >= 1) {
			//Crea un clon del Prefab de la pelota en la posicion asignada por el Transform ballSpawnPosition
			Instantiate (ball, ballSpawnPosition.position, Quaternion.identity);
		}
	}

	//Funcion que se ejecuta cuando las vidas llegan a cero para representar la derrota
	void GameOver(){
		
		Time.timeScale = 0; //pausa el juego - lo detiene por completo haciendo que no se actualizen los fotogramas

		defeatText.enabled = true; //activa el texto de derrota al momento de perder

	}
}
