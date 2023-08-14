﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using CommonUser;
using Model.Entity;
using static Model.Entity.Manage;
using Controller;

namespace ConsoleApp8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            login login = new login();
            login.CheckLogin();
            Manage manager = new Manage();
            ManageBl controller=new ManageBl();
            controller.InitializeDefaultProjects();
            List<Project> projects = controller.GetDefaultProjects();
            Console.WriteLine("╔════════════════════════════════════╗");
            Console.WriteLine("║            Main Menu               ║");
            Console.WriteLine("╠════════════════════════════════════╣");
            Console.WriteLine("║ 1. Manage ║  2. Leader ║ 3. Member ║");
            Console.WriteLine("╚════════════════════════════════════╝");
            Console.Write("Choose level ! :");
            int choose0 = int.Parse(Console.ReadLine());
            switch (choose0)
            {
                case 1:
                    controller.menuManage();
                    break;
                case 2:

                    break;
                case 3:

                    break;
            }
        }    
    }
}