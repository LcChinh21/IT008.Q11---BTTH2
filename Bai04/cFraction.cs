using System;

namespace Bai04
{
    internal class cFraction : IComparable<cFraction>
    {
        private int Tu, Mau;
        public cFraction(int tu = 0, int mau = 1)
        {
            Tu = tu;
            Mau = mau == 0 ? 1 : mau;
            RutGon();
        }
        private int UCLN(int a, int b)
        {
            while (b != 0)
            {
                int tmp = a % b;
                a = b;
                b = tmp;
            }
            return a;
        }
        private void RutGon()
        {
            int g = UCLN(Math.Abs(Tu), Math.Abs(Mau));
            Tu /= g; Mau /= g;
            if (Mau < 0) { Tu = -Tu; Mau = -Mau; }
        }
        public static cFraction operator +(cFraction a, cFraction b)
            => new cFraction(a.Tu * b.Mau + b.Tu * a.Mau, a.Mau * b.Mau);
        public static cFraction operator -(cFraction a, cFraction b)
            => new cFraction(a.Tu * b.Mau - b.Tu * a.Mau, a.Mau * b.Mau);
        public static cFraction operator *(cFraction a, cFraction b)
            => new cFraction(a.Tu * b.Tu, a.Mau * b.Mau);
        public static cFraction operator /(cFraction a, cFraction b)
        {
            if (b.Tu == 0) throw new DivideByZeroException("Không thể chia cho 0");
            return new cFraction(a.Tu * b.Mau, a.Mau * b.Tu);
        }
        public int CompareTo(cFraction other)
        {
            double a = (double)Tu / Mau;
            double b = (double)other.Tu / other.Mau;
            return a.CompareTo(b);
        }
        public override string ToString() => Mau == 1 ? Tu.ToString() : $"{Tu}/{Mau}";
    }
}
