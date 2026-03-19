using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Test a priority queue, test the enqueue operation that will add the value pair with item and value.
    // The value, being the string, and the priority, being the integer.
    // Add the following values: "Carlos" (2), "Jose" (3), "Jonathan" (4), "Jorge" (4), "Maria" (1), "Juan" (6) and run until the queue is empty.
    // Expected Result: The values should be dequeued in the order of their priority, with higher priority values dequeued first.
    // Defect(s) Found: 
    public void TestPriorityQueue_1()
    {
        var carlos = new PriorityItem("carlos", 2);
        var jose = new PriorityItem("jose", 3);
        var jonathan = new PriorityItem("jonathan", 4);
        var jorge = new PriorityItem("jorge", 4);
        var maria = new PriorityItem("maria", 1);
        var juan = new PriorityItem("juan", 6);

        PriorityItem[] expectedOrder = [juan, jonathan, jorge, jose, carlos, maria];

        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue(carlos.Value, carlos.Priority);
        priorityQueue.Enqueue(jose.Value, jose.Priority);
        priorityQueue.Enqueue(jonathan.Value, jonathan.Priority);
        priorityQueue.Enqueue(jorge.Value, jorge.Priority);
        priorityQueue.Enqueue(maria.Value, maria.Priority);
        priorityQueue.Enqueue(juan.Value, juan.Priority);
        for (int i = 0; i < expectedOrder.Length; i++)
        {
            var item = priorityQueue.Dequeue();
            Assert.AreEqual(expectedOrder[i].Value, item);
        }
    }

    [TestMethod]
    // Scenario: If the queue is empty, then an error exception shall be thrown.
    // This exception should be an InvalidOperationException with a message of "The queue is empty."
    // Expected Result: An InvalidOperationException is thrown with the message "The queue is empty."
    // Defect(s) Found: 
    public void TestPriorityQueue_2()
    {

        var priorityQueue = new PriorityQueue();
        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Expected an InvalidOperationException to be thrown.");
        }
        catch (InvalidOperationException ex)
        {
            Assert.AreEqual("The queue is empty.", ex.Message);
        }

    }

    // Add more test cases as needed below.
}