﻿using System.ComponentModel.DataAnnotations;

public class CopyConstructor
{
    public static void Main()
    {
        Test check1 = new(3);
        check1.Display();
        Test check2 = new(check1);
        check2.Display();
        Test check3 = new(check1,check2);
        check3.Display();
    }
}

public class Test
{
    int x;
    public Test(int i)
    {
        x = i;
    }
    public Test(Test obj) // Copy Constructor
    {
        x = obj.x;  // You are using previous object's x value and assigning it to current object x value
    }
    public Test(Test obj1, Test obj2)
    {
        x = obj1.x + obj2.x;
    }
    public void Display()
    {
        Console.WriteLine(x);
    }
}