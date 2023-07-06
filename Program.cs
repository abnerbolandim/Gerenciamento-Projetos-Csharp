using System;
using System.Collections.Generic;

namespace GerenciamentoProjetos
{
    public class Project
    {
        public string Title{get; set;}
        public string Description{get; set;}
        public int IDate{get; set;}
        public int TDate{get; set;}
        public bool Status{get; set;}

        public void ShowDetails()
        {
            Console.WriteLine($"Título: {Title}");
            Console.WriteLine($"Descrição: {Description}");
            Console.WriteLine($"Data de início: {IDate}");
            Console.WriteLine($"Data de término: {TDate}");
            Console.WriteLine($"Status: {Status}");
        }
    }

    public class Management
    {
        private List<Project> projectList;

        public Management()
        {
            projectList = new List<Project>();
        } 

        public void AddProjects(Project project)
        {
            projectList.Add(project);
            Console.WriteLine("Projeto adicionado com sucesso!");
        }

        public void ShowProjects()
        {
            Console.WriteLine("Todos os projetos:");

            foreach (var project in projectList)
            {
                project.ShowDetails();
            }
        }

        public void AttProjects()
        {

        }

        public void RemoveProjects()
        {

        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("-=-=-=- Bem-vindo ao Gerenciamento de Projetos -=-=-=-");

            Management management = new Management();

            int opcao;

            do
            {
                Console.WriteLine("1. Adicionar um Projeto");
                Console.WriteLine("2. Visualizar todos os Projetos");
                Console.WriteLine("3. Atualizar um Projeto");
                Console.WriteLine("4. Remover um Projeto");
                Console.WriteLine("5. Pesquisar Projeto por título");
                Console.WriteLine("0. Sair");

                Console.Write("\nDigite: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Adicione título: ");
                        string title = Console.ReadLine();

                        Console.Write("Adicione uma descrição: ");
                        string description = Console.ReadLine();

                        Console.WriteLine("Data de início: ");
                        int idate = int.Parse(Console.ReadLine());

                        Console.WriteLine("Data de término: ");
                        int tdate = int.Parse(Console.ReadLine());

                        Project newProject = new Project
                        {
                            Title = title,
                            Description = description,
                            IDate = idate,
                            TDate = tdate,
                        };

                        management.AddProjects(newProject);

                        Console.WriteLine("Projeto adicionado com sucesso!");

                        break;

                    case 2:
                        management.ShowProjects();
                        break;

                    case 3:
                        

                    case 0:
                        Console.WriteLine("Saindo do programa...");
                        break;

                    default:
                        Console.WriteLine("Erro indefinido, tente novamente!");
                        break;
                }

            } while (opcao != 0);
        }
    }

}