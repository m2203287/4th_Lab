using System;
using System.Numerics;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using System.Transactions;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;
using System.Collections.Immutable;
using System.Globalization;

public class Proga
{
    public static void Main(string[] args)
    {
        //resh.lvl1ex3();
        //resh.lvl1ex6();
        //resh.lvl1ex12();
        //resh.lvl1ex13();
        //resh.lvl1ex17();
        //resh.lvl1ex29();
        //resh.lvl1ex31();
        //resh.lvl2ex7();
        //resh.lvl2ex8();
        //resh.lvl2ex9();
        //resh.lvl3ex1();
        //resh.lvl3ex2();
        //resh.lvl3ex3();
        //resh.lvl3ex4();
        //resh.lvl3ex8();
        resh.lvl3ex10();
        //resh.lvl3ex11();
    }

    public class resh
    {
        public static void lvl1ex3()
        {
            double[,] mat = new double[4, 4];
            double sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                sum += mat[i, i];
            }
            for (int i = 0; i < 4; i++)
            {
                sum += mat[i, 3 - i];
            }
            Console.WriteLine("Sum is: " + sum);
        }
        public static void lvl1ex6()
        {
            double[,] mat = new double[4, 7];
            double[] ans = new double[4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);
                }
            }
            double tmp;
            for (int i = 0; i < 4; i++)
            {
                tmp = double.MaxValue;
                for (int j = 0; j < 7; j++)
                {
                    if (mat[i, j] < tmp)
                    {
                        tmp = mat[i, j];
                    }
                }
                ans[i] = tmp;
            }
            foreach (double i in ans)
            {
                Console.Write(i + " ");
            }
        }
        public static void lvl1ex12()
        {
            double[,] mat = new double[6, 7];
            double max = double.MinValue;
            double[,] ans = new double[5, 6];
            double maxi = -1, maxj = -1;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (mat[i, j] > max)
                    {
                        max = mat[i, j];
                        maxi = i;
                        maxj = j;
                    }
                }
            }
            int ii = 0, jj = 0;
            for (int i = 0; i < 5; i++)
            {
                if (ii == maxi)
                {
                    ii++;
                }
                for (int j = 0; j < 6; j++)
                {
                    if (jj == maxj)
                    {
                        jj++;
                    }
                    ans[i, j] = mat[ii, jj];
                    jj++;
                }
                jj = 0;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(ans[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl1ex13()
        {
            double[,] mat = new double[5, 5];
            double max = double.MinValue;
            int maxi = -1, maxj = -1;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (i == j && mat[i, j] > max)
                    {
                        max = mat[i, j];
                        maxj = j;
                    }
                }
            }
            double tmp = 0;
            for (int i = 0; i < 5; i++)
            {
                tmp = mat[i, 3];
                mat[i, 3] = mat[i, maxj];
                mat[i, maxj] = tmp;
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl1ex17()
        {
            double max;
            int maxi, n, m;
            Console.WriteLine("Enter number of lines");
            int.TryParse(Console.ReadLine(), out n);
            Console.WriteLine("Enter number of columns");
            int.TryParse(Console.ReadLine(), out m);
            double[,] mat = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                max = double.MaxValue;
                maxi = 0;
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (mat[i, j] < max)
                    {
                        maxi = j;
                        max = mat[i, j];
                    }
                }
                for (int k = maxi; k > 0; k--)
                {
                    mat[i, k] = mat[i, k - 1];
                }
                mat[i, 0] = max;
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }

        public static void lvl1ex29()
        {
            double[,] mat = new double[5, 7];
            double[,] ans = new double[5, 6];
            double min = double.MaxValue;
            int minj = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (i == 1 && Math.Abs(mat[i, j]) < min)
                    {
                        min = mat[i, j];
                        minj = j;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0, jj = 0; j < 6; j++, jj++)
                {
                    if (j == minj)
                    {
                        jj++;
                    }
                    ans[i, j] = mat[i, jj];
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(ans[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl1ex31()
        {
            double[,] mat = new double[5, 4];
            double[,] ans = new double[5, 5];
            double[] B = new double[5];
            double min = double.MaxValue;
            int minj = 0;
            Console.WriteLine($"Enter vector B");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter element № {i + 1}");
                B[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (i == 4 && mat[i, j] < min)
                    {
                        min = mat[i, j];
                        minj = j;
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0, jj = 0; jj < 5; j++, jj++)
                {
                    ans[i, jj] = mat[i, j];
                    if (jj == minj)
                    {
                        jj++;
                        ans[i, jj] = B[i];
                    }
                }
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(ans[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl2ex7()
        {
            double[,] mat = new double[6, 6];
            double max = double.MinValue;
            int maxi = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (i == j && mat[i, j] > max)
                    {
                        max = mat[i, j];
                        maxi = j;
                    }
                }
            }
            for (int i = 0; i < maxi; i++)
            {
                for (int j = i + 1; j < 6; j++)
                {
                    mat[i, j] = 0;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl2ex8()
        {
            double[,] mat = new double[6, 6];
            int max0 = 0;
            int max1 = 0;
            double tmp = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (mat[i, j] > mat[i, max0] && (i % 2 == 0))
                    {
                        max0 = j;
                    }
                    if (mat[i, j] > mat[i, max1] && (i % 2 == 1))
                    {
                        max1 = j;
                    }
                }
                if (i % 2 == 1)
                {
                    tmp = mat[i - 1, max0];
                    mat[i - 1, max0] = mat[i, max1];
                    mat[i, max1] = tmp;
                    max0 = 0;
                    max1 = 0;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl2ex9()
        {
            double[,] mat = new double[6, 7];
            double tmp = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                }
                for (int k = 0; k < 3; k++)
                {
                    tmp = mat[i, k];
                    mat[i, k] = mat[i, 6 - k];
                    mat[i, 6 - k] = tmp;
                }
            }
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl3ex1()
        {
            double[,] mat = new double[7, 5];
            double[,] ans = new double[7, 5];
            double[] arr = new double[7];
            double min = double.MaxValue;
            int tmp = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (mat[i, j] < min)
                    {
                        min = mat[i, j];
                    }
                }
                arr[i] = min;
                min = double.MaxValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        tmp = j;
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    ans[i, j] = mat[tmp, j];
                }
                arr[tmp] = double.MaxValue;
                min = double.MaxValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(ans[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl3ex2()
        {
            Console.WriteLine("Enter size of square: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[,] mat = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (i == 0 || j == 0 || i == size - 1 || j == size - 1)
                    {
                        mat[i, j] = 0;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl3ex3()
        {
            Console.WriteLine("Enter size of square: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[,] mat = new double[size, size];
            double[] sum = new double[size * 2 - 1];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                }
            }
            double tmp = 0, tmp1 = 0, tmp2 = 0;
            int help;
            for (int i = size - 1; i >= 0; i--)
            {
                help = i;
                for (int j = 0; j < size - i && i > 0; j++)
                {
                    tmp += mat[help, j];
                    tmp1 += mat[j, help];
                    help++;
                }
                tmp2 += mat[i, i];
                sum[size - 1 - i] = tmp;
                sum[size - 1 + i] = tmp1;
                tmp = 0;
                tmp1 = 0;
            }
            sum[size - 1] = tmp2;
            for (int i = 0; i < size * 2 - 1; i++)
            {
                Console.Write(sum[i] + "\t");
            }
        }
        public static void lvl3ex4()
        {
            Console.WriteLine("Enter size of square: ");
            int size = Convert.ToInt32(Console.ReadLine());
            double[,] mat = new double[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (i >= j && i > (size / 2 - size % 2))
                    {
                        mat[i, j] = 1;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl3ex8()
        {
            double[,] mat = new double[7, 5];
            double[,] ans = new double[7, 5];
            int[] arr = new int[7];
            int count = 0;
            int tmp = 0;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (mat[i, j] >= 0)
                    {
                        count++;
                    }
                }
                arr[i] = count;
                count = 0;
            }
            int max = int.MinValue;
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    if (arr[j] > max)
                    {
                        max = arr[j];
                        tmp = j;
                    }
                }
                for (int j = 0; j < 5; j++)
                {
                    ans[i, j] = mat[tmp, j];
                }
                arr[tmp] = int.MinValue;
                max = int.MinValue;
            }
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(ans[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl3ex10()
        {
            double[,] mat = new double[3, 5];
            double tmp = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                }
                for (int j = 0; j < 5; j += 1)
                {
                    if (i % 2 == 0)
                    {
                        int sort = 0;
                        while (sort < 5)
                        {
                            if (sort == 0 || mat[i, sort - 1] >= mat[i, sort])
                            {
                                sort++;
                            }
                            else
                            {
                                double swap = mat[i, sort];
                                mat[i, sort] = mat[i, sort - 1];
                                mat[i, sort - 1] = swap;
                                sort--;
                            }
                        }
                    }
                    else
                    {
                        int sort = 0;
                        while (sort < 5)
                        {
                            if (sort == 0 || mat[i, sort - 1] <= mat[i, sort])
                            {
                                sort++;
                            }
                            else
                            {
                                double swap = mat[i, sort];
                                mat[i, sort] = mat[i, sort - 1];
                                mat[i, sort - 1] = swap;

                                sort--;
                            }
                        }
                    }
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mat[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
        public static void lvl3ex11()
        {
            int n, m;
            Console.WriteLine("Enter size of matrix: ");
            int.TryParse(Console.ReadLine(), out n);
            int.TryParse(Console.ReadLine(), out m);
            List<int> ints = new List<int>();
            bool flag = false;
            double[,] mat = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                flag = false;
                for (int j = 0; j < m; j++)
                {
                    Console.WriteLine($"Enter elemment of matrix [{i}; {j}]");
                    double.TryParse(Console.ReadLine(), out mat[i,j]);;
                    if (mat[i, j] == 0)
                    {
                        flag = true;
                    }
                }
                if (flag == false)
                {
                    ints.Add(i);
                }
            }
            double[,] ans = new double[ints.Count(), m];
            for (int i = 0; i < ints.Count(); i++)
            {
                for (int j = 0; j < m; j++)
                {
                    ans[i, j] = mat[ints[i], j];
                }
            }
            for (int i = 0; i < ints.Count(); i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(ans[i, j] + "\t");
                }
                Console.WriteLine(" ");
            }
        }
    }
}
