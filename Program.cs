using System;
using System.Collections.Generic;

class Program
{
    static List<string> veiculos = new List<string>();

    static void Main(string[] args)
    {
        bool encerrar = false;

        while (!encerrar)
        {
            Console.WriteLine("== Estacionamento ==");
            Console.WriteLine("1. Cadastrar veículo");
            Console.WriteLine("2. Retirar veículo");
            Console.WriteLine("3. Listar veículos");
            Console.WriteLine("4. Encerrar");

            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    CadastrarVeiculo();
                    break;
                case 2:
                    RetirarVeiculo();
                    break;
                case 3:
                    ListarVeiculos();
                    break;
                case 4:
                    encerrar = true;
                    Console.WriteLine("Encerrando o programa...");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void CadastrarVeiculo()
    {
        Console.Write("Digite a placa do veículo: ");
        string placa = Console.ReadLine();

        if (!veiculos.Contains(placa))
        {
            veiculos.Add(placa);
            Console.WriteLine("Veículo cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Veículo já cadastrado no estacionamento.");
        }
    }

    static void RetirarVeiculo()
    {
        Console.Write("Digite a placa do veículo a ser retirado: ");
        string placa = Console.ReadLine();

        if (veiculos.Contains(placa))
        {
            veiculos.Remove(placa);
            Console.WriteLine("Veículo retirado do estacionamento com sucesso!");
        }
        else
        {
            Console.WriteLine("Veículo não encontrado no estacionamento.");
        }
    }

    static void ListarVeiculos()
    {
        Console.WriteLine("Veículos cadastrados no estacionamento:");

        if (veiculos.Count == 0)
        {
            Console.WriteLine("Nenhum veículo cadastrado.");
        }
        else
        {
            foreach (string veiculo in veiculos)
            {
                Console.WriteLine(veiculo);
            }
        }
    }
}
