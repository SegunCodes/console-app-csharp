using ConsoleApp;
using System;

ArithmeticOperation operation = new ArithmeticOperation(4, 5);
operation.division();

Class1 child = new Class1(6, 4);
child.addition(); // this is a function in its parent class called ArithmeticOperation
child.modulus(); // this is a function in class1

Class2 grandChild = new Class2(5,3);
grandChild.modulus();    // this is a function in its parent class called class1
grandChild.addition();  // this is a function in its grandparent class called ArithmeticOperation

Console.ReadKey();