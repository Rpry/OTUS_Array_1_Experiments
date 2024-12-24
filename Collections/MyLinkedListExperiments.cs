namespace Collections;

public static class MyLinkedListExperiments
{
    public static void Do()
    {
        var list = new MyLinkedList<string>();
        list.AddFirst("1");
        list.AddLast("2");
        list.AddLast("3");
        list.AddLast("4");

        list.AddFirst("0");
        var node = list.AddLast("5");
        var node10 = list.AddBefore("10", node);
        list.AddAfter("11", node10);

        WriteElementsToConsole(list);
    }

    private static void WriteElementsToConsole(MyLinkedList<string> list)
    {
        var currentNode = list.Head;
        while (true)
        {
            Console.WriteLine(currentNode.Data);
            currentNode = currentNode.Next;
            if (currentNode == null)
            {
                break;
            }
        }
    }
}