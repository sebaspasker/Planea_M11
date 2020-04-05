# Propuesta de web HADA
		
Nombre de los Miembros:

-Sebastian Pasker González(coordinador)

-Santiago Sáez Caselles

Turno:

Martes 11:00-13:00

# Descripción


Esta página web consistirá en un planificador personal de planes entre diferentes usuarios. Dos usuarios podrán acordar un horario de disponibilidad y la página proporcionará varios planes dentro de la categoria propuesta en la ciudad de uno de los dos integrantes.

# Parte pública:

- Ofrecer el login -> permitirá al usuario registrarse en la web, o si ya lo está acceder a su perfil mediante una contraseña y un usuario.
privada de la misma.

- Mostrar usuarios -> Mostrar otros usuarios con las mismas preferencias y con una disponibilidad de usuarios en común.

- Filtro de categorías -> Filtro de los tipos de planes que puede ofrecerte la web.
compañero/a.

- Buscador -> Introduce una preferencia y busca usuarios con esa misma preferencia, en la cual se podrá seleccionar el usuario.

Listado de EN públicas:

- ENCategoría-> Tipo de plan, coste simbolizado de 1 a 3 €(cuantas menos símbolos más barato
es el plan), apertura, cierre...

- ENUsuario -> Usuarios que se expondrán públicamente al particular con los que podrá
interactuar según su preferencia y horario de disponibilidad.

# Parte privada:

- Selección de plan -> El usuario podrá elegir entre uno de los candidatos.

- Lista de favoritos -> Personas con las que volverías a quedar o te han llamado la atención.

- Historial -> Historial de planes que has hecho (Aquí se seleccionan los favoritos).

- Modificar tu perfil -> Cambiar tus datos personales.

- Cambiar disponibilidad.

Listado de EN privadas:

- ENBuscador-> Hace el proceso de búsquedad del usuario con preferencia y horario común. 

- ENParejas-> Guadará las parejas con sus nombres(nombre de usuario), sus planes y la hora.

- ENParticular-> El particular tiene la opción de elegir una pareja u otra según su búsqueda o su
lista de favoritos. Se encargará de gestionar la información del usuario conectándose con ENHistorial y ENBuscador.

- ENPlanes -> Se incargará de introducir, modificar y eliminar nuevos planes.

- ENHistorial -> Gestionará la información de favoritos y el historial de los usuarios.

Posibles mejoras:
- Web scraping para los usuarios en el cual no hayan planes en su ciudad.
- Horario de disponibilidad en formato agenda (Solo semanal).
