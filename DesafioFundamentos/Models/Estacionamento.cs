namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // Implementado
            string matricula = "";
            do
            {
                Console.WriteLine("Digite a matricula do veículo para estacionar:");
                matricula = Console.ReadLine().Trim();

            } while (matricula == "");

            bool check = veiculos.Any(x => x == matricula);
            if (check)
            {
                System.Console.WriteLine("Veiculo com matricula '{0}' existe no parque", matricula);
            }
            else
            {
                veiculos.Add(matricula);
            }
        }

        public void RemoverVeiculo()
        {
            if (veiculos.Any()) //verificar se a lista esta vazia
            {
                Console.WriteLine("Digite a matricula do veículo para remover:");

                // Implementado
                string matricula = Console.ReadLine().ToLower();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToLower() == matricula))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // Implementado
                    int horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    // implementado git s
                    veiculos.RemoveAt(veiculos.FindIndex(x => x.ToLower() == matricula));

                    Console.WriteLine("O veículo '{0}' foi removido e o preço total foi de: MZN {1:N}", matricula, valorTotal);
                }
                else
                {
                    Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a matricula corretamente");
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");

                // implementado utilizando o Stream
                veiculos.ForEach(veiculo => Console.WriteLine(veiculo));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");

            }
        }
    }
}
