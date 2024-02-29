Codigo hecho por Miguel Canto y colaborador Cristian Llanes.

Clases principales:
- Tarjeta, Menu, Inicializador, Operaciones

Clases de operaciones frountground (llamadas por el cliente):
- Menudebito, Menucredito, Servicios, Program

Clases de operaciones background:
- Conexion, Tarjetacredito, Tarjetadebito

¿Como funciona la clase conexión?
Esta permite acceder a la base de datos mediante las
librerias SqlClient de Microsoft, es importante utilizar
using para que podamos utilizar sqlConnection, a esta se 
le asigna un nombre con el que podamos acceder
En el constructor de la clase conexion se utiliza la propiedad string con los datos necesarios (en ellos se
debe reemplazar el nombre de servidor, base de datos,
usuario, y la contraseña del usuario, de esta manera 
se puede acceder con la propiedad SqlConnection que en
este caso se nombre "connection" enviando la conexion 
tipo string, ahora creamos un metodo para abrir la 
conexion y utilizar un metodo de SqlConnection 
.Open() con el que se accede al servidor)

Eso es simplemente para poder utilizar los metodos que 
nos permiten modificar, actualizar y obtener los datos
que se tengan en la base de datos

¿Clase inicializador? 
Esta permite evitar la perdida de datos por 
reinicializacion y hacer mas simple el entendimiento
del codigo.





