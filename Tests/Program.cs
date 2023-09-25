using Entidades;

namespace Tests
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Numeracion numero1 = new Numeracion(Numeracion.ESistema.Decimal, "200");
            Numeracion numero2 = new Numeracion(Numeracion.ESistema.Decimal, "1010");
            Numeracion numero3 = new Numeracion(Numeracion.ESistema.Binario, "1001");

            Console.WriteLine("------ Suma -------");
            Operacion suma = new Operacion(numero1, numero3);
            Numeracion resultadoSuma = suma.Operar('+');

            string resultadoSumaDecimal = resultadoSuma.ConvertirA(Numeracion.ESistema.Decimal);
            string resultadoSumaBinario = resultadoSuma.ConvertirA(Numeracion.ESistema.Binario);

            Console.WriteLine($"resultado en sistema decimal: {resultadoSumaDecimal}");
            Console.WriteLine($"resultado en sistema binario: {resultadoSumaBinario}");

            Console.WriteLine("------ Resta -------");
            Operacion resta = new Operacion(numero1, numero3);
            Operacion resta2 = new Operacion(numero3, numero1);
            Numeracion resultadoResta = resta.Operar('-');
            Numeracion resultadoResta2 = resta2.Operar('-');

            string resultadoRestaDecimal = resultadoResta.ConvertirA(Numeracion.ESistema.Decimal);
            string resultadoRestaBinario = resultadoResta.ConvertirA(Numeracion.ESistema.Binario);
            string resultadoRestaDecimal2 = resultadoResta2.ConvertirA(Numeracion.ESistema.Decimal);
            string resultadoRestaBinario2 = resultadoResta2.ConvertirA(Numeracion.ESistema.Binario);

            Console.WriteLine($"resultado en sistema decimal: {resultadoRestaDecimal}");
            Console.WriteLine($"resultado en sistema binario: {resultadoRestaBinario}");
            Console.WriteLine($"resultado en sistema decimal: {resultadoRestaDecimal2}");
            Console.WriteLine($"resultado en sistema binario: {resultadoRestaBinario2}");
        }
    }
}