namespace Collections;

public static class LinkedListExperiments
{
    public static void Do()
    {
        var list = new LinkedList<string>();
        list.AddFirst("first");
        list.AddLast("second");
        list.AddLast("third");
        
        var thirdNode = list.Find("third");
        list.AddBefore(thirdNode, "fourth");

        list.RemoveLast();
        list.RemoveFirst();
        
        foreach (var item in list)
        {
            
        }
    }
}