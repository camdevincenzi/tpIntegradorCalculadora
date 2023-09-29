using Entidades;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test 1, suma entre dos binarios
            Numeracion num1 = new Numeracion(Numeracion.ESistema.Binario, "1111");
            Numeracion num2 = new Numeracion(Numeracion.ESistema.Binario, "1000");
            Operacion suma = new Operacion(num1, num2);
            Numeracion resultado1 = suma.Operar('+');
            Console.WriteLine(resultado1.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado1.ConvertirA(Numeracion.ESistema.Binario));

            Console.WriteLine("------------------");

            // test 2, operacion entre dos numeracines con distinto sistema
            Numeracion num3 = new Numeracion(Numeracion.ESistema.Decimal, "1234");
            Numeracion num4 = new Numeracion(Numeracion.ESistema.Binario, "1000");
            Operacion multiplicacion = new Operacion(num3, num4);
            Numeracion resultado2 = multiplicacion.Operar('*');
            Console.WriteLine(resultado2.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado2.ConvertirA(Numeracion.ESistema.Binario));

            Console.WriteLine("------------------");

            // test 3, división con valor 0 como segundo operador
            Numeracion num5 = new Numeracion(Numeracion.ESistema.Decimal, "1234");
            Numeracion num6 = new Numeracion(Numeracion.ESistema.Decimal, "0");
            Operacion division = new Operacion(num5, num6);
            Numeracion resultado3 = division.Operar('/');
            Console.WriteLine(resultado3.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado3.ConvertirA(Numeracion.ESistema.Binario));

            Console.WriteLine("------------------");

            // test 4, suma entre dos binarios
            Numeracion num7 = new Numeracion(Numeracion.ESistema.Decimal, "232");
            Numeracion num8 = new Numeracion(Numeracion.ESistema.Decimal, "500");
            Operacion resta = new Operacion(num7, num8);
            Numeracion resultado4 = resta.Operar('-');
            Console.WriteLine(resultado4.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado4.ConvertirA(Numeracion.ESistema.Binario));

        }
    }
}