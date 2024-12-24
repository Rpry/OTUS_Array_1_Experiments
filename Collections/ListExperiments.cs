namespace Collections;

public static class ListExperiments
{
    public static void Do()
    {
        var list = new List<string>();
        list.Add("one");
        list.Add("two");
        
        list.Insert(1, "ten");
        list.Remove("ten");
    }
}