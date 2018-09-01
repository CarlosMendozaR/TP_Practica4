using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main()
        { //Conoceremos una calculadora y se dara una demostración//
            #region Actividad 1 
            Console.WriteLine("Ingrese el color de su calculadora");
            string color = Console.ReadLine();
            Console.WriteLine("Ingrese la marca de su preferencia");
            string marca = Console.ReadLine();
            Calc Micalc = new Calc(marca, color);
            Calc LaCalc = new Calc();
            Console.WriteLine("Cuantas teclas extras quiere agregar");
            int teclas = int.Parse(Console.ReadLine());

            Calc Mcalc = new Calc(teclas);

            Console.WriteLine("Ahora una demostración de el manejo de potencias");
            #endregion
            #region ACTIVIDAD 2
            Console.WriteLine("**Todos los números en base 10**");
            Console.WriteLine("Ingresa el exponente al que deseas elevar tres números (exclusivamente del 1-5 por ser una demostracion)");
            byte exp = byte.Parse(Console.ReadLine());
            if (exp < 1 || exp > 5)
            {
                Console.WriteLine("No es correcto, se hara la demostracion con exponente = 5");
                exp = 5;
            }

            NCientifica n1 = new NCientifica(3, 7);
            NCientifica n2 = new NCientifica(32, -1);
            NCientifica n3 = new NCientifica(2, 3);
            NCientifica n4 = new NCientifica(11, 9);

            NCientifica n5 = n1 * n2;
            NCientifica n6 = n1 ^ exp;
            Console.WriteLine("\nEjemplo uno:\n{0} * {1} = {2}", n1, n2, n5);
            Console.WriteLine("{0} ^ {1} = {2}", n1, exp, n6);

            NCientifica n7 = n3 * n4;
            NCientifica n8 = n3 ^ exp;
            Console.WriteLine("\nEjemplo dos:\n{0} * {1} = {2}", n3, n4, n7);
            Console.WriteLine("{0} ^ {1} = {2}", n3, exp, n8);

            NCientifica n9 = n8 * n3;
            NCientifica n0 = n8 ^ exp;
            Console.WriteLine("\nEjemplo dos:\n{0} * {1} = {2}", n8, n3, n9);
            Console.WriteLine("{0} ^ {1} = {2}", n8, exp, n0);
            #endregion

            Console.ReadLine();

        }
    }
}
