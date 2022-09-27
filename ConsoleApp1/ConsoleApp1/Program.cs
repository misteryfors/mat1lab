﻿// See https://aka.ms/new-console-template for more information
using System.Text;
{ 
Console.WriteLine("Hello, World!");
double fxa = f(1.0);
double fx1a = f1(1.0);
double fx2a = f2(1.0);
double fxb = f(1.9);
double fx1b = f1(1.9);
double fx2b = f2(1.9);
    //Console.WriteLine(fxa + " " + fx2a + " " + fxb + " " + fx2b);
if ((fxa>0 & fx2a>0)| (fxa < 0 & fx2a < 0))
{
        iteration(1.9, 1.0,0.0001);
}
else if ((fxb > 0 & fx2b > 0) | (fxb < 0 & fx2b < 0))
    {
        iteration(1.0, 1.9, 0.0001);
    }
    else
        {
        //kombo(1.0, 1.9);
    }

    
}
double[][] iteration(double x1, double x2,double stop)
{
    List<double[]> kombo = new List<double[]>();
    double la = Math.Abs(1 / Math.Max(f1(x1), f1(x2)));
    while (true)
    {

        double[] line = new double[2];
        line[0] = x1;               
        line[1] = Math.Max(f(x1), f(x2));
        kombo.Add(line);
        x1 = x1 + la * line[1];
        if (Math.Abs(line[1]) < stop)
        {
            break;
        }

    }
    
    double[][] db = kombo.ToArray();
    for (int i = 0; i < db.Length; i++)
    {
        Console.WriteLine(db[i][0] + " " + db[i][1]);

    }
    return kombo.ToArray();
}
double[][] kombo(double x1,double x2,double stop)
{
    List<double[]> kombo = new List<double[]>();
    while (true)
    {
        
        double[] line = new double[6];
        line[0] = x1;
        line[1] = f(x1);
        line[2] = x2;
        line[3] = f(x2);
        line[4] = f(x1) * (x1 - x2) / (f(x1) - f(x2));
        line[5] = (f(x2) / f1(x2));
        kombo.Add(line);
        x1 = x1 - line[4];
        x2 = x2 - line[5];
        if (line[1] < stop | line[3]<stop)
        {
            break;
        }
    }
    
    double[][] db = kombo.ToArray();
    for (int i = 0; i < db.Length; i++)
    {
        Console.WriteLine(db[i][0] + " " + db[i][1] + " " + db[i][2] + " " + db[i][3] + " " + db[i][4] + " " + db[i][5]);

    }
    return kombo.ToArray(); 
}
double f(double x)
{
    return Math.Sin(x + 0.5) - 2 * x + 1.5;
}
double f1(double x)
{
    return Math.Cos(x + 0.5) - 2;
}
double f2(double x)
{
    return -Math.Sin(x + 0.5);
}
