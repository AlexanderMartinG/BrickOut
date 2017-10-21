using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickGenerator : MonoBehaviour {
	
	public GameObject[] tiposDeLadrillos; //Arreglo de GameObjects que almacena distintos Prefabs de ladrillos

	public int cantidadFilas; //Cantidad de Filas de ladrillos que se generara
	public int cantidadColumnas; //Cantidad de Columnas de ladrillos que se generara

	public float separacionVertical; //Separacion Vertical entre filas de Ladrillos
	public float separacionHorizontal; //Separacion Horizontal entre columnas de ladrillos


	// Use this for initialization
	void Start () {

		//Ciclo for que genera distintas filas de ladrillos 
		for (int i = 0; i < cantidadFilas ; i++) {

			//Calculo de donde la posicion vertical de cada fila en relacion al empty que los genera
			float separacionV = gameObject.transform.position.y + (i * separacionVertical);

			//Ciclo for que genera una serie de ladrillos uno frente a otro 
			for (int e = 0; e < cantidadColumnas; e++) {

				//calculo de la posicion horizontal de cada ladrillo de la fila  en relacion al empty que los genera
				float separacionH = gameObject.transform.position.x + (e * separacionHorizontal);

				//Selecciona un ladrillo del arreglo de forma aleatoria
				int tipoDeLadrillo = Random.Range (0, tiposDeLadrillos.Length); 

				//Crea un clon del prefab del arreglo seleccionado aleatoreamente y lo ubica a la derecha y emparenta en relacion al empty que los genera
				Instantiate (tiposDeLadrillos[tipoDeLadrillo], new Vector3 (separacionH, separacionV, 0f),Quaternion.identity,gameObject.transform);

				//solo genera clon a la izquieda a partir de la segundo columna
				if (e >= 1) {
					//Crea un clon del prefab del arreglo seleccionado aleatoreamente y lo ubica a la izquieda y emparenta en relacion al empty que los genera
					Instantiate (tiposDeLadrillos [tipoDeLadrillo], new Vector3 (-separacionH, separacionV, 0f), Quaternion.identity, gameObject.transform);
				}
			}
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
