namespace Exercicio5_teste
{
    
    class Program
    {
        public static void Main()
        {
            while (true)
            {
                
                Console.Write("Número do empregado: ");
                int numeroEmpregado = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ano de nascimento: ");
                int anoNascimento = Convert.ToInt32(Console.ReadLine());

                Console.Write("Ano de ingresso na companhia: ");
                int anoIngresso = Convert.ToInt32(Console.ReadLine());

                // Calcula idade e tempo de trabalho
                int idade = DateTime.Now.Year - anoNascimento;
                int tempoTrabalho = DateTime.Now.Year - anoIngresso;

                // Verifica se as condições de aposentadoria são atendidas
                bool podeAposentar = false;

                if (idade >= 65 || tempoTrabalho >= 30 || (idade >= 60 && tempoTrabalho >= 25))
                {
                    podeAposentar = true;
                }

                //  Informações
                Console.WriteLine($"Número do empregado: {numeroEmpregado}");
                Console.WriteLine($"Idade: {idade} anos");
                Console.WriteLine($"Tempo de trabalho: {tempoTrabalho} anos");

                if (podeAposentar)
                {
                    Console.WriteLine("Este funcionário pode requerer a reforma.");
                }
                else
                {
                    Console.WriteLine("Este funcionário não pode requerer a reforma.");
                }

                // mais dados?
                Console.Write("Deseja inserir mais dados? (s/n): ");
                char resposta = Console.ReadLine().ToLower()[0];

                if (resposta != 's')
                {
                    break;
                }
            }
        }
    }
}
