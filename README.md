## Practica 2 Interfaces Inteligentes Introducción a los scripts en Unity

Marcos Jesús Barrios Lorenzo

alu0101056944

- (Trabajo realizado)[#trabajo-realizado]
- (Ejercicios)[#ejercicios]

### Trabajo realizado

!(Resultado final)[assets/finalresult.gif]

!(Ejercicio 2)[assets/2.gif]


Se siguió el guión para el primer ejercicio y se respondió en este mismo documento. Después se creó el script para el control de un cubo, dejando la cámara fija desde arriba. Finalmente se creó un cilindro que aumenta su tamaño, otro que puede ser empujado con la tecla espacio y uno que huye del jugador cuando se acerca. Un tipo cubo puede ser manejado por IJLM y cambia de color brevemente cuando cualquier objeto colisiona con él. Además, hay cubos que cambian de tamaño cuando el jugador se acerca, que también reaccionan a una esfera haciéndose más pequeños.

### Ejercicios


1. Crear una escena simple sobre la que probar diferentes configuraciones de objetos físicos en Unity. La escena debe tener un plano a modo de suelo, una esfera y un cubo.

    1. **Ninguno de los objetos será físico.**
    !(1a)[assets/1a.gif]
    > Los objetos quedan estáticos en la posición en la que estaban.
    
    2. **La esfera tiene físicas, el cubo no.**
    !(1b)[assets/1b.gif]
    > La esfera colisiona con el cubo y el suelo, rodando y moviéndose en el proceso.
    
    3. **La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo.**
    !(1c)[assets/1c.gif]
    > Ambos son afectados por la gravedad y colisionan el uno con el otro. La esfera es más pesada que el cubo. La masa influye en la forma en que colisionan los objetos; la esfera se resiste más que el cubo.
    
    4. **La esfera tiene físicas y el cubo es de tipo IsTrigger.**
    !(1d)[assets/1d.gif]
    > La esfera es afectada por físicas y atraviesa el cubo a pesar de que este último contiene un Box Collider.

    5. **La esfera tiene físicas y el cubo es de tipo IsTrigger y tiene físicas.**
     !(1e)[assets/1e.gif]
    > La esfera es afectada por físicas pero el cubo no, a pesar de tener un componente RigidBody. Es útil para tener más control sobre el objeto a través de scripts cuando sea necesario, es decir, como un interruptor para las fuerzas físicas sin tener que eliminar el componente.

    6. **La esfera y el cubo son físicos y la esfera tiene 10 veces la masa del cubo, se impide la rotación del cubo sobre el plano XZ.**
    !(1f)[assets/1f.gif]
    > El cubo no puede rotar si la esfera colisiona con él en direcciones que impliquen modificar el ángulo respecto a los ejes X ó Z.

