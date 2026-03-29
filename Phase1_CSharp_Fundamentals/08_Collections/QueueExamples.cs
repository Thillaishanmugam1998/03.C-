internal static class QueueExamples
{
    public static void Run()
    {
        PrintSeparator();
        ShowQueueBasics();
        PrintSeparator();
        ShowImportantQueueMembers();
    }

    #region 01 - Queue (FIFO)
    private static void ShowQueueBasics()
    {
        // Queue<T> follows First In, First Out order.
        // The first item added is the first item removed.
        // Common operations are Enqueue, Dequeue, and Peek.
        // This is useful in ticket systems, message processing, and print jobs.

        Queue<string> supportTickets = new();
        supportTickets.Enqueue("Ticket-101");
        supportTickets.Enqueue("Ticket-102");
        supportTickets.Enqueue("Ticket-103");

        string nextTicket = supportTickets.Peek();
        string processedTicket = supportTickets.Dequeue();

        Console.WriteLine("\n01 - Queue (FIFO)"); // Output: 01 - Queue (FIFO)
        Console.WriteLine($"Next Ticket Before Dequeue: {nextTicket}"); // Output: Next Ticket Before Dequeue: Ticket-101
        Console.WriteLine($"Processed Ticket: {processedTicket}"); // Output: Processed Ticket: Ticket-101
        Console.WriteLine($"Current Front Ticket: {supportTickets.Peek()}"); // Output: Current Front Ticket: Ticket-102

        foreach (string ticket in supportTickets)
        {
            Console.WriteLine($"Pending Ticket: {ticket}"); // Output: Pending Ticket: Ticket-102 ... Pending Ticket: Ticket-103
        }

        // Mistake:
        // Using Queue<T> like a stack will give the wrong processing order.
        // Queue<T> is for oldest-first processing.

        // 🌍 Real-World Analogy:
        // Think of a queue like people waiting for movie tickets.
        // The person who came first gets served first.
    }
    #endregion

    #region 02 - Important Queue Members
    private static void ShowImportantQueueMembers()
    {
        // Count tells how many items are waiting.
        // Contains checks whether a specific item is already in the queue.
        // Clear empties the queue completely.
        // Peek and Dequeue should be used only when items are available.

        Queue<int> messageIds = new();
        messageIds.Enqueue(5001);
        messageIds.Enqueue(5002);
        messageIds.Enqueue(5003);
        bool contains5002 = messageIds.Contains(5002);
        int waitingCount = messageIds.Count;
        messageIds.Clear();

        Console.WriteLine("\n02 - Important Queue Members"); // Output: 02 - Important Queue Members
        Console.WriteLine($"Contains 5002: {contains5002}"); // Output: Contains 5002: True
        Console.WriteLine($"Count Before Clear: {waitingCount}"); // Output: Count Before Clear: 3
        Console.WriteLine($"Count After Clear: {messageIds.Count}"); // Output: Count After Clear: 0

        // Mistake:
        // Calling Peek() or Dequeue() on an empty queue throws InvalidOperationException.
        // Check Count before reading or removing.

        // 🌍 Real-World Analogy:
        // Think of queue members like checking a message-processing system.
        // You see how many messages are waiting and clear them when needed.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
