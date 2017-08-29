using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRgetTheGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }

    //base class
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        /*	
       *   Class Constructor
       *   
       *   Parameters: 
       *   firstName - A string denoting the Person's first name.
       *   lastName - A string denoting the Person's last name.
       *   id - An integer denoting the Person's ID number.
         */   
       public Person(string firstName, string lastName, int identification)
       {
           this.firstName = firstName;
           this.lastName = lastName;
           this.id = identification;
       }
       public void printPerson()
       {
           Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
       }
   }

   class Student : Person
   {
       private int[] testScores;

       
       //  scores - An array of integers denoting the Person's test scores.
        
       // Write your constructor here
       public Student(string firstName, string lastName, int id, int[] scores)
           : base(firstName, lastName, id)
       {
           this.testScores = scores;
       }
       /*	
       *   Method Name: Calculate
       *   Return: A character denoting the grade.
       */
       
        public char Calculate()
        {
            double sum = 0;
            for (int i = 0; i < testScores.Length; i++)
            {
                sum += testScores[i];
            }
            double avg = sum / testScores.Length;

            if (avg >= 40 && avg < 55)
            {
                return 'D';
            }
            if (avg >= 55 && avg < 70)
            {
                return 'P';
            }
            if (avg >= 70 && avg < 80)
            {
                return 'A';
            }
            if (avg >= 80 && avg < 90)
            {
                return 'E';
            }
            if (avg >= 90 && avg <= 100)
            {
                return 'O';
            }
            else return 'T';
        }
    }
}
