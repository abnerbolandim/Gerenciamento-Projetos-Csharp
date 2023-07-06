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

        public void AddProject(Project project)
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
    }

}