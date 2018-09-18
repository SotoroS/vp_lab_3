using System;

namespace figure
{
    // Абстрактный класс для фигур
    abstract public class Body
    {
        // Абстрактная функция вычисления площади
        abstract public double Area();

        // Абстрактная функция вычисления объема
        abstract public double Volume();
    }

    // Параллелепипед
    public class Parallelepiped : Body
    {
        double a, b, h; // Стороны параллелепипед

        public Parallelepiped()
        {
            a = 0f;
            b = 0f;
            h = 0f;
        }

        public Parallelepiped(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.h = c;
        }

        // Площадь параллелепипед
        public override double Area()
        {
            return 2 * (a * b + b * h + h * a);
        }

        // Объем параллелепипед
        public override double Volume()
        {
            return a * b * h;
        }
    }

    // Шар
    public class Ball : Body
    {
        double r;   // Радиус шара

        public Ball()
        {
            this.r = 0;
        }

        public Ball(double r)
        {
            this.r = r;
        }

        // Площадь шара
        public override double Area()
        {
            return 4 * Math.PI * r;
        }

        // Объем шара
        public override double Volume()
        {
            return (4 / 3) * Math.PI * r * r * r;
        }
    }
}
