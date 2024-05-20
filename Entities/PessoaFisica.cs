using System.Security.Cryptography.X509Certificates;

namespace Course.Entities {

    public class PessoaFisica : Contribuinte {
        public double GastosComSaude {get; set;}
        public PessoaFisica () { }
        public PessoaFisica (string nome, double rendaAnual, double gastosComSaude)
        : base(nome, rendaAnual) {
            GastosComSaude = gastosComSaude;
         }



        public override double CalcularImposto(){
            
            double imposto;

            if (RendaAnual < 20000.00) {
                imposto = RendaAnual * 0.15;

                if (GastosComSaude > 0) {
                    imposto -= GastosComSaude * 0.5;
                }

                return imposto;

            } else {
                imposto = RendaAnual * 0.25;

                if (GastosComSaude > 0) {
                    return imposto -= GastosComSaude * 0.5;
                }
                return imposto;

            }

        }

        public override string ToString()
        {
            return $"Nome: {Nome}, RendaAnual: {RendaAnual}, Imposto Pago: {CalcularImposto().ToString()}";
        }
    }
}
