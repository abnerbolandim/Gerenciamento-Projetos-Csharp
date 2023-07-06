using System;
using System.Collections.Generic;

namespace GerenciamentoProjetos
{
    public class Project
    {
        public string Title{get; set;}
        public string Description{get; set;}
        public int IDate{get; set;}
        public int FDate{get; set;}
        public bool Status{get; set;}


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
    }

}