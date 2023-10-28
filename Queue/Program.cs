using System;
using System.Collections.Generic;

public class Program
{
    private Queue<int> myQueue = new Queue<int>();

    public void Enqueue(int item)
    {
        myQueue.Enqueue(item);
    }

    public int Dequeue()
    {
        if (myQueue.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return myQueue.Dequeue();
    }

    public int Count
    {
        get { return myQueue.Count; }
    }

    static void Main()
    {
        // Example usage in Main method
        Program myQueueExample = new Program();

        myQueueExample.Enqueue(1);
        myQueueExample.Enqueue(2);

        Console.WriteLine("Dequeued item: {0}", myQueueExample.Dequeue());
        Console.WriteLine("Current count in the queue: {0}", myQueueExample.Count);
    }
}
