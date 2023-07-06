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

        public void UpdateProject(string title)
        {
            Project projectToUpdate = projectList.Find(p => p.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if (projectToUpdate != null)
            {
                Console.WriteLine($"Atualizando projeto: {title}");

                Console.Write("Novo título: ");
                string newTitle = Console.ReadLine();

                Console.Write("Nova descrição: ");
                string newDescription = Console.ReadLine();

                Console.Write("Nova data de início: ");
                int newIDate = int.Parse(Console.ReadLine());

                Console.Write("Nova data de término: ");
                int newTDate = int.Parse(Console.ReadLine());

                projectToUpdate.Title = newTitle;
                projectToUpdate.Description = newDescription;
                projectToUpdate.IDate = newIDate;
                projectToUpdate.TDate = newTDate;

                Console.WriteLine("Projeto atualizado com sucesso!");
            }
            else
            {
                Console.WriteLine("Projeto não existente!");
            }
        }


        public void RemoveProjects(string title)
        {
            Project deleteProject = projectList.Find(p => p.Title.Equals(title, StringComparison.OrdinalIgnoreCase));

            if(deleteProject != null)
            {
                projectList.Remove(deleteProject);

                Console.WriteLine("Projeto removido com sucesso!");
            }
            else
            {
                Console.WriteLine("Projeto não existente!");
            }
        }

        public void SearchProjects(string title)
        {
            Console.WriteLine($"Pesquisa de projeto: {title}");

            Project searchProject = projectList.Find(p => p.Title.Equals(title, StringComparison.OrdinalIgnoreCase));
        
            if(searchProject != null)
            {
                Console.WriteLine($"Título: {searchProject.Title}");
                Console.WriteLine($"Descrição: {searchProject.Description}");
                Console.WriteLine($"Data de início: {searchProject.IDate}");
                Console.WriteLine($"Data de término: {searchProject.TDate}");
                Console.WriteLine($"Status: {searchProject.Status}");   
            }
            else
            {
                Console.WriteLine("Projeto não encontrado.");
            }

            Console.ReadKey();

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
                        Console.WriteLine("Projeto a ser atualizado (Título): ");
                        string updateTitle = Console.ReadLine();

                        management.UpdateProject(updateTitle);
                        break;

                    case 4:
                        Console.WriteLine("Projeto a ser removido (Título): ");
                        string deleteTitle = Console.ReadLine();
                        
                        management.RemoveProjects(deleteTitle);
                        break;

                    case 5:
                        Console.WriteLine("Projeto a ser pesquisado (Título): ");
                        string searchTitle = Console.ReadLine();

                        management.SearchProjects(searchTitle);
                        break;

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