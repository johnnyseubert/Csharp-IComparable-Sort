using System;
using System.Collections.Generic;
using System.IO;
using IComparable.Entities;

namespace IComparable
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"C:\temp\in.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    List<Employee> list = new List<Employee>();
                    
                    while (!sr.EndOfStream)
                    {
                        list.Add(new Employee(sr.ReadLine()));
                    }
                    list.Sort();
                    foreach (var emp in list)
                    {
                        Console.WriteLine(emp);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}