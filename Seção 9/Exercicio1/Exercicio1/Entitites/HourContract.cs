﻿using System;

namespace Exercicio1.Entitites
{
    internal class HourContract
    {
        public DateTime Date { get; set; }
        public double ValuePerHour;
        public int Hours;


        public HourContract() 
        { 
        }
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }
    }
}
