namespace CalculoIMCeIAC {
    internal class Pessoa {

        public double Altura { get; set; }
        public double MassaCorporal { get; set; }
        public double CircunferenciaDoQuadril { get; set; }

        public Pessoa(double massaCorporalOuCircunferencia, double altura) {
            MassaCorporal = massaCorporalOuCircunferencia;
            CircunferenciaDoQuadril = massaCorporalOuCircunferencia;
            Altura = altura;
        }

        public double Imc(double massa, double altura) {
            double imc = massa / (Math.Pow(altura, 2));
            return imc;
        }

        public double Iac(double circunferencia, double altura) {
            double iac = (circunferencia / (altura * (Math.Sqrt(altura)))) - 18;
            return iac;
        }
    }
}
