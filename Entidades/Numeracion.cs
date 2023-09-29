using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numeracion
    {
        public enum ESistema { Decimal, Binario }
        private ESistema sistema;
        private double valorNumerico;

        public ESistema Sistema
        {
            get
            {
                return this.sistema;
            }
        }

        public string Valor
        {
            get
            {
                return this.valorNumerico.ToString();
            }
        }

        public Numeracion(ESistema sistema, double valor)
            :this(sistema, valor.ToString())
        {
        }

        public Numeracion(ESistema sistema, string valor)
        {
            InicializarValores(sistema, valor);
        }

        public void InicializarValores(ESistema sistema, string valor)
        {
            if (sistema == ESistema.Binario && EsBinario(valor))
            {
                this.valorNumerico = BinarioADecimal(valor);
            }
            else if (sistema == ESistema.Decimal && double.TryParse(valor, out double valorAux))
            {
                this.valorNumerico = valorAux;
            }
            else
            {
                this.valorNumerico = double.MinValue;
            }
            this.sistema = sistema;
        }

        public string ConvertirA(ESistema sistema)
        {
            if (sistema == ESistema.Binario)
            {
                return DecimalABinario(this.Valor);
            }
            else
            {
                return this.Valor.ToString();
            }
        }

        private bool EsBinario(string valor)
        {
            foreach (char c in valor)
            {
                if (c == '0' || c == '1')
                {
                    return true;
                }
            }
            return false;
        }

        private double BinarioADecimal(string valor)
        {
            if (!EsBinario(valor))
            {
                return 0;
            }
            else
            {
                char[] cadena = valor.ToCharArray();
                Array.Reverse(cadena);
                double suma = 0;

                for (int i = 0; i < cadena.Length; i++)
                {
                    if (cadena[i] == '1')
                    {
                        suma += (int)Math.Pow(2, i);
                    }
                }
                return suma;
            }
        }

        private string DecimalABinario(string valor)
        {
            if (int.TryParse(valor, out int entero) && entero > 0) 
            { 
                string binario = "";

                while (entero > 0)
                {
                    binario = entero % 2 + binario;
                    entero /= 2;
                }
                return binario;
            }
            else
            {
                return "Valor inválido";
            }
        }

        private string DecimalABinario(int valor)
        {
            if (valor > 0)
            {
                string binario = "";

                while (valor > 0)
                {
                    binario = valor % 2 + binario;
                    valor /= 2;
                }
                return binario;
            }
            else
            {
                return "Valor inválido";
            }
        }

        public static Numeracion operator +(Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.Sistema, n1.valorNumerico + n2.valorNumerico);
            }
            else
            {
                throw new InvalidOperationException("La operación se puede hacer sólo si las numeraciones pertenecen al mismo sistema");
            }
        }

        public static Numeracion operator -(Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.Sistema, n1.valorNumerico - n2.valorNumerico);
            }
            else
            {
                throw new InvalidOperationException("La operación se puede hacer sólo si las numeraciones pertenecen al mismo sistema");
            }
        }

        public static Numeracion operator *(Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.Sistema, n1.valorNumerico * n2.valorNumerico);
            }
            else
            {
                throw new InvalidOperationException("La operación se puede hacer sólo si las numeraciones pertenecen al mismo sistema");
            }
        }

        public static Numeracion operator /(Numeracion n1, Numeracion n2)
        {
            if (n1 == n2)
            {
                return new Numeracion(n1.Sistema, n1.valorNumerico / n2.valorNumerico);
            }
            else
            {
                throw new InvalidOperationException("La operación se puede hacer sólo si las numeraciones pertenecen al mismo sistema");
            }
        }

        public static bool operator ==(ESistema sistema, Numeracion numeracion)
        {
            return sistema == numeracion.Sistema;
        }
        public static bool operator !=(ESistema sistema, Numeracion numeracion)
        {
            return !(sistema == numeracion);
        }

        public static bool operator ==(Numeracion n1, Numeracion n2)
        {
            return n1.Sistema == n2.Sistema;
        }

        public static bool operator !=(Numeracion n1, Numeracion n2)
        {
            return !(n1 == n2);
        }
    }
}
