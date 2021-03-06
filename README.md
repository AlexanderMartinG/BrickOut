# BrickOut
Código público de Proyecto Brick Out para Programación Orientada a Objetos de grupos 401 y 402

Este repositorio contiene varios scripts para hacer funcionar el juego dentro de Unity, varios de estos fueron vistos durante la clase como el Brick Manager y Brick Generator, pero también contiene variaciones de estos Scripts que tienen ejemplos de funcionalidades añadidas para que ustedes incluyan en sus juegos.


## Scripts

### Brick Manager
Script que se añade a los Prefabs de los ladrillos para definir su color y salud.

•[BrickManager.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/BrickManager.cs) //visto en clase

•[BrickManager.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/Variaciones/BrickManager.cs) // Actualizacion del Script para poder generar Power Ups al destruir los ladrillos, video de ejemplo:[https://youtu.be/cf9dSYkxACU]

### Brick Generator
Script que se añade al empty a partir del cual se generaran los ladrillos.

•[BrickGenerator.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/BrickGenerator.cs) // visto en clase

•[BrickGenerator.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/Variaciones/BrickGenerator.cs) // variación que genera los cubos hacia los lados del empty dejando este este en el centro [video de ejemplo](https://youtu.be/8ppZGmSgpxw)

### Game Manager
Script que controla la ejecución y funcionamiento del juego.

•[GameManager.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/GameManager.cs) // visto en clase, [video de ejemplo](https://youtu.be/n8dODAFBlRU)

### Raqueta
Segmento del Script Raqueta que contiene las Funciones y Corrutinas del Power Up "Agrandar".

•[Raqueta.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/Raqueta.cs) // visto en clase

•[Raqueta.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/Variaciones/Raqueta.cs) // variación del Script que incluye variables para controlar los valores como el tiempo de aplicacion de los power up y donde se genera el power up para que no colisione con los ladrillos, video de ejemplo:[https://youtu.be/cf9dSYkxACU]

### Agrandar
Script que se aplica al prefab de Power Up para agrandar la iniciar la corrutina de agrandar raqueta cuando este colisiona con la raqueta.

•[Agrandar.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/Agrandar.cs) // visto en clase

•[Agrandar.cs](https://github.com/AlexanderMartinG/BrickOut/blob/master/Scripts/Variaciones/Agrandar.cs) // variación del Script que incluye variables para controlar los valores como el tiempo de aplicacion de los power up y donde se genera el power up para que no colisione con los ladrillos, video de ejemplo:[https://youtu.be/cf9dSYkxACU]


#### Aviso
Me preguntaron cómo hacer un Script para generar pelotas y les dije que subiría un video, pero algunos alumnos ya programaron este Power Up en sus juegos y sería injusto si ahora subiera un video de cómo hacerlo, por ese motivo no se va a subir el video, pero puede programar el Power Up ustedes mismos usando la función Instantiate.
