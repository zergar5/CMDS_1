using CMDS_1.Calculating;
using static CMDS_1.Calculating.EulerianMethods;
using static CMDS_1.Services.Reader;
using static CMDS_1.Services.TablesCreator;

namespace CMDS_1
{
    internal class Program
    {
        private static int _start;
        private static int _end;
        private static double _h;
        static void Main(string[] args)
        {
            Read(ref _start, ref _end, ref _h);

            IAnalyticalSolution analyticalSolution = new AnalyticalSolution();
            int c = 1;
            for (int i = 0; i < 3; i++)
            {
                var n = (int)((_end - _start) / _h);
                var analyticalSolve = analyticalSolution.Solve(n, _h);
                var firstMethod = FirstMethod(n, _h);
                using (var fileStream = new FileStream($"outputFirstMethod{c}.txt", FileMode.Create))
                {
                    Create(n, _h, firstMethod, analyticalSolve, fileStream);
                }
                var secondMethod = SecondMethod(n, _h);
                using (var fileStream = new FileStream($"outputSecondMethod{c}.txt", FileMode.Create))
                {
                    Create(n, _h, secondMethod, analyticalSolve, fileStream);

                }
                var thirdMethod = ThirdMethod(n, _h);
                using (var fileStream = new FileStream($"outputThirdMethod{c}.txt", FileMode.Create))
                {
                    Create(n, _h, thirdMethod, analyticalSolve, fileStream);
                }
                c++;
                _h /= 2;
            }
        }
    }
}