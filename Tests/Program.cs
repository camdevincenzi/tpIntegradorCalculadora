using Entidades;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // test 1 suma normal, retorna resultado en decimal y binario
            Numeracion num1 = new Numeracion(Numeracion.ESistema.Decimal, "200");
            Numeracion num2 = new Numeracion(Numeracion.ESistema.Binario, "1000");
            Operacion suma = new Operacion(num1, num2);
            Numeracion resultado1 = suma.Operar('+');
            Console.WriteLine(resultado1.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado1.ConvertirA(Numeracion.ESistema.Binario));

            Console.WriteLine("--------------");

            // test 2, resta normal que da como resultado un número positivo
            Numeracion num3 = new Numeracion(Numeracion.ESistema.Decimal, "150");
            Numeracion num4 = new Numeracion(Numeracion.ESistema.Binario, "1010");
            Operacion resta1 = new Operacion(num3, num4);
            Numeracion resultado2 = resta1.Operar('-');
            Console.WriteLine(resultado2.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado2.ConvertirA(Numeracion.ESistema.Binario));

            Console.WriteLine("--------------");

            // test 3, resta que da como resultado un número negativo
            Numeracion num5 = new Numeracion(Numeracion.ESistema.Decimal, "4");
            Numeracion num6 = new Numeracion(Numeracion.ESistema.Binario, "1110");
            Operacion resta2 = new Operacion(num5, num6);
            Numeracion resultado3 = resta2.Operar('-');
            Console.WriteLine(resultado3.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado3.ConvertirA(Numeracion.ESistema.Binario));

            Console.WriteLine("--------------");

            // test 4, se ingresan letras
            Numeracion num7 = new Numeracion(Numeracion.ESistema.Decimal, "42a");
            Numeracion num8 = new Numeracion(Numeracion.ESistema.Binario, "10w00");
            Operacion multiplicacion = new Operacion(num7, num8);
            Numeracion resultado4 = multiplicacion.Operar('*');
            Console.WriteLine(resultado4.ConvertirA(Numeracion.ESistema.Decimal));
            Console.WriteLine(resultado4.ConvertirA(Numeracion.ESistema.Binario));
        }
    }
}