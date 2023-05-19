using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contatos
{
    internal class Program
    {

        static void Main(string[] args)
        {

            
            int escolha = 0;

            while (escolha != 4)
            {
                Console.Clear();
                Console.WriteLine("Bem-Vindo a sua Agenda\n");
                Console.WriteLine("O que deseja fazer?\n");
                Console.WriteLine(" 1- Criar Novo Contato\n 2- Lista de Contatos\n 3- Sair");
                Console.Write("Opção:");
                escolha = int.Parse(Console.ReadLine());
                Console.Clear();

                if (escolha == 1)
                    // Criar Contato
                {
                    Console.WriteLine("Digite o nome do contato");
                    string nomeContato = Console.ReadLine();
                    Console.WriteLine("Digite o numero do contato");
                    string numeroContato = Console.ReadLine();

                    string lista = @"C:\Users\bruno\Desktop\Bruno\Pessoal\Contatos\ListaContatos";
                    using (StreamWriter texto = File.AppendText(lista))
                    {
                        texto.WriteLine("Nome: " + nomeContato);
                        texto.WriteLine("Numero: " + numeroContato);
                        texto.WriteLine("--------------------");
                        Console.Clear();

                        Console.WriteLine("Contato criado com sucesso!\nPressione enter para continuar");
                        Console.ReadLine();
                    }
                }

                else if (escolha == 2)
                    // Exibir lista de contatos
                {
                    string[] lista = File.ReadAllLines(@"C:\Users\bruno\Desktop\Bruno\Pessoal\Contatos\ListaContatos");
                    
                    Console.WriteLine("**Lista de Contatos**");

                    foreach (string linha in lista)
                    {
                        Console.WriteLine(linha);      
                    }
                    Console.WriteLine("\nLista exibida com sucesso!\nPressione enter para continuar");
                    Console.ReadLine();
                }

                else if (escolha == 3)
                    // Sair da agenda
                {
                    Console.WriteLine("Tem certeza que deseja fechar?");
                    Console.WriteLine("1- Sim\n2- Não");
                    Console.Write("Opção:");
                    int confirmacao = int.Parse(Console.ReadLine());

                    if (confirmacao < 2)
                        // Finalizar Programa
                        escolha = 4;

                    else
                        // Voltar para o menu
                        Console.Clear();
                }

                else
                {
                    Console.WriteLine("Opção não encontrada");
                    Console.WriteLine("Pressione enter para continuar");
                    Console.ReadLine();
                    Console.Clear();
                }     
            }
        }
    }
}
