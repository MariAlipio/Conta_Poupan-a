using System;
using System.Collections.Generic;
using System.Text;

namespace CONTAPOUPANCA
{
    class CONTAPOUPANCA
    {
        public static double taxadejurosanual { get; set; }
        private double saldopoupanca;

        public CONTAPOUPANCA() { }
        public CONTAPOUPANCA(double SALDOpoupanca)
        {
            this.saldopoupanca = SALDOpoupanca;
        }//FIM DOS METODOS CONSTRUTORES
        public double Calcularjurosmensal()
        {
            //double juros = ((this.SALDOPoupanca * taxadejurosanual) / 12);
            this.saldopoupanca += (this.saldopoupanca * taxadejurosanual) / 12;
            return this.saldopoupanca;
        }//FIM DOS METODOS ACESSORES

    }
}
