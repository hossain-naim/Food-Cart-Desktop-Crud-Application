﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace MonthlyProject
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class BlankPage3 : Page
    {
        DateTime startDate = DateTime.Now;
        public BlankPage3()
        {
            this.InitializeComponent();
            PopulateProjects();
        }
        private void PopulateProjects()
        {
            List<Project> Projects = new List<Project>();

            Project newProject = new Project();
            newProject.Name = "Project 1";
            newProject.Activities.Add(new Activity()
            { Name = "Activity 1", Complete = true, DueDate = startDate.AddDays(4) });
            newProject.Activities.Add(new Activity()
            { Name = "Activity 2", Complete = true, DueDate = startDate.AddDays(5) });
            Projects.Add(newProject);

            newProject = new Project();
            newProject.Name = "Project 2";
            newProject.Activities.Add(new Activity()
            { Name = "Activity A", Complete = true, DueDate = startDate.AddDays(2) });
            newProject.Activities.Add(new Activity()
            { Name = "Activity B", Complete = false, DueDate = startDate.AddDays(3) });
            Projects.Add(newProject);

            newProject = new Project();
            newProject.Name = "Project 3";
            Projects.Add(newProject);

            cvsProjects.Source = Projects;
        }
    }
    public class Project
    {
        public Project()
        {
            Activities = new ObservableCollection<Activity>();
        }

        public string Name { get; set; }
        public ObservableCollection<Activity> Activities { get; private set; }
    }

    public class Activity
    {
        public string Name { get; set; }
        public DateTime DueDate { get; set; }
        public bool Complete { get; set; }
        public string Project { get; set; }
    }
}
