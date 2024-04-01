using ConsoleApp;
using System;
using System.Security.Cryptography;

ArithmeticOperation operation = new ArithmeticOperation(4, 5);
operation.division();

Class1 child = new Class1(6, 4);
child.addition(); // this is a function in its parent class called ArithmeticOperation
child.modulus(); // this is a function in class1

Class2 grandChild = new Class2(5,3);
grandChild.modulus();    // this is a function in its parent class called class1
grandChild.addition();  // this is a function in its grandparent class called ArithmeticOperation

//method overriding, to override an inherited method, it must be abstract or virtual. It can also be used to override the ToString method

// Abstraction in OOP is used to hide unnecessary information and display only necessary information to the users interacting
Class4 class4 = new Class4();
class4.students();
class4.student(4);

//interface is similar to abstraction just that for every method in an interface, it must be implemented by it's child class
Class5 class5 = new Class5();
class5.teacher();

//ToString converts a datatype to a string
Human human = new Human("74", "80", "34");
Console.WriteLine(human);

Animal[] animals = new Animal[2];
animals[0] = new Goat();
animals[1] = new Cat();
foreach (Animal animal in animals)
{
    animal.makeSound();
}
//Poly - plenty
//morphology - structure
//polymorphism - many different forms

Console.ReadKey();


class Human
{ 
    string height;
    string weight;
    string age;
    public Human(string height, string weight, string age) {
        this.height = height;
        this.age = age;
        this.weight = weight;
    }

    public override string ToString()
    {
        string message = "The " + age + " year old human has a weight of " + weight + " kg and a height of " + height + " cm";
        return message;
    }

}

// POLYMORPHISM
class Animal
{
    public virtual void makeSound()
    {
        Console.WriteLine("Animal has made a sound");
    }
}

class Goat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Goat has bleat");
    }
}

class Cat : Animal
{
    public override void makeSound()
    {
        Console.WriteLine("Cat has meowed");
    }
}