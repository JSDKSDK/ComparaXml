# ComparaXml

Version del proyecto 1.0
Net core 6.0 soporte a largo plazo
Aplicacion windows forms

## Descripcion del proyecto

Esta solucion se compone una serie de proyectos para poder utilizar la comparación de archivos pdf y xml.
Se compone por:

## Comparar => Solución Principal
Tiene un FORM para poder cargar un pool de datos con las configuraciones de donde se van a buscar los archivos a comparar.
Se realizan validaciones para saber si tiene una estructura CSV valida.

## Models
Tiene el proyecto de Models, donde obtenernos una seria de clases para poder manipular la data que está entrando, la que procesamos
y la que sale en el reporte xls

## ModuleLogic.
Tiene la misión de realizar todas las operaciones lógicas para poder leer el pool y cada caso de uso para poder iterar sobre la lista
Así como llamar acorde al caso, las distintas rutinas para realizar el análisis y la comparación de los documentos en cuestión.

Aquí se realiza la validación del xml, para ello validamos primero si los dos archivos tienen la misma estructura de etiquetas
Sino se cumple esto se añade una linea al reporte final donde se indica el caso de prueba y el resultado.
Si son iguales comienza a comparar el contenido de las etiquetas, si encuentra alguna diferencia entre una y otra entonces la guarda
en una lista que se agrega al reporte, si se tiene más de una diferencia se agrega nueva línea al reporte.

Se genera una lista de reporte final dependiendo los casos que sean descritos en el pool.


## Utiities

Tiene métodos genericos reutilizables.
Entre ellos para generar el reporte en xls
Validar si un xml tiene una estructura igual o es diferente
Extrae nombre de las etiquetas.
Extrae nombre de las etiquetas y valor de cada una de ellas.
Compara valor de las etiquetas.

## Datos entrada:

CSV entrada:
tipo_archivo,caso_prueba,subcaso_prueba,file1,file2,ubicacion
1,1,1,file1.xml,file2.xml,C:\Desarrollo\Fuentes\
1,1,1,xml1.xml,xml2.xml,C:\Desarrollo\Fuentes\

## Datos Salida:
tipo_archivo,CasoPrueba,subcaso_prueba,file1,file2,diferencias
xml,1,ip,xml1,xml2.xml,xml,Laetiqueta ""+  tiene diferencias valor en archivo 1 : "" valor en archivo 2:""


## Creador
Este proyecto es creado por el Ing. Javier Rayon Martinez.
Lo libero bajo licencia (CC BY-NC-SA) (Se pide que si es utilizado de forma total o parcial), se comunique a mi persona y se otorgue el reconocimiento pertinente.
Autorizo el uso bajo esta licencia para fines de practica o educacion, no para uso comercial (salvo previa autorizacion de mi persona).

## "Recolectar Datos es el primer paso a la sabiduria, pero compartir informacion es el primer paso a la comunidad" (Comercial IBM con referencia a Linux)
