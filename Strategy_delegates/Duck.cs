using System;
using System.Collections;
using System.Collections.Generic;

public class Duck
{
    public Action Quack;
    public Action Fly;


    public void Swim()
    {
        System.Console.WriteLine("All duck float, even decoys!");
    }
}