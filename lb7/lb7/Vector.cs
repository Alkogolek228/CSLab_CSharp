using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb7
{
    public class Vector
    {
        private int _a;
        private int _b;
        private int _c;

        public Vector()
        {
            _a = 0;
            _b = 0;
            _c = 0;
        }

        public Vector(int a, int b, int c)
        {
            this._a = a;
            this._b = b;
            this._c = c;
        }

        // Свойства с контролем корректности вводимых значений
        public int A
        {
            get { return _a; }
            set
            {
                if (value >= 0)
                {
                    _a = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("A", "Значение не может быть отрицательным");
                }
            }
        }

        public int B
        {
            get { return _b; }
            set
            {
                if (value >= 0)
                {
                    _b = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("B", "Значение не может быть отрицательным");
                }
            }
        }

        public int C
        {
            get { return _c; }
            set
            {
                if (value >= 0)
                {
                    _c = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("C", "Значение не может быть отрицательным");
                }
            }
        }

        // Перегрузка метода ToString()
        public override string ToString()
        {
            return $"({_a}, {_b}, {_c})";
        }

        // Индексирование для получения полей класса
        public int this[int i]
        {
            get
            {
                switch (i)
                {
                    case 0: return _a;
                    case 1: return _b;
                    case 2: return _c;
                    default: throw new IndexOutOfRangeException();
                }
            }
            set
            {
                switch (i)
                {
                    case 0: A = value; break;
                    case 1: B = value; break;
                    case 2: C = value; break;
                    default: throw new IndexOutOfRangeException();
                }
            }
        }

        // Перегрузка операторов
        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1._a + v2._a, v1._b + v2._b, v1._c + v2._c);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1._a - v2._a, v1._b - v2._b, v1._c - v2._c);
        }

        public static Vector operator *(Vector v, int scalar)
        {
            return new Vector(v._a * scalar, v._b * scalar, v._c * scalar);
        }

        public static Vector operator /(Vector v, int scalar)
        {
            if (scalar == 0)
            {
                throw new DivideByZeroException("Деление на ноль");
            }
            return new Vector(v._a / scalar, v._b / scalar, v._c / scalar);
        }

        public static bool operator ==(Vector v1, Vector v2)
        {
            return v1._a == v2._a && v1._b == v2._b && v1._c == v2._c;
        }

        public static bool operator !=(Vector v1, Vector v2)
        {
            return !(v1 == v2);
        }

        public static bool operator <(Vector v1, Vector v2)
        {
            return v1.Module() < v2.Module();
        }

        public static bool operator >(Vector v1, Vector v2)
        {
            return v1.Module() > v2.Module();
        }

        public static implicit operator bool(Vector v)
        {
            return v._a != 0 || v._b != 0 || v._c != 0;
        }

        public static explicit operator int(Vector v)
        {
            return (int)v.Module();
        }

        public static explicit operator Vector(int x)
        {
            return new Vector(x, x, x);
        }

        // Математические методы
        public double Module()
        {
            return Math.Sqrt(_a * _a + _b * _b + _c * _c);
        }

        // Инкремент и декремент
        public static Vector operator ++(Vector v)
        {
            return new Vector(v._a + 1, v._b + 1, v._c + 1);
        }

        public static Vector operator --(Vector v)
        {
            return new Vector(v._a - 1, v._b - 1, v._c - 1);
        }
    }
}   