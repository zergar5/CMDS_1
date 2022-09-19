namespace CMDS_1.Calculating
{
    static public class EulerianMethods
    {
        static public List<double> FirstMethod(int n, double h)
        {
            List<double> result = new List<double>(n + 1);
            double y = 1;
            result.Add(y);
            double t = 0;
            for (int i = 1; i <= n; i++, t += h)
            {
                y += h * Func(t, y);
                result.Add(y);
            }

            return result;
        }

        static public List<double> SecondMethod(int n, double h)
        {
            List<double> result = new List<double>(n + 1);
            double y = 1;
            result.Add(y);
            double t = 0;
            for (int i = 1; i <= n; i++, t += h)
            {
                y += h / 2 * (Func(t, y) + Func(t + h, y + h * Func(t, y)));
                result.Add(y);
            }

            return result;
        }

        static public List<double> ThirdMethod(int n, double h)
        {
            List<double> result = new List<double>(n + 1);
            double y = 1;
            result.Add(y);
            double t = 0;
            for (int i = 1; i <= n; i++, t += h)
            {
                y += h * Func(t + h / 2, y + h / 2 * Func(t, y));
                result.Add(y);
            }

            return result;
        }

        static private double Func(double t, double y) => 2 * t * y;
    }
}
