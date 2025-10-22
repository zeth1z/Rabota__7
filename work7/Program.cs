public static double CalculateTriangleArea(double a, double b, double c)
    {
        try
        {
            if (a + b <= c || a + c <= b || b + c <= a)
            {
                throw new ArgumentException("Треугольника с такими сторонами не бывает");
            }

            double P = a + b + c;
            double p = P / 2;
            double area = Math.Sqrt(p * (p - a) * (p - b) * (p - c));

            return area;
        }
        catch (ArgumentException ex)
        {
            throw new ArgumentException($"Ошибка при вычислении площади: {ex.Message}");
        }
        catch (Exception ex)
        {
            throw new Exception($"Математическая ошибка: {ex.Message}");
        }
    }
