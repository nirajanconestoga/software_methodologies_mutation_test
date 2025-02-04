﻿namespace NMutationLab1;

public static class Triangle
{
    public static string IsoscelesTriangle(int firstSide, int secondSide, int thirdSide)
    {
        string result;
        if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
        {
            result = "The triangle is an isosceles triangle.";
        }
        else
        {
            result = "The triangle is not an isosceles triangle.";
        }
        return result;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Valid isosceles triangle
        int firstSide = 70;
        int secondSide = 70;
        int thirdSide = 60;
        string result = Triangle.IsoscelesTriangle(firstSide, secondSide, thirdSide);
        Console.WriteLine(result);
        Console.ReadLine();
    }
}
