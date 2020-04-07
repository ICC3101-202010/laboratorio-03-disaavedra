using System;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
            String variable;

            Proveedor proveedor1 = new Proveedor();

            Supervisor supervisor1 = new Supervisor();

            Auxiliar auxiliar1 = new Auxiliar();

            Cajero cajero1 = new Cajero();

            Compra compra1 = new Compra();

            TodoTrabajadores todoTrabajadores = new TodoTrabajadores();

            Console.WriteLine("Bienvenido a Smart-ket!\n");

            while (true)
            {
                Console.WriteLine("Presiona [n] para ingresar");

                variable = Console.ReadLine();

                if (variable == "n")

                    break;

                else

                    continue;
            }

            while (true)
            {
                String tipo;

                String puestoTrabajo, eleccionIngreso;

                Console.WriteLine("\nDesea ingresar al Menu de:" +
                                  "\n[1] Proveedor" +
                                  "\n[2] Trabajador" +
                                  "\n[3] Cliente" +
                                  "\n[4] Informacion funcionamiento" +
                                  "\n[5] Terminar Programa");

                tipo = Console.ReadLine();

                if (tipo == "5")
                {
                    break;
                }

                switch (tipo)
                {
                    case "1": //Proveedor

                        String nombreProducto, nombreProveedor, precioProducto, stockProducto;

                        String seleccion;

                        Console.WriteLine("Ingrese nombre de proveedor/marca: ");

                        nombreProveedor = Console.ReadLine();

                        while (true)
                        {
                            Console.WriteLine("\nSeleccione tipo de producto que desea ingresar:" +
                                    "\n[1] Dulces" +
                                    "\n[2] Lacteos" +
                                    "\n[3] Carnes" +
                                    "\n[4] Verduras" +
                                    "\n[5] Frutas" +
                                    "\n[6] Carbohidratos" +
                                    "\n[7] Limpieza" +
                                    "\n[8] Salir");

                            seleccion = Console.ReadLine();

                            if (seleccion == "8")
                            {
                                break;
                            }

                            switch (seleccion)
                            {
                                case "1":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto dulces = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(dulces);

                                    break;

                                case "2":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto lacteos = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(lacteos);

                                    break;

                                case "3":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto carnes = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(carnes);

                                    break;

                                case "4":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto verduras = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(verduras);

                                    break;

                                case "5":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto frutas = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(frutas);

                                    break;

                                case "6":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto carbohidratos = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(carbohidratos);

                                    break;

                                case "7":

                                    Console.WriteLine("Nombre Producto:");

                                    nombreProducto = Console.ReadLine();

                                    Console.WriteLine("Precio Producto:");

                                    precioProducto = Console.ReadLine();

                                    Console.WriteLine("Stock Producto:");

                                    stockProducto = Console.ReadLine();

                                    Producto limpieza = new Producto(nombreProducto, nombreProveedor, precioProducto, stockProducto);

                                    proveedor1.metodoDulces(limpieza);

                                    break;

                            }
                        }

                        break;

                    case "2": //Trabajador

                        Console.WriteLine("Presione [1] si desea agregar a un trabajador");

                        Console.WriteLine("Presione [2] si desea conocer a nuestros trabajadores");

                        Console.WriteLine("Presione [3] si desea salir");

                        eleccionIngreso = Console.ReadLine();

                        switch (eleccionIngreso)
                        {
                            case "1": //Agregar trabajador

                                String rut, nombre, apellido, nacimiento, nacionalidad;

                                String puesto, sueldo, horario;

                                Console.WriteLine("Ingrese sus datos:");

                                Console.WriteLine("RUT:");

                                rut = Console.ReadLine();

                                Console.WriteLine("Nombre:");

                                nombre = Console.ReadLine();

                                Console.WriteLine("Apellido:");

                                apellido = Console.ReadLine();

                                Console.WriteLine("Nacimiento:");

                                nacimiento = Console.ReadLine();

                                Console.WriteLine("Nacionalidad:");

                                nacionalidad = Console.ReadLine();

                                Console.WriteLine("Puesto:");

                                puesto = Console.ReadLine();

                                Console.WriteLine("Sueldo:");

                                sueldo = Console.ReadLine();

                                Console.WriteLine("Horario:");

                                horario = Console.ReadLine();

                                switch (puesto)
                                {
                                    case "supervisor":

                                        Trabajador trabajador1 = new Trabajador(rut, nombre, apellido, nacimiento, nacionalidad);

                                        trabajador1.DatosTrabajo(puesto, sueldo, horario);

                                        supervisor1.DatosPersonalesSupervisor(trabajador1);

                                        supervisor1.DatosProfesionalesSupervisor(trabajador1);

                                        todoTrabajadores.ListaTrabajadores(trabajador1);

                                        break;

                                    case "auxiliar":

                                        Trabajador trabajador2 = new Trabajador(rut, nombre, apellido, nacimiento, nacionalidad);

                                        trabajador2.DatosTrabajo(puesto, sueldo, horario);

                                        auxiliar1.DatosPersonalesAuxiliar(trabajador2);

                                        auxiliar1.DatosProfesionalesAuxiliar(trabajador2);

                                        todoTrabajadores.ListaTrabajadores(trabajador2);

                                        break;

                                    case "cajero":

                                        Trabajador trabajador3 = new Trabajador(rut, nombre, apellido, nacimiento, nacionalidad);

                                        trabajador3.DatosTrabajo(puesto, sueldo, horario);

                                        cajero1.DatosPersonalesAuxiliar(trabajador3);

                                        cajero1.DatosProfesionalesAuxiliar(trabajador3);

                                        todoTrabajadores.ListaTrabajadores(trabajador3);

                                        break;

                                    case "reponedor":

                                        break;

                                    case "bodeguero":
    
                                        break;

                                    case "empaquetador":

                                        break;

                                    case "guardia":

                                        break;
                                }

                                break;

                            case "2":

                                Console.WriteLine("\nElige un opcion:\n" +
                                                          "\n[1] Jefe" +
                                                          "\n[2] Supervisor" +
                                                          "\n[3] Auxiliar" +
                                                          "\n[4] Cajero" +
                                                          "\n[5] Reponedor (proximamente)" +
                                                          "\n[6] Bodeguero (proximamente)" +
                                                          "\n[7] Empaquetador (proximamente)" +
                                                          "\n[8] Guardia (proximamente)");

                                puestoTrabajo = Console.ReadLine();

                                switch (puestoTrabajo)
                                {
                                    case "1":
                                        String conocerJefe;

                                        Console.WriteLine("\nElige un opcion ingresando 1 o 2\n" +
                                                          "\n[1] Conocer Jefe" +
                                                          "\n[2] Hacer una accion del Jefe");

                                        Jefe jefe1 = new Jefe("20075160-4", "Daniel", "Saavedra", "5 de abril", "Chile");

                                        jefe1.DatosTrabajo("Jefe", "2000000", "9:00 / 18:00");

                                        conocerJefe = Console.ReadLine();

                                        switch (conocerJefe)
                                        { 
                                            case "1":

                                                Console.WriteLine("\nCargo: " + jefe1.rut + "\nNombre: " + jefe1.nombre + "\nApellido: " + jefe1.apellido + "\nNacimiento: " + jefe1.nacimiento + "\nNacionalidad: " + jefe1.nacionalidad);

                                                Console.WriteLine("\nCargo: " + jefe1.puesto + "\nSueldo: " + jefe1.sueldo + "\nHorario: " + jefe1.horario);

                                                break;

                                            case "2":

                                                while(true)
                                                {
                                                    String eleccion;

                                                    Console.WriteLine("\nElige un opcion ingresando 1, 2 o 3\n" +
                                                                      "\n[1] Cambio trabajo" +
                                                                      "\n[2] Cambio Sueldo" +
                                                                      "\n[3] Cambio Horario");

                                                    eleccion = Console.ReadLine();

                                                    switch (eleccion)
                                                    {
                                                        case "1":

                                                            String eleccion1;

                                                            Console.WriteLine("\nElige a quien cambiar de trabajo:\n" +
                                                                              "\n[1] Jefe" +
                                                                              "\n[2] Supervisor" +
                                                                              "\n[3] Auxiliar" +
                                                                              "\n[4] Cajero");

                                                            eleccion1 = Console.ReadLine();

                                                            switch(eleccion1)
                                                            {
                                                                 case "1":

                                                                     break;

                                                                 case "2":

                                                                     break;

                                                                 case "3":

                                                                      break;

                                                                 case "4":

                                                                       break;
                                                            }

                                                            break;

                                                        case "2":

                                                            Console.WriteLine("\nElige a quien cambiar su sueldo:\n" +
                                                                              "\n[1] Supervisor" +
                                                                              "\n[2] Auxiliar" +
                                                                              "\n[3] Cajero");

                                                            eleccion1 = Console.ReadLine();

                                                            switch (eleccion1)
                                                            {
                                                                case "1":

                                                                    break;

                                                                case "2":

                                                                    break;

                                                                case "3":

                                                                    break;

                                                                case "4":

                                                                    break;
                                                            }

                                                            break;

                                                        case "3":

                                                            Console.WriteLine("\nElige a quien cambiar su horario:\n" +
                                                                              "\n[2] Supervisor" +
                                                                              "\n[3] Auxiliar" +
                                                                              "\n[4] Cajero");

                                                            eleccion1 = Console.ReadLine();

                                                            switch (eleccion1)
                                                            {
                                                                case "1":

                                                                    break;

                                                                case "2":

                                                                    break;

                                                                case "3":

                                                                    break;

                                                                case "4":

                                                                    break;
                                                            }

                                                            break;
                                                    }

                                                    break;
                                                }

                                                break;
                                        }

                                        break;

                                    case "2":

                                        String conocerSupervisor;

                                        Console.WriteLine("\nElige un opcion ingresando 1 o 2\n" +
                                                          "\n[1] Conocer Supervisores" +
                                                          "\n[2] Hacer una accion del Supervisor");

                                        conocerSupervisor = Console.ReadLine();

                                        switch (conocerSupervisor)
                                        {
                                            case "1":
                                                
                                                supervisor1.informacionSupervisores();

                                                break;

                                            case "2":

                                                break;
                                        }

                                        break;

                                    case "3":

                                        String conocerAuxiliar;

                                        Console.WriteLine("\nElige un opcion ingresando 1 o 2\n" +
                                                          "\n[1] Conocer Auxiliares" +
                                                          "\n[2] Hacer una accion del Auxiliar");

                                        conocerAuxiliar = Console.ReadLine();

                                        switch (conocerAuxiliar)
                                        {
                                            case "1":

                                                auxiliar1.informacionAuxiliar();

                                                break;

                                            case "2":

                                                break;
                                        }

                                        break;

                                    case "4": //Cajero

                                        String conocerCajero;

                                        Console.WriteLine("\nElige un opcion ingresando 1 o 2\n" +
                                                          "\n[1] Conocer Cajeros" +
                                                          "\n[2] Hacer una accion del Cajero");

                                        conocerCajero = Console.ReadLine();

                                        switch (conocerCajero)
                                        {
                                            case "1":

                                                cajero1.informacionCajero();

                                                break;

                                            case "2":

                                                break;
                                        }

                                        break;

                                    case "5": //Reponedor

                                        break;

                                    case "6": //Bodeguero

                                        break;

                                    case "7": //Empaquetador

                                        break;

                                    case "8": //Guardia

                                        break;
                                }

                                break;

                            case "3":

                                Console.WriteLine("Saliendo de Smart-ket");

                                break;
                        }

                        break;

                    case "3":

                        String rutCliente, nombreCliente, apellidoCliente, nacimientoCliente, nacionalidadCliente;

                        Console.WriteLine("Ingrese sus datos:");

                        Console.WriteLine("RUT:");

                        rutCliente = Console.ReadLine();

                        Console.WriteLine("Nombre:");

                        nombreCliente = Console.ReadLine();

                        Console.WriteLine("Apellido:");

                        apellidoCliente = Console.ReadLine();

                        Console.WriteLine("Nacimiento:");

                        nacimientoCliente = Console.ReadLine();

                        Console.WriteLine("Nacionalidad:");

                        nacionalidadCliente = Console.ReadLine();

                        Cliente personaCliente = new Cliente(rutCliente, nombreCliente, apellidoCliente, nacimientoCliente, nacionalidadCliente);

                        while(true)
                        {
                            String eleccionCliente;

                            Console.WriteLine("\nSeleccione tipo de producto que desea ingresar:" +
                                        "\n[1] Comprar Productos" +
                                        "\n[2] Ver carro de compras" +
                                        "\n[3] Pagar productos" +
                                        "\n[4] Salir");

                            eleccionCliente = Console.ReadLine();

                            if (eleccionCliente == "4")
                            {
                                break;
                            }

                                switch (eleccionCliente)
                                {
                                    case "1":

                                        String eleccionCompras;

                                        int eleccionProductos;

                                        Console.WriteLine("\nSeleccione tipo de producto que desea ingresar:" +
                                            "\n[1] Dulces" +
                                            "\n[2] Lacteos" +
                                            "\n[3] Carnes" +
                                            "\n[4] Verduras" +
                                            "\n[5] Frutas" +
                                            "\n[6] Carbohidratos" +
                                            "\n[7] Limpieza" +
                                            "\n[8] Salir");

                                        eleccionCompras = Console.ReadLine();

                                        if (eleccionCompras == "8")
                                        {
                                            break;
                                        }

                                        switch (eleccionCompras)
                                        {
                                            case "1":

                                            String producto = "Dulces";

                                            proveedor1.informacionDulces();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto, eleccionProductos);

                                            break;

                                            case "2":

                                            String producto1 = "Lacteos";

                                            proveedor1.informacionLacteos();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto1, eleccionProductos);

                                            break;

                                            case "3":

                                            String producto2 = "Carnes";

                                            proveedor1.informacionCarnes();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto2, eleccionProductos);

                                            break;

                                            case "4":

                                            String producto3 = "Verduras";

                                            proveedor1.informacionVerduras();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto3, eleccionProductos);

                                            break;

                                            case "5":

                                            String producto4 = "Frutas";

                                            proveedor1.informacionFrutas();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto4, eleccionProductos);

                                            break;

                                            case "6":

                                            String producto5 = "Carbohidratos";

                                            proveedor1.informacionCarbohidratos();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto5, eleccionProductos);

                                            break;

                                            case "7":

                                            String producto6 = "Limpieza";

                                            proveedor1.informacionLimpieza();

                                            Console.WriteLine("Elija su Producto");

                                            eleccionProductos = int.Parse(Console.ReadLine());

                                            compra1.AgregarAlCarro(proveedor1, producto6, eleccionProductos);

                                            break;

                                    }

                                    break;

                                    case "2":

                                        break;

                                    case "3":

                                        break;
                                }

                            
                        }

                        break;

                    case "4":

                        Console.WriteLine("En el Menu 'Trabajadores' existe la posibilidad de crear mas Trabajadores");

                        Console.WriteLine("En el Menu 'Trabajadores' existe la posibilidad de ver a los Trabajadores una vez ya creados");

                        Console.WriteLine("El Jefe viene prederterminado");

                        Console.WriteLine("En el Menu 'Proveedores' existe la facultad de crear productos dependiendo de su tipo");

                        Console.WriteLine("En la clase Producto se pueden crear los productos");

                        Console.WriteLine("La clase Compra almacena las compras de la clase Cliente");

                        Console.WriteLine("La clase Proveedor almacena los productos creados en la clase Producto");

                        Console.WriteLine("La clase Supervisor, Auxiliar y Cajero crean Trabajadores y los almacenan en sus respectivos trabajos");

                        Console.WriteLine("La clase TodoTrabajadores tiene los metodos para cambiar de puesto de trabajo ademas de cambiar el sueldo y horario de los trabajadores");

                        break;

                }
            }

            static void Simulacion()
            {
                //
            }

        }
    }
}
