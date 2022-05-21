//Nomeação do projeto Menu:
namespace Condicionais
{
    //Criação da classe do aplicativo:
    class App
    {
        //Criação da função principal do aplicativo:  
        static void Main(string[] args)
        {
            //Texto que corresponde as funções do menu:
            string menu = $"{new String('=', 20)}MENU{new String('=', 20)}\n" +
                $"1 {new String('.', 20)} Verificar Maioridade\n" +
                $"2 {new String('.', 20)} Dia da Semana\n\n" +
                $"Digite a opção desejada: ";

            //Criação da variável que vai receber a opção desejada:
            string opcao;

            //Escrita na tela do texto contido em menu e recebimento da opção desejada:
            Console.Write(menu);
            opcao = Console.ReadLine();

            //Verifica qual a função escolhida e chama a função referente a ela:
            switch (opcao)
            {
                case "1":
                    VerificarMaioridade();
                    break;
                case "2":
                    InformarDiaDaSemana();
                    break;
                default:
                    Console.WriteLine("Nenhuma opção escolhida!");
                    break;
            }
        }

        //Criação da função que verifica a maioridade:
        static void VerificarMaioridade()
        {
            //Criação da variável que vai receber o ano de nascimento do usuário:
            int anoDeNascimento;

            //Escrita do cabeçalho da função e pedido do ano de nascimento:
            Console.Write($"\n{new String('=', 10)} VAMOS VERIFICAR SE VOCÊ JÁ É DE MAIOR{new String('=', 10)}\n" +
                $"Digite seu ano de nascimento: ");
            anoDeNascimento = int.Parse(Console.ReadLine());

            //Calculo da idade:
            int idade = 2022 - anoDeNascimento;

            //Verifica o valor da idade e dá a determinada resposta a depender dessa valor:
            if(idade < 18)
            {
                Console.WriteLine($"\nVocê vai alcançar a maioridade em {18-idade} anos!");
            }
            else if(idade == 18)
            {
                Console.WriteLine($"\nVocê alcançou ou vai alcançar a maioridade nesse ano!");
            }
            else
            {
                Console.WriteLine($"\nVocê já alcançou a maioridade!");
            }
        }

        //Criação da função que diz qual o dia da semana a depender do número digitado:
        static void InformarDiaDaSemana()
        {
            //Criação da variável que vai receber o número do dia da semana: 
            int diaDaSemana;

            //Escrita do cabeçalho da função e recebimento do valor digitado:
            Console.Write($"\n{new String('=', 10)}Dizer o nome do dia da semana de acordo com o número{new String('=', 10)}\n" +
                $"Digite o número do dia da semana: ");
            diaDaSemana = int.Parse(Console.ReadLine());

            //Verificação do número do dia e escrita do valor:
            switch (diaDaSemana)
            {
                case 1:
                    Console.WriteLine("\nDomingo!");
                    break;

                case 2:
                    Console.WriteLine("\nSegunda-feira!");
                    break;

                case 3:
                    Console.WriteLine("\nTerça-feira!");
                    break;

                case 4:
                    Console.WriteLine("\nQuarta-feira!");
                    break;

                case 5:
                    Console.WriteLine("\nQuinta-feira!");
                    break;

                case 6:
                    Console.WriteLine("\nSexta-feira!");
                    break;

                case 7:
                    Console.WriteLine("\nSábado!");
                    break;

                default:
                    Console.WriteLine("\nNenhum dia relacionado!");
                    break;
            }
        }
    }
}