using System.Text;

namespace CMDS_1.Services
{
    static public class TablesCreator
    {
        private static int c = 1;

        static public void Create(int n, double h, List<double> yC, List<double> yA, FileStream fileStream)
        {
            using (var streamWriter = new StreamWriter(fileStream))
            {
                streamWriter.WriteLine("t y_численное y_аналитическое |y_численное - y_аналитическое|");
                for (int i = 0; i <= n; i++)
                {
                    var stringBulder = new StringBuilder((h * i).ToString("0.000"));
                    stringBulder.Append(" ");
                    stringBulder.Append(yC[i].ToString("0.00e+00"));
                    stringBulder.Append(" ");
                    stringBulder.Append(yA[i].ToString("0.00e+00"));
                    stringBulder.Append(" ");
                    stringBulder.Append(Math.Abs(yC[i] - yA[i]).ToString("0.00e+00"));
                    streamWriter.WriteLine(stringBulder.ToString());
                }
            }
        }
    }
}
