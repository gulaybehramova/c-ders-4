using System;
using System.Linq;
using System.Reflection;

namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            CafedraA NatiqMuellim = new CafedraA();
            int cafedraAResult = NatiqMuellim.GetAllStudents(56, 90);
            Console.WriteLine(cafedraAResult);


            CafedraB AsifMuellim = new CafedraB();
            int cafedraBResult = AsifMuellim.GetAllStudentsAverage(56, 90);
            Console.WriteLine(cafedraBResult);

            CafedraC GulayMuellime = new CafedraC();
            int cafedraCResult = GulayMuellime.GetAllStudentsSquare(56, 90);
            Console.WriteLine(cafedraCResult);
        }
    }
}

