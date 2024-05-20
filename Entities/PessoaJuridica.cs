namespace Course.Entities {

    public class PessoaJuridica : Contribuinte {

        public int TotalFuncionarios {get; set;}

        public PessoaJuridica () { }

        public PessoaJuridica (string nome, double rendaAnual, int totalFuncionarios)
        : base(nome, rendaAnual) {

            TotalFuncionarios = totalFuncionarios;
         }

        public override double CalcularImposto(){
            if (TotalFuncionarios > 10) {
                return RendaAnual * 0.14;
            } else {
                return RendaAnual * 0.16;
            }

        }

        public override string ToString()
        {
            return $"Nome: {Nome}, RendaAnual: {RendaAnual}, Imposto Pago: {CalcularImposto().ToString()}";
        }
    }
}

