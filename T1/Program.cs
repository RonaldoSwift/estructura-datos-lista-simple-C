using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using T1;

class Principal
{
    static List<Nodo> ListaSimple = new List<Nodo>();

    static void Main()
    {

        int opcion;
        do
        {
            Console.WriteLine("\n\n************************************************");
            Console.WriteLine("*                 MENU DE OPCIONES             *");
            Console.WriteLine("************************************************");
            Console.WriteLine("*      1)Agregar Nodo                          *");
            Console.WriteLine("*      2)Mostrar todos los Nodos               *");
            Console.WriteLine("*      3)Ordenar Nodo (De forma ascendente)    *");
            Console.WriteLine("*      4)Eliminar Nodo                         *");
            Console.WriteLine("************************************************");
            Console.WriteLine("\nElija una opcion: ");
            opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    agregarNodo();
                    break;
                case 2:
                    mostrarListaDeNodos();
                    break;
                case 3:
                    ordenarListaDeNodo();
                    break;
                case 4:
                    eliminarNodo();
                    break;
                default :
                    Console.WriteLine("El numero Ingresado es incorrecto...");
                    break;
            }
        } while (opcion != 0);
    }


    static void agregarNodo()
    {
        Nodo nodo = new Nodo();
        Console.Clear();
        Console.WriteLine("  AGREGANDO ESTUDIANTE");
        Console.WriteLine("Ingrese Nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Codigo de Estudiante: ");

        string codigoString = Console.ReadLine();
        int codigoNumero = obtenerCodigo(codigoString);

        Console.WriteLine("Ingrese Correo: ");
        string correo = Console.ReadLine();
        Estudiante estudiante = new Estudiante(codigoNumero, nombre, correo);
        nodo.Dato = estudiante;
        ListaSimple.Add(nodo);
        Console.WriteLine("El Nodo ha sido Ingresado a la Lista");
        Console.ReadKey();
    }

    static void mostrarListaDeNodos()
    {
        Console.Clear();
        Console.WriteLine("     MOSTRANDO LISTA DE ESTUDIANTES     ");
        foreach (Nodo nodo in ListaSimple) 
        {
            Console.WriteLine("\nNombre: " + nodo.Dato.nombre);
            Console.WriteLine("Codigo: N00" + nodo.Dato.codigo);
            Console.WriteLine("Correo: " + nodo.Dato.correo);
        }
        Console.WriteLine("\n Cantidad De Nodos en la lista: " + ListaSimple.Count);
    }

    static void ordenarListaDeNodo()
    {
        Console.Clear();
        Console.WriteLine("ORDENANDO LOS NODOS");
        ListaSimple.Sort();
        Console.WriteLine("Lista Simple Generica Ordenada Ascendentemente");
        Console.ReadKey();
    }

    static void eliminarNodo()
    {
        Nodo nodo = new Nodo();
        Console.Clear();
        Console.WriteLine("   Eliminar Nodo   ");
        Console.WriteLine("Ingrese Nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("Ingrese Codigo de Estudiante: ");
        string codigoString = Console.ReadLine();
        int codigoNumero = obtenerCodigo(codigoString);



        Console.WriteLine("Ingrese Correo: ");
        string correo = Console.ReadLine();
        Estudiante estudiante = new Estudiante(codigoNumero, nombre, correo);
        nodo.Dato = estudiante;
        bool estaEliminado = ListaSimple.Remove(nodo);
        if (estaEliminado)
        {
            Console.WriteLine("Estudiante Eliminado");
        }
        else
        {
            Console.WriteLine("El estudiante no ha sido Eliminado");
        }
        Console.ReadKey();
    }


    //Funcion para Obtener el Codigo Ingresado
    private static int obtenerCodigo(string codigostring )
    {
        int position = codigostring.IndexOf("N00");
        int codigonumero = int.Parse(codigostring.Substring(position + 1));
        return codigonumero;
    }
}


//N00211840 -> VARGAS HUAMAN RONALDO ANDRE
