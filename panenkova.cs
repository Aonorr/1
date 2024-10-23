using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.Metrics;
using System.Runtime.InteropServices;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        //program.Task_1_1(0.9, 1.23);
        //program.Task_1_2(0.9, 1.23);
        //program.Task_1_3(0.9, 1.23);
        //program.Task_1_4(0.9, 1.23, -0.1);
        //program.Task_1_5(0.9, 1.23);
        //program.Task_1_6(0.9, 1.23);
        //program.Task_1_7(0.9);
        //program.Task_1_8(0.9);
        //program.Task_1_9(0.9);
        //program.Task_1_10(0.9);
        //program.Task_2_1(10);
        //program.Task_2_2(5, 3, 2, 1);
        //program.Task_2_2(5, 1.5, 1.5, 1);
        //program.Task_2_2(5, 1, 3, 1);
        //program.Task_2_3(10);
        //program.Task_2_4(5, 1, 2);
        //program.Task_2_5(10, 30);
        //program.Task_2_6(5);
        //program.Task_2_7(5);
        //program.Task_2_8(5);
        //program.Task_2_9(10);
        //program.Task_2_10(10);
        //program.Task_2_11(10);
        //program.Task_2_12(10, 0);
        program.Task_2_13(10, 5, 0);
        //program.Task_3_1();
        //program.Task_3_2(3, 2, 1);
        //program.Task_3_2(1.5, 1.5, 1);
        //program.Task_3_2(1, 3, 1);
        //program.Task_3_3();
        //program.Task_3_4(1, 2);
        //program.Task_3_5(30);
        //program.Task_3_6();
        //program.Task_3_7();
        //program.Task_3_8();
        //program.Task_3_9();
        //program.Task_3_10();
        //program.Task_3_11();
        //program.Task_3_12(10, 0);
        //program.Task_3_13(10, 5, 0);
    }
    #region Level 1
    public bool Task_1_1(double x, double y)
    {
        bool answer = false; int r = 2;
        if (Math.Abs(x * x + y * y - r * r) <= 1 / 1000)
            answer = true;
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public bool Task_1_2(double x, double y)
    {
        bool answer = false;
        // code here
        if (y >= 0 && y + Math.Abs(x)<=1)
            answer = true;
        // end
        return answer;
    }
    public double Task_1_3(double a, double b)
    {
        double answer = 0;
        // code here
        if (a > 0)            
            if (b > a)
                answer =  b;
            else 
                answer = a;
        if (a<= 0)
            if (b > a)
                answer = a;
            else
                answer = b;
        // end
        return answer;
    }
    public double Task_1_4(double a, double b, double c)
    {
        double answer = 0;
        // code here
        if (a > b)
            answer = b;
        else
            answer = a;
        if (answer > c)
            return answer;
        else
            answer = c;
        // end
        return answer;
    }
    public bool Task_1_5(double r, double s)
    {
        bool answer = false;
        // code here
        if (2 * Math.Sqrt(r / Math.PI) > Math.Sqrt(s) * Math.Sqrt(2)) 
            return answer = true;
        // end
        return answer;
    }
    public bool Task_1_6(double r, double s)
    {
        bool answer = false;
        // code here
        if (2 * Math.Sqrt(r / Math.PI) < Math.Sqrt(s))
            return answer = true;
        // end
        return answer;
    }
    public double Task_1_7(double x)
    {
        double answer = 0;
        // code here
        if (Math.Abs(x)>1)
            answer = 1;
        if (Math.Abs(x)<=1)
            return Math.Abs(x);

        // end
        return answer;
    }
    public double Task_1_8(double x)
    {
        double answer = 0;
        // code here
        if (Math.Abs(x)>=1)
            answer = 0;
        if (Math.Abs(x) < 1)
            answer = x * x - 1;
        // end
        return answer;
    }
    public double Task_1_9(double x)
    {
        double answer = 0;
        // code here
        if (x<=-1)
            answer = 0;
        if (x <= 0 && -1 < x)
            answer = 1+x;
        if (x > 0)
            answer = 1;
        // end
        return answer;
    }
    public double Task_1_10(double x)
    {
        double answer = 0;
        // code here
        if (x<= -1)
            answer = 1;
        if (x > 1)
            answer = -1;
        if (x <= 1 && -1 < x)
            answer = -x;
        // end
        return answer;
    }
    #endregion

    #region Level 2
    public double Task_2_1(int n)
    {
        double answer = 0; double i = 0;
        // code here
        for (int p = 0; p < n; p++)
        {
            i = i + int.Parse(Console.ReadLine());
            answer = i / n * 1.0;
        }
        answer = Math.Round(answer, 2);
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public int Task_2_2(int n, double r, double a, double b)
    {
        int answer = 0; double i = 0, c = 0;
        // code here
        for (int p = 0; p < n; p++)
        {
            i = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());
            if (r >= Math.Sqrt((a - i) * (a - i) + (b - c) * (b - c)))
                answer += 1;
        }
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public double Task_2_3(int n)
    {
        double answer = 0, c = 0;
        // code here
        for ( int i = 0; i < n; i++)
        {
            c = double.Parse(Console.ReadLine());
            if (c < 30)
                answer = answer + 200;
        }
        answer = answer / 1000;
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public int Task_2_4(int n, double r1, double r2)
    {
        int answer = 0; double c = 0, d = 0;
        // code here
        for (int step = 0; step < n; step++)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (c*c + d*d>= r1*r1 && c * c + d * d <= r2 * r2)
                answer = answer + 1;
        }
        Console.WriteLine (answer);
        // end
        return answer;
    }
    public int Task_2_5(int n, double norm)
    {
        int answer = 0; double c = 0;
        // code here
        for ( int step = 0; step<n; step++)
        {
            c = double.Parse(Console.ReadLine());
            if (c <= norm)
                answer = answer + 1;
        }
        // end
        Console.WriteLine (answer);
        return answer;
    }
    public int Task_2_6(int n)
    {
        int answer = 0;double c = 0, d = 0;
        // code here
        for (int step = 0; step < n; step++)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if ((c >= 0) && (c<= Math.PI) && ( Math.Sin(c) >= d ))
                answer = answer + 1;
        }
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public (int, int) Task_2_7(int n)
    {
        int answer1 = 0; int answer3 = 0; double c = 0, d = 0; 
        // code here
        for (int step = 0;step<n; step++)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (c>0 && d>0)
                answer1 = answer1 + 1;
            if (c<0 && d<0)
                answer3 = answer3 + 1;
        }
        Console.WriteLine(answer1);
        Console.WriteLine(answer3);
        // end
        return (answer1, answer3);
    }
    public (int, double) Task_2_8(int n)
    {
        int answer = 0; double answerLength = double.MaxValue;
        double c = 0, d = 0;
        // code here
        for (int step = 1;step<=n;step++)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (Math.Sqrt(c*c+d*d) <  answerLength)
            {
                answer = step;
                answerLength = Math.Sqrt(c * c + d * d);
            }
        }
        answerLength = Math.Round(answerLength, 2);
        Console.WriteLine(answer);
        Console.WriteLine(answerLength);
        // end
        return (answer, answerLength);
    }
    public double Task_2_9(int n)
    {
        double answer = double.MaxValue; double c = 0;
        // code here
        for (int step = 0;step<n; step++)
        {
            c = double.Parse(Console.ReadLine());
            if (c <= answer)
                answer = c;
        }
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public int Task_2_10(int n)
    {
        int answer = 0; double c = 0, d = 0, p = 0, k = 0;
        // code here;
        for ( int  step = 0;step<n; step++)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());
            k = double.Parse(Console.ReadLine());
            if (c > 3 && d > 3 && p > 3 && k > 3)
                answer = answer + 1;
        }
        Console.WriteLine(answer);
        // end
        return answer;
    }
    public (int, double) Task_2_11(int n)
    {
        int answer = 0; double avg = 0.0; 
        double c = 0, d = 0, p = 0, k = 0;
        // code here;
        for (int step = 0; step < n; step++)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());
            k = double.Parse(Console.ReadLine());
            avg += c + d + p + k;
            if (c < 3 || d < 3 || p < 3 || k < 3)
            {
                answer = answer + 1;
            }
        }
        avg = avg / (n * 4);
        Console.WriteLine(answer);
        Console.WriteLine(avg);
            // end
            return (answer, avg);
    }
    public double Task_2_12(double r, int type)
    {
        double answer = 0;
        // code here;
            if (r < 0) return answer = 0;
            switch (type)
            {
                case 0:
                    answer = (r * r);
                    answer = Math.Round((r * r), 2);
                    break;
                case 1:
                    answer = (Math.PI * r * r);
                    answer = Math.Round(answer, 2);
                    break;
                case 2:
                    answer = ((r * r * Math.Sqrt(3)) / 4);
                    answer = Math.Round(answer, 2);
                    break;
                default:
                    break;
            }
            // end
            return answer;
    }
    public double Task_2_13(double A, double B, int type)
    {
        double answer = 0;
        // code here;
        if (A <= 0 || B <= 0) return answer = 0;
        switch (type)
        {
            case 0:
                answer = Math.Round((A * B), 2);
                break;
            case 1:
                if (A > B)
                {
                    answer = (Math.PI * (A * A - B * B));
                    answer = Math.Round(answer, 2);
                }
                else if (B > A)
                {
                    answer = (Math.PI * (B * B - A * A));
                    answer = Math.Round(answer, 2);
                }
                break;
            case 2:
                answer = (Math.Sqrt(((A + B + B) / 2) * (((A + B + B) / 2) - A) * (((A + B + B) / 2) - B) * (((A + B + B) / 2) - B)));
                answer = Math.Round(answer, 2);
                if (answer > 0)
                    return answer;
                else
                {
                    return answer = 0;
                }
                break;
            default:
                break;
                // end
        }
     return answer;
    }
    #endregion

    #region Level 3
    public double Task_3_1()
    {
        double answer = 0; double i = 0, c = 0;
        double n = 0;
        // code here
        while (true)
        {
            c = double.Parse(Console.ReadLine());
            if (c == 1)
            {
                answer = Math.Round(answer, 2);
                Console.WriteLine(answer);
                break;
            }
            i = i + c;
            n++;
            answer = i / n * 1.0;
        }
        answer = Math.Round(answer, 2);
        // end
        // answer should be equal to the task_2_1 answer
        return answer;
    }
    public int Task_3_2(double r, double a, double b)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public double Task_3_3()
    {
        double answer = 0;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_4(double r1, double r2)
    {
        int answer = 0, n = 0; double c = 0, d = 0;
        // code here
        while (true)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (c == 10 || d == 10)
            {
                Console.WriteLine(answer);
                break;
            }
            if (c * c + d * d >= r1 * r1 && c * c + d * d <= r2 * r2)
            {
                answer = answer + 1;
            }
        }
        // end
        return answer;
    }
    public int Task_3_5(double norm)
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_6()
    {
        int answer = 0, n = 0;

        // code here

        // end

        return answer;
    }
    public (int, int) Task_3_7()
    {
        int answer1 = 0, answer3 = 0, n = 0;
        double c = 0, d = 0;
        // code here
        while (true)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            if (c == 10 || d == 10)
            {
                Console.WriteLine(answer1);
                Console.WriteLine(answer3);
                break;
            }
            if (c > 0 && d > 0)
                answer1 = answer1 + 1;
            if (c < 0 && d < 0)
                answer3 = answer3 + 1;
        }
        // end
        return (answer1, answer3);
    }
    public (int, double) Task_3_8()
    {
        int answer = 0, n = 0;
        double answerLength = double.MaxValue;

        // code here

        // end

        return (answer, answerLength);
    }
    public double Task_3_9()
    {
        double answer = double.MaxValue;
        int n = 0;

        // code here

        // end

        return answer;
    }
    public int Task_3_10()
    {
        int answer = 0, n = 0; double c = 0, d = 0, p = 0, k = 0;
        // code here;
        while (true)
        {
            c = double.Parse(Console.ReadLine());
            d = double.Parse(Console.ReadLine());
            p = double.Parse(Console.ReadLine());
            k = double.Parse(Console.ReadLine());
            if (c == 10 || d == 10 || p == 10 || k == 10)
            {
                Console.WriteLine(answer);
                break;
            }
            if (c > 3 && d > 3 && p > 3 && k > 3)
                answer = answer + 1;
        }
        // end
        return answer;
    }
    public (int, double) Task_3_11()
    {
        int answer = 0, n = 0;
        double avg = 0.0;

        // code here;

        // end

        return (answer, avg);
    }
    #endregion
}