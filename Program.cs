// multithreading enables developers to write applications that can perform multiple tasks concurrently.
using System;
using System.Threading;

// create a thread
Thread thread = new Thread(TestMethod);

thread.Start();

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("second thread is working");
}

// wait for the function  thread to complete then it joins
thread.Join();

Console.WriteLine("Done");

static void TestMethod()
{
    for (int i = 0; i < 10; i++)
    {
        Console.WriteLine("Function is working");
    }
}