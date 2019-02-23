using System;

namespace Mankind
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] singleStudent = Console.ReadLine().Split();
            string firstStudentName = singleStudent[0];
            string lastStudentName = singleStudent[1];
            string facultyNumber = singleStudent[2];

            string[] singleWorker = Console.ReadLine().Split();
            string firstWorkerName = singleWorker[0];
            string lastWorkerName = singleWorker[1];
            decimal salary = decimal.Parse(singleWorker[2]);
            decimal workingHours = decimal.Parse(singleWorker[3]);


            try
            {
                Student student = new Student(firstStudentName, lastStudentName, facultyNumber);
                Worker worker = new Worker(firstWorkerName, lastWorkerName, salary, workingHours);

                Console.WriteLine(student);
                Console.WriteLine(worker);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
