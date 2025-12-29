using ExamSchedular.Data;
using ExamSchedular.Model;

namespace ExamSchedular
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var dataBank = DataBank.getStudentsData();
            //foreach (var student in dataBank)
            //{
            //    Console.WriteLine($"{student.Id} {student.Name}");
            //}

            var dataSession = DataSession.GetSessionsData();
            foreach (var session in dataSession)
            {
                Console.WriteLine($"{session.Id}");
            }

        }
    }
}
