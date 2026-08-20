namespace Programa01B
{
    class Bike
    {
        //Declarações
        public string? Modelo { get; set; }
        public double Bateria { get; set; }
        public double PesoCiclista { get; set; }
        public int RecargaMes { get; set; }

        //métodos
        
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15.0;
            bool pesoElevado = PesoCiclista > 90.0;

            //If peso > 90 reduz para 15% a autonomia
            return pesoElevado ? (autonomiaBase * 0.05) : autonomiaBase; 
        }
        public double CalcularConsumoMensal()
        {
            double cargaKm = Bateria / 1000.0;
            return cargaKm * RecargaMes;
        }
        public double CalcularCustoMensal()
        {
            const double preco = 0.80;
            return CalcularConsumoMensal() * preco;
        }
        public bool BikeEconomica()
        {
            return (CalcularCustoMensal() < 15.0) || (CalcularAutonomia() > 40.0);
        }
    }
}
