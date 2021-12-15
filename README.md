# ExamNet

Metodo GET
https://appnetcore-335204.appspot.com/stats

Metodo POST
https://appnetcore-335204.appspot.com/mutant


Para SQL Server no me pude conectar desde el SQL Server Managemente de mi maquina toco por consola desde Google Cloud
Para conectarse apenas salga la consola hay que escribir el siguiente comando:

gcloud beta sql connect dbmutant --user=root

en este punto solicita la contraseña, la cual es: 1qa2ws3eD* 

Ahí informa que esta conectado a la base de datos master, para poder ejecutar scripts es importante poner el USE para indicarle sobre que base de datos realizar la consulta.

USE dbmutant

Este es un ejemplo de un select: use dbmutant select * from mutant


A nivel local se puede descargar el proyecto y abrir la solución que se encuentra cargada en el repositorio.
