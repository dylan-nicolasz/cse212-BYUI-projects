using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Add items with different priorities and tied prioties
    // Expected Result: The highest priority first and ties follow the FIFO model
    // Defect(s) Found: The program made the highest priority search skipped the list item and it made the dequeue not to remove from the list.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();

        priorityQueue.Enqueue("Bob", 2);
        priorityQueue.Enqueue("Tim", 5);
        priorityQueue.Enqueue("Sue", 5);
        priorityQueue.Enqueue("George", 1);

        Assert.AreEqual("Tim", priorityQueue.Dequeue());
        Assert.AreEqual("Sue", priorityQueue.Dequeue());
        Assert.AreEqual("Bob", priorityQueue.Dequeue());
        Assert.AreEqual("George", priorityQueue.Dequeue());

    }

    [TestMethod]
    // Scenario: Remove items from the empty queue
    // Expected Result: Create a message for the InvalidOperationException
    // Defect(s) Found: There wasn't a deffect after the code was fixed
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();

        try
        {
            priorityQueue.Dequeue();
            Assert.Fail("Exception shold have been thrown");
        }
        catch (InvalidOperationException e)
        {
            Assert.AreEqual("The queue is empty.", e.Message);
        }

    }

    // Add more test cases as needed below.
}