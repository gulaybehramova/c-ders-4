namespace ConsoleApp2
{
    internal class CafedraB
    {
        public int GetAllStudentsAverage(int girlCount, int menCount)
        {
            CafedraA NatiqMuellim = new CafedraA();
            int studentsCount = NatiqMuellim.GetAllStudents(girlCount, menCount);
            int result = studentsCount / 2;
            return result;
        }
    }
}
