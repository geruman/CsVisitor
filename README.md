# Visitor
Es un patr�n de comportamiento. [Link descripci�n](https://sourcemaking.com/design_patterns/visitor)

El patr�n describe una manera de implementarle funcionalidad a un objeto desde un objeto externo llamado visitor. El objeto a modificar es enviado como parametro al visitor y el visitor realiza alguna acci�n accediendo a los m�todos publicos del objeto visitado

## Diagrama de clases
![UML](visitor.jpg)

## SOLID

* Single responsability

Cada visitor tiene la responsabilidad de reaccionar ante cada implementaci�n visitada, es dificil cumplir con este principio en el patr�n.

* Open/Closed principle

Si necesitamos agregar un objeto capaz de ser visitado debemos redise�ar el padre de los visitor y cada visitor capaz de visitar al nuevo objeto.

* Liskov substitution

Los objetos visitor deber�an poder ser intercambiados en runtime sin problema.

* Interface segregation

Cada Visitor debe tener la habilidad de interactuar con cualquier objeto "visitable" por lo que ser�a imposible mantener interfaces peque�as y segregadas para este patr�n.

* Dependency inversion

El padre de los objetos visitor debe conocer las implementaciones concretas de todos los objetos "visitables" por lo que es dificil cumplir con este principio.