namespace CMDS_1.Services
{
    static public class Reader
    {
        static public void Read(ref int start, ref int end, ref double h)
        {
            var numbers = Console.ReadLine().Split(" ");
            start = Convert.ToInt32(numbers[0]);
            end = Convert.ToInt32(numbers[1]);
            h = Convert.ToDouble(numbers[2]);
        }
    }
}
