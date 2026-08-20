using Programa01B;

Console.WriteLine("LOJA DA BIKE\n");

//instância
Bike bike = new Bike();

Console.WriteLine("Modelo Bike");
bike.Modelo = Console.ReadLine();

Console.WriteLine("Capacidade da bateria");
bike.Bateria = double.Parse(Console.ReadLine());

Console.WriteLine("Peso Ciclista");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Quantidade estimada de recarga");
bike.RecargaMes = int.Parse(Console.ReadLine());

Console.WriteLine("\n--- relatório de desempenho da bike ---");
Console.WriteLine($"Bike: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia estimada: {bike.CalcularAutonomia():F1}por carga");
Console.WriteLine($"Consumo mensal: {bike.CalcularConsumoMensal():F2}Km");
Console.WriteLine($"Custo Mensal: {bike.CalcularCustoMensal()}:N2");
Console.WriteLine($"A Bike é economica? {bike.BikeEconomica()}");
