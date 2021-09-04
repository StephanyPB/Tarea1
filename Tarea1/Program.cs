using System;

namespace Tarea1
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;
            while(op != 4 )
            {
                Console.Clear();
                Console.WriteLine("Elija una opcion \n 1-Capitulo 1. \n 2-Capitulo 2. \n 3-Capitulo 3. \n 4-Salir ");
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (op)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Capitulo 1 :)\n");
                        Console.WriteLine("Elija una opcion \n 1-Ejercicio 1 \n 5-Ejercicio 5. \n 6-Salir ");
                        int opcion = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (opcion == 1)
                        {
                            Console.Clear();
                            Cap1Ejercicio1();
                        }
                        else if (opcion == 5)
                        {
                            Console.Clear();
                           
                            Cap1Ejercicio5();
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("Capitulo 2 :)\n");
                        Console.WriteLine("Elija una opcion \n\n 1-Ejercicio 1 \n 3-Ejercicio 3. \n 4-Ejercicio 4. \n  5-Ejercicio 5.\n 6-Salir ");
                        int opc = int.Parse(Console.ReadLine());
                        Console.Clear();
                        if (opc == 1)
                        {
                            Console.Clear();
                            Cap2Ejercicio1();

                        }
                        else if (opc == 3)
                        {
                            Console.Clear();
                            Cap2Ejercicio3();

                        }
                        else if (opc == 4)
                        {
                            Console.Clear();
                            Cap2Ejercicio4();

                        }
                        else if (opc == 5)
                        {
                            Console.Clear();
                            Cap2Ejercicio5();
                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("Capitulo 3 :)\n");
                        Console.WriteLine("Elija una opcion \n\n 1-Ejercicio 1 \n 4-Ejercicio 4. \n  5-Salir ");
                        int opci = int.Parse(Console.ReadLine());
                        if (opci == 1)
                        {
                            Console.Clear();
                            Cap3Ejercicio1();

                        }
                        else if (opci == 4)
                        {
                            Console.Clear();
                            Cap3Ejercicio4();
                        }
                        break;
                    default:
                        return;
                }
            }
            
        } 
       public static void Cap1Ejercicio1()
       {
            
            Console.WriteLine("Capitulo 1 :) \n\n Ejercicio 1: Cree un proyecto nuevo que imprima su nombre en la ventana de la consola\n");
            Console.WriteLine("Stephany Paulino Balbi :) \n");
            Console.ReadKey();
       } 
        public static void Cap1Ejercicio5()
        {
            
            Console.WriteLine("Capitulo 1 :) \n\n Ejercicio 5: Agregue más mensajes a la aplicación que ha creado. \n");
            Console.WriteLine("Stephany Paulino Balbi :) \n");
            Console.WriteLine("Provincia Duarte: San francisco de Macoris \n Edad: 19 years \n");
            Console.ReadKey();   
        }
        public static void Cap2Ejercicio1()
        {
            
            Console.WriteLine("Capitulo 2 :) \n\n Ejercicio 1:  Hacer un programa que calcule el perímetro de cualquier polígono regular \n");
            Console.WriteLine("Digite la cantidad de lados del poligono regular. ");
            int lado = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite la longitud del poligono regular. ");
            float longitud = float.Parse(Console.ReadLine());

            float perimetro = lado * longitud;
            Console.WriteLine("El Valor del poligono regular. "+perimetro);
            Console.ReadKey();
        }
        public static void Cap2Ejercicio3()
        {
            
            Console.WriteLine("Capitulo 2 :) \n\n Ejercicio 3: Hacer un programa que transforme de grados a radianes. \n");
            Console.WriteLine("Digite el valor de grados a convertir. ");
            float grados = int.Parse(Console.ReadLine());
            double radianes = (grados * (3.1416 / 180));
            double redondear = Math.Round((Double)radianes, 3);
            Console.WriteLine("Grados en Radianes es: " + redondear + " ");
            Console.ReadKey();
        }

        public static void Cap2Ejercicio4()
        {
           
            Console.WriteLine("Capitulo 2 :) \n\n Ejercicio 4: Hacer un programa que transforme de grados centígrados a grados Fahrenheit. \n");
            Console.WriteLine("Digite el valor de los grados centrigrados. ");
            float grados = float.Parse(Console.ReadLine());
            float fahrenheit = ((grados * 9/5) + 32);

            Console.WriteLine("El Valor en Fahrenheit: " +fahrenheit);
            Console.ReadKey();
        }

        public static void Cap2Ejercicio5()
        {
           
            Console.WriteLine("Capitulo 2 :)\n\n Ejercicio 5:   Hacer un programa que transforme entre dólares y euros y que también pida el tipo de cambio del día \n\nElija una opcion\n ");
            
            Console.WriteLine(" 1-Quiere cambiar de dolares a euros \n\n 2-Quiere cambiar de euros a dolares  \n\n3-Salir ");
            int eleccion = int.Parse(Console.ReadLine());
            Console.Clear();
            if (eleccion == 1){
                Console.Clear();
                Console.WriteLine("Digite la tasa que esta el dolar respecto al euro ");
                float tasaD = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite la cantidad de dolares a cambiar a euros");
                int dolares = int.Parse(Console.ReadLine());
                double cambioD = dolares * tasaD;
                
                Console.WriteLine(dolares + " a euros es " + cambioD);
                Console.WriteLine(" Tasa que esta el dolar respecto al euro " + tasaD);
                Console.ReadKey();
            }
            else if (eleccion == 2) {
                Console.Clear();
                Console.WriteLine("Digite la tasa que esta el euro respecto al dolar ");
                float tasaE = float.Parse(Console.ReadLine());

                Console.WriteLine("Digite la cantidad de euros a cambiar a dolares");
                int euros = int.Parse(Console.ReadLine());
                double cambioE = euros * tasaE;
                
                Console.WriteLine(euros + " a euros es " + cambioE);
                Console.WriteLine(" Tasa que esta el euro  respecto al dolar " + tasaE);
                Console.ReadKey();
            }
        }

        public static void Cap3Ejercicio1()
        {
            
            Console.WriteLine("Capitulo 3 :)\n\n Ejercicio 1:  Hacer un programa que le pida al usuario un número y la computadora responda si es par o impar \n");
            Console.WriteLine("Digite un numero ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0) 
                Console.WriteLine("El numero " + numero + " es par ");
            else
                Console.WriteLine("El numero " + numero + " es impar ");
            Console.ReadKey();
        }

        public static void Cap3Ejercicio4()
        {
            
            Console.WriteLine("Capitulo 3 :) \n\n Ejercicio 4:  Hacer un programa que le pida al usuario un número del 1 al 7 y" +
                " escriba el nombre del día que corresponde ese número en la semana.\n");

            Console.WriteLine("Digite un numero del 1 al 7 ");
            int dia = Int32.Parse(Console.ReadLine());
            switch (dia)
            {
                case 1:
                    Console.WriteLine("Lunes ");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Martes ");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Miercoles ");
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Jueves ");
                    Console.ReadKey();
                    break;
                case 5:
                    Console.WriteLine("Viernes ");
                    Console.ReadKey();
                    break;
                case 6:
                    Console.WriteLine("Sabado ");
                    Console.ReadKey();
                    break;
                case 7:
                    Console.WriteLine("Domingo ");
                    Console.ReadKey();
                    break;
                default:
                    return;
            }
            
        }
    }
}
