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
            // TODO: Pedir para o usuário digitar uma matricula (ReadLine) e adicionar na lista "veiculos"
            // *IMPLEMENTE AQUI*
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
            if (veiculos.Any())
            {
                Console.WriteLine("Digite a matricula do veículo para remover:");

                // Pedir para o usuário digitar a matricula e armazenar na variável matricula
                // *IMPLEMENTE AQUI*
                string matricula = Console.ReadLine().ToLower();

                // Verifica se o veículo existe
                if (veiculos.Any(x => x.ToLower() == matricula))
                {
                    Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                    // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
                    // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
                    // *IMPLEMENTE AQUI*
                    int horas = int.Parse(Console.ReadLine());
                    decimal valorTotal = precoInicial + precoPorHora * horas;

                    // TODO: Remover a matricula digitada da lista de veículos
                    // *IMPLEMENTE AQUI*
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
                // TODO: Realizar um laço de repetição, exibindo os veículos estacionados
                // *IMPLEMENTE AQUI*
                veiculos.ForEach(veiculo => Console.WriteLine(veiculo));
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");

            }
        }
    }
}
