using System;
using System.Collections.Generic;

namespace GerenciadorDeTarefas
{
    class Program
    {
        static List<string> tarefas = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("--- Gerenciador de Tarefas ---");
            AdicionarTarefa();

            Console.WriteLine("\nTarefas cadastradas:");
            foreach (var t in tarefas)
            {
                Console.WriteLine($"- {t}");
            }
        }

        static void AdicionarTarefa()
        {
            Console.Write("Digite a nova tarefa: ");
            string novaTarefa = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(novaTarefa))
            {
                Console.WriteLine("Erro: O nome da tarefa não pode ser vazio.");
                Console.Write("Digite a nova tarefa novamente: ");
                novaTarefa = Console.ReadLine();
            }

            try
            {
                tarefas.Add(novaTarefa);
                Console.WriteLine("Tarefa adicionada com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro ao adicionar a tarefa: {ex.Message}");
            }
        }
    }
}

// Este projeto é simples de propósito. Use-o como base pra testar sua IA
// conectada localmente — ex.: peça pra ela adicionar um método de remover
// tarefa, ou listar só as pendentes, seguindo o estilo já usado aqui.
