using System;

namespace Company_and_Candidate
{
    class Program
    {
        public static void Main(string[] args)
        {
            Company company = new Company("Godel", 5);
            Candidate candidate = new Candidate("NJ", 5);
            company.Compare();
        }
    }

     class Company
    {
        public string Name;
        public int CompanySalary;

        public Company(string name, int conmpanySalary)
        {
            Name = name;
            CompanySalary = conmpanySalary;
        }

        public void Compare()
        {
            if (Candidate.CandidateSalary <= CompanySalary)
            {
                Console.WriteLine("+");
            }
            else
            {
                Console.WriteLine("-");
            }
        }
    }

    class Candidate
    {
        public static string Name;
        public static int CandidateSalary;

        public Candidate(string name, int candidatesalary)
        {
            Name = name;
            CandidateSalary = candidatesalary;            
        }
    }

}
