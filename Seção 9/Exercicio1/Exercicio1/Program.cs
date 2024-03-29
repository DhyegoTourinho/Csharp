﻿using Exercicio1.Entitites;
using System;
using System.Globalization;
using Exercicio1.Entitites.Enum;
using Exercicio1.Entitites;

namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter deparment's name: "); 
            string nameDepartment = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name: ");
            string nameWorker = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department department = new Department(nameDepartment);
            Worker worker = new Worker(nameWorker, level, baseSalary, department);

            Console.Write("How many contracts to this worker? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());
                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.WriteLine("Enter month and year to calculate income (MM/YYYY): ");
            string mounthAndYear = Console.ReadLine();
            int mounth = int.Parse(mounthAndYear.Substring(0, 2));
            int year = int.Parse(mounthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + mounthAndYear + ": " + worker.Income(year, mounth).ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}