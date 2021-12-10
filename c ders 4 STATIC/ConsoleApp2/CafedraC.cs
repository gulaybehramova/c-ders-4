namespace ConsoleApp2
{
    public class CafedraC
    {
        public int GetAllStudentsSquare(int girlCount,int boyCount)
        {
            CafedraA NatiqMuellim = new CafedraA();
            int allStudentCount = NatiqMuellim.GetAllStudents(girlCount, boyCount);
            int result = allStudentCount * allStudentCount;
            return result;
        }
    }
}
