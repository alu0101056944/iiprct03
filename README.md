## Práctica 3 Delegados, Eventos

Marcos Jesús Barrios Lorenzo

alu0101056944

![Work done](assets/work.gif)

### Trabajo realizado

Se creó el script singleton [src/Scripts/MySceneController.cs](src/Scripts/MySceneController.cs) con los eventos de colisión en cilindro B y colisión con cilindro A. Otro script [src/Scripts/Events/Subscribers/ShowUITextOnCollisionWithB.cs](src/Scripts/Events/Subscribers/ShowUITextOnCollisionWithB.cs), que muestra en pantalla una etiqueta cuando el evento colisión con cilindro B ocurre se agregó a los cilindros de tipo A. También se modificó el script para empujar los cilindros B [src/Scripts/Cylinders/PushOnSpacebar.cs](src/Scripts/Cylinders/PushOnSpacebar.cs) de forma que cuando alguien colisione con el cilindro A la fuerza del empuje aumente. Un último script [src/Scripts/Controllers/Events/Callers/CallEventOnCollisionWithCylinder.cs](src/Scripts/Controllers/Events/Callers/CallEventOnCollisionWithCylinder.cs) agregado al jugador dispara los eventos de colisión de cilindros.

A continuación el script [src/Scripts/Events/CloseToPlayerEvent.cs](src/Scripts/Events/CloseToPlayerEvent.cs) define un evento estático para que los cilindros A se subscriban con el script [src/Scripts/Events/Subscribers/ChangeColorOnPlayerCloseToA.cs](src/Scripts/Events/Subscribers/ChangeColorOnPlayerCloseToA.cs) y cambien de color cuando ocurra ese evento. Un script [src/Scripts/Events/Subscribers/RotateOnPlayerCloseToA.cs](/src/Scripts/Events/Subscribers/RotateOnPlayerCloseToA.cs) también se subscribe y orienta el GameObject hacia el objeto especificado en el editor mediante un campo public. Se creó un nuevo script [src/Scripts/Cubes/MovingCube.cs](src/Scripts/Cubes/MovingCube.cs) que mueve el GameObject en el eje Z para demostrar la rotación de la esfera.

Después se ajustó el script de controlador del cubo [src/Scripts/Controllers/MyCharacterController.cs](src/Scripts/Controllers/MyCharacterController.cs) para que se mueva respecto a sus propios ejes y no a los globales con el objetivo de fijar la cámara como GameObject hijo a modo de tercera persona. El movimiento ha pasado a ser basado en físicas en vez de con el transform.

Finalmente, para demostrar el uso de <code>Debug.DrawRay()</code> se modificó el evento [src/Scripts/Events/CloseToPlayerEvent.cs](src/Scripts/Events/CloseToPlayerEvent.cs) para que dibuje una linea en la vista de escena desde el centro del cilindro que tiene el script hasta el jugador cuando éste se acerque lo suficiente.
