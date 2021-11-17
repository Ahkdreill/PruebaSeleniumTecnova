Feature: Automatización de pruebas sitio Trello.com
	

Scenario Outline: CP 01 Prueba Login Incorrecto
	Given El usuario presiona el botón de inicio de sesión
	And El usuario ingresa correo <correo> y contraseña <password> incorrectos
	When El usuario presiona el botón ingresar
	Then El sistema no permite ingresar al sitio

	Examples: 
	| correo                  | password    |
	| pruebatecnova@gmail.com | abc12345678 |

Scenario Outline: CP 02 Flujo End to End
	Given El usuario ingresa a la aplicación utilizando correo <correo> y contraseña <password>
	And El usuario crea crea un Tablero
	And El usuario crea las listas Por Hacer - En Proceso - Finalizado
	When El usuario crea una tarjeta en la Lista Por Hacer
	And Ingresa Descripción - Etiqueta color Azul - Fecha de vencimiento - Archivo adjunto - Portada - Comentario.
	And El usuario guarda los cambios.
	And El usuario cierra la tarjeta usando el botón X
	Then El usuario Mueve la tarjeta a En Proceso
	And El usuario Elimina el Tablero

	Examples: 
	| correo                             | password     |
	| cristian.test.automation@gmail.com | abc12345678! |