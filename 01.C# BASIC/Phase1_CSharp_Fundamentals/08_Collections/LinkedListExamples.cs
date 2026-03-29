internal static class LinkedListExamples
{
    public static void Run()
    {
        PrintSeparator();
        ShowLinkedListBasics();
        PrintSeparator();
        ShowImportantLinkedListMembers();
    }

    #region 01 - LinkedList Basics
    private static void ShowLinkedListBasics()
    {
        // LinkedList<T> stores items as nodes connected to each other.
        // It is good when you insert or remove items often at known positions.
        // Common operations are AddFirst, AddLast, and traversal through nodes.
        // This is useful in playlists, navigation chains, and scheduler flows.

        LinkedList<string> trainCoaches = new();
        trainCoaches.AddFirst("Engine");
        trainCoaches.AddLast("Coach-A");
        trainCoaches.AddLast("Coach-B");
        trainCoaches.AddLast("Guard");

        Console.WriteLine("\n01 - LinkedList Basics"); // Output: 01 - LinkedList Basics
        Console.WriteLine($"First Coach: {trainCoaches.First!.Value}"); // Output: First Coach: Engine
        Console.WriteLine($"Last Coach: {trainCoaches.Last!.Value}"); // Output: Last Coach: Guard
        Console.WriteLine($"Total Nodes: {trainCoaches.Count}"); // Output: Total Nodes: 4

        LinkedListNode<string>? currentNode = trainCoaches.First;
        while (currentNode is not null)
        {
            Console.WriteLine($"Coach: {currentNode.Value}"); // Output: Coach: Engine ... Coach: Guard
            currentNode = currentNode.Next;
        }

        // Mistake:
        // LinkedList<T> is not a good choice when you need fast random access by index.
        // If you often need collection[index], List<T> is usually a better fit.

        // 🌍 Real-World Analogy:
        // Think of a LinkedList like train coaches connected one by one.
        // Each coach knows the next coach, but there is no direct jump to the middle by index.
    }
    #endregion

    #region 02 - Important LinkedList Members
    private static void ShowImportantLinkedListMembers()
    {
        // Find returns the node reference, not just the value.
        // AddAfter and AddBefore are very useful when insertion must happen around a known node.
        // Remove deletes by value or node.
        // First and Last give quick access to the ends of the linked list.

        LinkedList<string> playlist = new();
        playlist.AddLast("Song-1");
        playlist.AddLast("Song-3");

        LinkedListNode<string>? songOneNode = playlist.Find("Song-1");
        if (songOneNode is not null)
        {
            playlist.AddAfter(songOneNode, "Song-2");
        }

        playlist.Remove("Song-3");

        Console.WriteLine("\n02 - Important LinkedList Members"); // Output: 02 - Important LinkedList Members
        Console.WriteLine($"First Song: {playlist.First!.Value}"); // Output: First Song: Song-1
        Console.WriteLine($"Last Song: {playlist.Last!.Value}"); // Output: Last Song: Song-2
        Console.WriteLine($"Contains Song-2: {playlist.Find("Song-2") is not null}"); // Output: Contains Song-2: True

        foreach (string song in playlist)
        {
            Console.WriteLine($"Playlist Item: {song}"); // Output: Playlist Item: Song-1 ... Playlist Item: Song-2
        }

        // Mistake:
        // LinkedList<T>.Find can return null when the item does not exist.
        // Always null-check the node before AddAfter, AddBefore, or node-based removal.

        // 🌍 Real-World Analogy:
        // Think of LinkedList methods like managing train coaches or a music playlist.
        // Once you find one coach or song, you can attach another item before or after it easily.
    }
    #endregion

    private static void PrintSeparator()
    {
        Console.WriteLine("\n========================================\n"); // Output: ========================================
    }
}
