using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operacion
    {
        private Numeracion primerOperando;
        private Numeracion segundoOperando;

        public Numeracion PrimerOperando
        {
            get
            {
                return this.primerOperando;
            }
            set
            {
                this.primerOperando = value;
            }
        }

        public Numeracion SegundoOperando
        {
            get
            {
                return this.segundoOperando;
            }
            set
            {
                this.segundoOperando = value;
            }
        }

        public Operacion(Numeracion primerOperando, Numeracion segundoOperando)
        {
            this.primerOperando = primerOperando;
            this.segundoOperando = segundoOperando;
        }

        public Numeracion Operar(char operador)
        {
            if (this.primerOperando != this.segundoOperando)
            {
                throw new InvalidOperationException("No es posible operar si las numeraciones tienen diferente sistema");
            }

            switch (operador)
            {
                case '+':
                    return this.primerOperando + this.segundoOperando;
                case '-':
                    return this.primerOperando - this.segundoOperando;
                case '*':
                    return this.primerOperando * this.segundoOperando;
                case '/':
                    return this.primerOperando / this.segundoOperando;
                default:
                    return this.primerOperando + this.segundoOperando;
            }
        }
    }
}
