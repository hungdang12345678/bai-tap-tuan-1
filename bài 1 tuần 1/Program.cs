using System;
using System.Globalization;

namespace hung
{
    class bai1
    {
        public static void Main()
        {
            double[,] A = null, B = null;
            while (true)
            {
                Console.WriteLine("1. Nhập ma trận A");
                Console.WriteLine("2. Nhập ma trận B");
                Console.WriteLine("3. Hiển thị ma trận A và B");
                Console.WriteLine("4. Cộng A + B");
                Console.WriteLine("5. Nhân A × B");
                Console.WriteLine("6. Chuyển vị A (Aᵀ)");
                Console.WriteLine("7.  min & max  A");
                Console.WriteLine("0. Thoát");
                Console.Write("nhap ma tran: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        A = ReadMatrix("A");
                        break;
                    case "2":
                        B = ReadMatrix("B");
                        break;
                    case "3":
                        Console.WriteLine("\nMa trận A:");
                        PrintMatrix(A);
                        Console.WriteLine("\nMa trận B:");
                        PrintMatrix(B);
                        break;
                    case "4":
                        if (!CheckBothSet(A, B)) break;
                        if (!SameSize(A, B)) { Console.WriteLine("lỗi thử lại."); break; }
                        var sum = AddMatrices(A, B);
                        Console.WriteLine("\n A + B:");
                        PrintMatrix(sum);
                        break;
                    case "5":
                        if (!CheckBothSet(A, B)) break;
                        if (A.GetLength(1) != B.GetLength(0)) { Console.WriteLine("lỗi thử lại."); break; }
                        var prod = MultiplyMatrices(A, B);
                        Console.WriteLine("\n A × B:");
                        PrintMatrix(prod);
                        break;
                    case "6":
                        if (!CheckSet(A, "A")) break;
                        var t = Transpose(A);
                        Console.WriteLine("\nAᵀ:");
                        PrintMatrix(t);
                        break;
                    case "7":
                        if (!CheckSet(A, "A")) break;
                        var mm = FindMinMax(A);
                        Console.WriteLine($"min: {mm.min}\nmax: {mm.max}");
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine(" lỗi hãy thử lại");
                        break;
                }
            }
        }

        static double[,] ReadMatrix(string name)
        {
            int rows = ReadInt($"Nhap so dong {name}: ");
            int cols = ReadInt($"Nhap so cot {name}: ");
            var m = new double[rows, cols];
            Console.WriteLine($"Nhap cac phan tu {name} (theo hàng):");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    m[i, j] = ReadDouble($"  {name}[{i},{j}] = ");
                }
            }
            return m;
        }

        static int ReadInt(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                if (int.TryParse(s, out int v) && v > 0) return v;
                Console.WriteLine("lỗi hãy nhập lại .");
            }
        }

        static double ReadDouble(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string s = Console.ReadLine();
                if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double v) ||
                    double.TryParse(s, NumberStyles.Any, CultureInfo.CurrentCulture, out v))
                    return v;
                Console.WriteLine("lỗi hãy nhập lại.");
            }
        }

        static bool CheckSet(double[,] m, string name)
        {
            if (m == null) { Console.WriteLine($"Ma trận {name} chưa được nhập."); return false; }
            return true;
        }

        static bool CheckBothSet(double[,] a, double[,] b)
        {
            if (a == null || b == null) { Console.WriteLine("Cần nhập cả hai ma trận."); return false; }
            return true;
        }

        static bool SameSize(double[,] a, double[,] b)
        {
            return a.GetLength(0) == b.GetLength(0) && a.GetLength(1) == b.GetLength(1);
        }
        static void PrintMatrix(double[,] m)
        {
            if (m == null) { Console.WriteLine("(rỗng)"); return; }
            int r = m.GetLength(0), c = m.GetLength(1);
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    Console.Write(string.Format("{0,10:0.####}", m[i, j]));
                }
                Console.WriteLine();
            }
        }
        static double[,] AddMatrices(double[,] a, double[,] b)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            var res = new double[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    res[i, j] = a[i, j] + b[i, j];
            return res;
        }
        static double[,] MultiplyMatrices(double[,] a, double[,] b)
        {
            int r = a.GetLength(0), common = a.GetLength(1), c = b.GetLength(1);
            var res = new double[r, c];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    double sum = 0;
                    for (int k = 0; k < common; k++)
                        sum += a[i, k] * b[k, j];
                    res[i, j] = sum;
                }
            return res;
        }

        static double[,] Transpose(double[,] a)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            var t = new double[c, r];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                    t[j, i] = a[i, j];
            return t;
        }
        static (double min, double max) FindMinMax(double[,] a)
        {
            int r = a.GetLength(0), c = a.GetLength(1);
            double min = a[0, 0], max = a[0, 0];
            for (int i = 0; i < r; i++)
                for (int j = 0; j < c; j++)
                {
                    if (a[i, j] < min) min = a[i, j];
                    if (a[i, j] > max) max = a[i, j];
                }
            return (min, max);
        }
    }
}
