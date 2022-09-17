namespace CMDS_1.Calculating
{
    public class AnalyticalSolution : IAnalyticalSolution
    {
        public List<double> Solve(int n, double h)
        {
            List<double> result = new List<double>();
            double y = 1;
            result.Add(y);
            for (int i = 1; i <= n; i++)
            {
                var t = i * h;
                y = Equation(t);
                result.Add(y);
            }

            return result;
        }

        private double Equation(double t) => Math.Exp(2 * t * t);
    }
}
