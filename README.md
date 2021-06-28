# Documentación Oficial
## *Aspectos técnicos*

Los softwares, las versiones, sistemas operativos y paquetes externos que se han utilizado en la creacion de este programa son los siguientes.

### **Softwares.**

 1. **SQL SERVER EXPRESS EDITION**
   
    > Versión "ligera" de Microsoft SQL server. Ésta sirve para uso libre y distribuible a los desarrolladores de software. A diferencia de la versión MSDE 2000 esta versión incluye mayor almacenamiento en las bases de datos (hasta 10 GB - anteriormente 2 GB) adicionalmente elimina el proceso de sobrecarga que generaba la versión anterior al conectarse más de 5 usuarios. La limitación de tamaño que tiene esta versión es sólo de datos y hay que excluir del total de los 4 Gb el archivo de log.ldf.

2. **Micosoft SQL Server Managment Studio 18 (SSMS)**
    >SQL Server Management Studio (SSMS) es un entorno integrado para administrar cualquier infraestructura de SQL. Use SSMS para acceder, configurar, administrar y desarrollar todos los componentes de SQL Server, Azure SQL Database y Azure Synapse Analytics. SSMS ofrece una única utilidad integral que combina un amplio grupo de herramientas gráficas con una serie de editores de script enriquecidos que permiten a desarrolladores y administradores de bases de datos de todos los niveles acceder a SQL Server.

3. **Visual Studio Community 2019**
   >Microsoft Visual Studio es un entorno de desarrollo integrado (IDE, por sus siglas en inglés) para Windows y macOS. Es compatible con múltiples lenguajes de programación, tales como C++, C#, Visual Basic .NET, F#, Java, Python, Ruby y PHP, al igual que entornos de desarrollo web, como ASP.NET MVC, Django, etc., a lo cual hay que sumarle las nuevas capacidades en línea bajo Windows Azure en forma del editor Monaco.                  
   
   >Visual Studio permite a los desarrolladores crear sitios y aplicaciones web, así como servicios web en cualquier entorno compatible con la plataforma .NET (a partir de la versión .NET 2002). Así, se pueden crear aplicaciones que se comuniquen entre estaciones de trabajo, páginas web, dispositivos móviles, dispositivos embebidos y videoconsolas, entre otros.

### **Sistemas Operativos**

1. **Windows 10**
    >Windows 10 es el actual sistema operativo desarrollado por Microsoft como parte de la familia de sistemas operativos Windows NT.​ Fue dado a conocer oficialmente en septiembre de 2014, seguido por una breve presentación de demostración en la conferencia Build 2014.

### **Paquetes Externos**

1. **.NET 5.0**
   >.NET es un framework informático administrado, gratuito y de código abierto para los sistemas operativos Windows, Linux y macOS. ​ Es un sucesor multiplataforma de .NET Framework.​​

2. **EntityFramework 4.8**
   >Entity Framework es un conjunto de tecnologías en ADO.NET que respaldan el desarrollo de aplicaciones de software orientadas a datos. Los arquitectos y desarrolladores de aplicaciones orientadas a datos han luchado con la necesidad de lograr dos objetivos muy diferentes.
   
3. **Paquetes NuGet:**
   
   >1. Microsoft.EntityFramework 5.0.6
   >2. Microsoft.EntityFramework.SqlServer 5.0.6
   >3. Microsoft.EntityFramework.Design

4. **iTextSharp**
5. **Microsoft Visual Studio Installer Projects**
## *Instalación*
A continuación se especificaran los pasos a seguir junto a los requerimientos necesarios para obtener una 
instalacion correcta.

### *Requerimientos.*

1. *Fremework 4.8*
>Contar con el parquete de framework 4.8

2. *.Net 5.0*
>Contar con el parquete de .NET 5.0

3. *Sql Server Express*
>Tener instalado Sql Server en su version Express para crear la base de datos

### *Proceso de instalacion*

*Paso 1*
>Abrir el scrypt de la base de datos llamado "Query_DBCovid-19".

*Paso 2*
>Crear la Base de Datos siguiendo  los pasos especificados en el archivo, en ella se crearan y se añadiran los datos necesarios.

*Paso 3*
>Ejecutar el archivo llamado "ProcesoVacunacion" 

*Paso 4*
>Una vez ejecutado aparecerá una ventana de instalacion del software donde dara click a "siguiente"

*Paso 5*
>Seguidamente usted podra elegir donde desea que se isntale el software o dejar el por defecto; igualmente podra elegir si solo instalarlo en el usuario en el que esta o en todos los usuarios de la maquina, una vez definido eso podra dar click en "siguiente"

*Paso 6*
>Una ventana d econfirmación aparecerá para poder comenzar el proceso de instalacion, dar click a "siguiente" si desea comenzar el proceso de instalación

*Paso 7*
>Aparecera una ventana pidiendo permisos de administrador, dar click en "SI". El software se comenzara a instalar, espere a que la barra de progreso termine de finalizar y seguidamente dar click en "cerrar"

*Paso 8*
>Buscar la aplicación en el lugar donde se ha instalo o puede buscarla en el buscador de windows como "Proceso_Vacunacion".
## *Manual de usuario*
### Descripción general del software desarrollado.
El software busca facilitar el proceso de vacunación desde sus inicios, brindando la posibilidad de que el ciudadano se acerque a una de las cabinas asignadas para poder ser atendido por el gestor. El software es especialmente para los gestores, ya que ellos serán los únicos en contar con un usuario y contraseña para poder acceder a este además será responsabilidad de ellos realizar un proceso de cita, seguimiento de cita, proceso de vacunación, cita segunda dosis y también podrá encontrar información acerca de los empleados y de las cabinas en las que se está realizando un proceso de vacunación.


### Descripción de cada formulario.

1. Login: al abrir la aplicación se encontrará con una pantalla, donde se le pedirá que ingrese su usuario y contraseña, con las cuales ya deberá contar si es un gestor. Finalmente, para poder ingresar es necesario que le dé click al botón que dice "Iniciar Sesión", si sus credenciales son correctas será llevado al menú principal.


|!["Página Login: solicita usuario y contraseña "](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Login.png)
   
   
   
2. Menú principal: se encontrara una imagen de concienciación a su lado izquierdo encontrara un panel con siete pestañas que lo redirigirán a otras páginas, las pestañas son:

|!["Página Menú principal: se muestra una imagen de concientización y un panel para cambiar de pantalla."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/MainMenu.png)


    - Proceso de cita: aquí se pedirá ingresar los datos del ciudadano que quiera agendar una cita, los datos que se piden son: DUI, nombre, dirección, correo, teléfono, edad y si pertenece a una organización su número de identificación. Además, al lado inferior derecho se encontraran dos botones, uno para registrar al ciudadano y otro para crear un PDF con la información de la cita que se le entregara a la persona que la solicito.

|!["Página Proceso de cita: se piden los datos del ciudadano"](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Procesarcita.png)


    - Seguimiento de cita: en esta pestaña se ingresará el DUI del ciudadano para verificar si cuenta con una cita además sé podrá exportar a PDF los datos de este.

|!["Página Seguimiento de cita : muestra un cuadro para ingresar el DUI del ciudadano"](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Seguimiento%20de%20Cita.png)


    - Proceso de vacunación: aquí se pedirá el DUI, la fecha y hora de llegada del ciudadano al centro de vacunación, fecha y hora de la vacunación del ciudadano, si tuvo efectos secundarios y si fue así en cuantos minutos surgieron. Cuenta con dos botones, uno que limpia los datos que han sido colocados en las cajas de texto y otro que es el que guarda los datos ingresados.

|!["Página Proceso de vacunación: pide el DUI del ciudadano, hora y fecha de la vacunación."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Proceso%20de%20Vacunacion.png)


    - Cita segunda dosis: Se ingresará el DUI del ciudadano y utilizando los datos ingresados en el proceso de la primera cita, se le dará la cita para su segunda dosis después de 6 a 8 semanas.


|!["Página Cita segunda dosis: se pide el DUI del ciudadano para realizar la segunda cita."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Cita%20Segunda%20Cita.png)


    - Información de empleado: se mostrará en una tabla la información de los empleados en la cabina en la que se inició sesión.

|!["Página Información de empleado: muestra una tabla con los empleados en el lugar de la cabina."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Informacion%20Empleados.png)

    - Información de cabina: se mostrará la información de la cabina en la que se inició sesión.

|!["Página Información de cabina: muestra una tabla con las cabinas existentes."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Informacion%20Cabina.png)

    - Cerrar sesión: te regresa a la pantalla del login.

*Nota:* En las pestañas mencionadas anteriormente excepto cerrar sesión,a la par de su título se encuentra una x que los llevara de regreso a la página principal.

### Errores y Soluciones.

| <center>Página</center> | <center>Error</center>| <center>Solución</center>|<center>Imagen </center>|
| -- | -- | -- | -- |
| Login | Si se ingresan las credenciales incorrectas, se muestra el siguiente mensaje: "¡El usuario no existe!" | Verificar si el usuario y la contraseña están ingresadas correctamente. |!["Error 1: Se ingresaron las credenciales incorrectas."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Error_Login.png)
| Proceso de cita| Cuando el ciudadano ya fue registrado una vez y se intenta registrar otra vez se muestra el siguiente mensaje: "El ciudadano ya ha sido registrado o ya posee una cita previa". | Se puede ir a seguimiento de cita para poder verificar que el ciudadano en efecto tiene una cita ya registrada. |!["Error 3: El ciudadano ya ha sido registrado o ya posee una cita previa."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Errorprocesamientodecita%20_usuarioyaingresado.png)
| Proceso de cita | Cuando el ciudadano no es parte de uno de los grupos prioritarios se muestra el siguiente mensaje: "Aún no es turno del ciudadano, espere atentamente noticias del gobierno".| En este caso se debe de esperar que el gobierno autorice la fase donde el ciudadano cumpla con las características. |!["Error 4: Aun no es turno del ciudadano, espere atentamente noticias del gobierno."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Errorprocesodecita_nogrupoprioritario.png)
| Proceso de cita | Cuando algún dato ha sido introducido de manera incorrecta se muestra el siguiente mensaje: "Datos inválidos, revise las entradas de los datos". | Lo más recomendable es revisar los datos registrados para encontrar el error y consultarte de nuevo al ciudadano.|!["Error 5: Datos inválidos, revise las entradas de los datos."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Errorprocesamientodecita_datosincorrectos.png)
| Proceso de vacunacion | Cuando se ingresa el DUI de un ciudadano que ya realizo el proceso de vacunación o un DUI que no existe, se muestra el siguiente mensaje: "El DUI no existe o ya termino el proceso de vacunación."| Lo mejor sería primero revisar que el DUI se digitara de manera correcta y si fue así se deberá consultar con el ciudadano si ya realizo el proceso antes. | !["Error 6:  "El DUI no existe o ya termino el proceso de vacunacion."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/vacunacion_terminoproceso.png)
| Segunda dosis | Cuando se ingrese el DUI del ciudadano que ya agendo su segunda cita de vacunación o cuando el DUI ingresado no existe se muestra el siguiente mensaje: "El DUI no existe o su segunda dosis ya ha sido agendada" | Verificar el DUI ingresado y confirmarlo con el ciudadano, si este es el correcto consultarle al ciudadano si ya recibió su segunda cita para la vacunación. | !["Error 8:"El DUI no existe o su segunda dosis ya ha sido agendada."](/POO/Documentacion%20Oficial/Manual%20de%20Usuario/Imagenes%20de%20Formularios%20y%20Cuadros%20de%20dialogo/Error_segundadosis_noexiste.png)

