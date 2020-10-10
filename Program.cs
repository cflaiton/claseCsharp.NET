using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace TallerActividad1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("                                 [Bienvenido al taller numero 1]");
            
            Console.WriteLine(" 1.Leer un número por teclado y definir si es par o impar ");
            Console.WriteLine(" 2.Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10");
            Console.WriteLine(" 3.Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10 ");
            Console.WriteLine(" 4.Leer un número por teclado y definir si es primo o no");
            Console.WriteLine(" 5.Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente");
            Console.WriteLine(" 6. Datos los vectores");
                //edad = [12, 50, 23, 10, 18, 35, 41, 85, 16, 45] nombre = ["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                //Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                //que el nombre no existe ");
            Console.WriteLine(" 7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad.");
            Console.WriteLine(" 8. Dado una palabra definir si es palíndromo o no.");
            Console.WriteLine(" 9. Salir del programa");
            Console.WriteLine("Porfavor seleccione el ejercicio");

            int a = Convert.ToInt32(Console.ReadLine());

            switch (a)
            {
                case 1:
                    Console.Clear();
                    Console.WriteLine(" 1.Leer un número por teclado y definir si es par o impar ");
                    Console.WriteLine("Porfavor digite un numero");
                    int n1 =Convert.ToInt32(Console.ReadLine());

                    int resto = n1 % 2;

                    Console.WriteLine(resto);

                    if (resto == 0)
                    {
                        Console.WriteLine("Este numero es Par");
                    }
                    else
                    {
                        Console.WriteLine("Este numero es impar");
                    }



                    Console.ReadKey();
                    break;

                case 2:
                    Console.Clear();
                    Console.WriteLine(" 2.Leer un número por teclado y generar las Tabla de multiplicar de ese número del 1 al 10");
                    int n2 = Convert.ToInt32( Console.ReadLine());

                    for (int i = 1; i < 11; i++)
                    {
                        int t2 = i * n2;

                        Console.WriteLine(n2 +  " * " + i + " = " + t2 );

                    }

                    Console.ReadKey();
                    break;

                case 3:
                    Console.Clear();
                    Console.WriteLine(" 3.Generar las tablas de multiplicar del 2 al 9, cada una del 1 al 10 ");

                    for (int i = 1; i < 11; i++)
                    {
                        for (int j = 0; j < 11; j++)
                        {

                            int t3 = i * j;

                            Console.WriteLine(i + " * " + j + " = " + t3);
                        }
                        Console.WriteLine( " ");
                    }


                    Console.ReadKey();
                    break;

                case 4:
                    Console.Clear();
                    Console.WriteLine(" 4.Leer un número por teclado y definir si es primo o no");
                    double n4 = Convert.ToInt32(Console.ReadLine());
                    double raiz = Math.Sqrt(n4);
                    double b ;
                    int cont = 0;
                    for (int i = 1; i <= n4; i++)
                    {
                         b = n4 % i;
                        Console.WriteLine("El numero " + n4 +  " Dividido en " + i + " Es igual a " + b);

                        if (b == 0)
                        {
                            cont = cont + 1;
                            if (cont == 2)
                            {
                                Console.WriteLine("Primo");
                            }
                            else
                            {
                                Console.WriteLine("No es primo");
                            }

                        }
                    }
                    



                    Console.ReadKey();
                    break;

                case 5:
                    Console.Clear();
                    Console.WriteLine(" 5.Dado el vector edad = [12,50,23,10,18,35,41,85,16,45], ordenarlos en forma ascendiente");

                    int[] edad = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };

                    Array.Sort(edad);

                    foreach (var item in edad)
                    {
                        
                        Console.WriteLine(item);
                    }


                    Console.ReadKey();
                    break;

                case 6:
                    Console.Clear();
                    Console.WriteLine(" 6. Datos los vectores");
                    Console.WriteLine("juan,maria,tereza,pedro,javier,ana,diana,jorge,dayana,lady");         //["juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady"]
                    //Leer un nombre por teclado y definir si existe, y en caso de existir mostrar su edad de lo contrario un mensaje
                    //que el nombre no existe ");
                    

                    int [] edades = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                    string[] nombre = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

                    Console.WriteLine("Porfavor escriba uno de los siguientes nombres");
                    string n6 = Console.ReadLine();

                    for (int i = 0; i < nombre.Length; i++)
                    {
                        if (n6==nombre[i])
                        {
                            Console.WriteLine("Su nombre es " + nombre[i]);

                            Console.WriteLine("Tiene " + edades[i] + " Años");

                        }
                        else
                        {
                            Console.WriteLine( "Nombre no existe, ¡Buen dia!");
                        }
                        
                    }

                    Console.ReadKey();

                    break;

                case 7:
                    //Console.Clear();
                    //Console.WriteLine(" 7. Partiendo de los vectores anteriores buscar el menor y el mayor y presentar sus respectivos nombres con su edad.");

                    //int[] edades1 = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                    //string[] nombre1 = { "juan", "maria", "tereza", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };

                    ////Array.Sort(edades1);
                    ////Array.Sort(nombre1);

                    //for (int i = 0; i < edades1.Length; i++)
                    //{
                    //    Console.WriteLine("Su nombre es " + nombre1[i] + "   y tiene " + edades1[i] + "  Años");

                    //}



                    //Console.Write("\n\nEl numero mayor es: " + edades1.Max());
                    //Console.Write("\n\nEl numero menor es: " + edades1.Min());
                    //Console.ReadKey();




                    Console.WriteLine("Buscar Usuario y mostrar su edad");

                    int[] edad7 = { 12, 50, 23, 10, 18, 35, 41, 85, 16, 45 };
                    string[] nombres7 = { "juan", "maria", "teresa", "pedro", "javier", "ana", "diana", "jorge", "dayana", "lady" };
                    string NombreBuscar;

                    /* definir dos variables */
                    Boolean existe = false; /* me a decir si el ususario exisete */
                    int indice = 0;  /* guardare el valor de la posicion del arreglo  donde existe el usasrio */

                    int indiceMayor = 0;
                    int edadMayor = 0;

                    int indiceMenor = 0;
                    int edadMenor = 100;

                    Console.WriteLine(" - muestra el array de nombre");

                    foreach (string nombre7 in nombres7)
                    {
                        Console.Write(nombre7 + " - ");
                    }

                    Console.Write("\n");

                    /*   leer el nombre a buscar */
                    Console.Write("Digite el nombre a buscar: ");
                    NombreBuscar = Console.ReadLine();



                    /*  recorra el vector y me diga si existe y la posiscion */
                    //for (int i = 0; i < nombres7.Length; i++)
                    //{

                    //    // - busco el nombre
                    //    if (NombreBuscar == nombres7[i])
                    //    {
                    //        existe = true;
                    //        indice = i;
                    //    }
                    //    // comparo las edades 
                    //    if (edad7[i] > edadMayor)
                    //    {
                    //        edadMayor = edad7[i];
                    //        indiceMayor = i;
                    //    }


                    //}

                      //buscar el mayot el array edad*/
                    for (int i = 0; i < edad7.Length; i++)
                    {
                        if (edad7[i] > edadMayor)
                        {
                            edadMayor = edad7[i];
                            indiceMayor = i;
                        }
                    }

                    // Se inicializo con un valor elevado para que fuera del mayor al menor
                    for (int i = 0; i < edad7.Length; i++)
                    {
                        if (edad7[i] < edadMenor)
                        {
                            edadMenor = edad7[i];
                            indiceMenor = i;

                        }
                    }


                    //mostrar quien es el mayor 

                    Console.WriteLine("El Mayor es " + nombres7[indiceMayor] + " y su edad es  " + edad7[indiceMayor]);
                    Console.WriteLine("El menor es " + nombres7[indiceMenor] + " y su edad es  " + edad7[indiceMenor]);

                    ///* validad si existe el usuario 
                    if (existe)
                        Console.WriteLine(" El usuario " + NombreBuscar + " tiene " + edad7[indice]);
                    else
                    Console.ReadKey();

                    break;

                case 8:
                    Console.Clear();
                    Console.WriteLine(" 8. Dado una palabra definir si es palíndromo o no.");
                    Console.WriteLine("\n");


                    string palabra1;
                    string palabra2= "";
                    string n8;
                    Console.WriteLine("Porfavor escribir una palabra");         // Se solicita palabra
                    palabra1 = Console.ReadLine();                              // Se guarda en variable
                    int cantidadp = palabra1.Length;                            // Cantidad de letras de la palabra guardada
                    for (int w = cantidadp - 1; w >= 0; w--)                    // For que empiece desde la cantidad guardada hasta cero de menos en menos 
                    {

                        n8 = palabra1.Substring(w, 1);                          //Se guarda con substring la subcade
                        palabra2 = palabra2 + n8;                               //Esta se guarda en otra variable
                    }

                    Console.Write("\n El escrito invertido es : " + palabra2);  //Se muestra la pabra invertida
                    if (palabra1.Equals(palabra2))                              //Se comprueba con un if
                    {
                        Console.WriteLine("\n Palindrome");
                    }
                    else
                    {
                        Console.WriteLine("\nNo es palindrome");
                    }

                    Console.ReadKey();                                          
                    break;
                case 9:

                    Console.WriteLine("Gracias por utilizar nuestro sistema ¡Feliz Dia!");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Gracias por utilizar nuestro sistema ¡Feliz Dia!");
                    Console.ReadKey();
                    break;
                    
            }
        }
    }
}
