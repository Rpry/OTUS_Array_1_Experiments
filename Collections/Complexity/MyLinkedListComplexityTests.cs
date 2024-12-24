namespace Collections.Complexity;

public class MyLinkedListComplexityTests : ComplexityTests
{
    public MyLinkedListComplexityTests()
    {
    }

    #region MyLinkedList

    public async Task MyLinkedList_AddBefore()
    {
        var shortCollection = ConvertArrayToMyLinkedList(shortArray);
        AddBefore(shortCollection, shortCollection.Tail, "new");
                
        var middleCollection = ConvertArrayToMyLinkedList(middleArray);
        AddBefore(middleCollection, middleCollection.Tail, "new");
                
        var longCollection = ConvertArrayToMyLinkedList(longArray);
        AddBefore(longCollection, longCollection.Tail, "new");
    }
        
    private void AddBefore(MyLinkedList<string> linkedList, Node<string> node, string newElement, bool loggingEnabled = true)
    {
        RunWithStopwatch(() =>
            {
                linkedList.AddBefore(newElement, node);
            },
            loggingEnabled);
    }
    
    private MyLinkedList<string> ConvertArrayToMyLinkedList(IEnumerable<string> array)
    {
        var list = new MyLinkedList<string>();
        foreach (var arrayElement in array)
        {
            list.AddLast(arrayElement);
        }

        return list;
    }

    #endregion
    
}