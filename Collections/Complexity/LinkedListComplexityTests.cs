namespace Collections.Complexity;

public class LinkedListComplexityTests : ComplexityTests
{
    public LinkedListComplexityTests()
    {
    }

    #region LinkedList

    public async Task LinkedList_AddBefore()
    {
        var shortCollection = ConvertArrayToLinkedList(shortArray);
        AddBefore(shortCollection, shortCollection.Last, "new");

        var middleCollection = ConvertArrayToLinkedList(middleArray);
        AddBefore(middleCollection, middleCollection.Last, "new");
                
        var longCollection = ConvertArrayToLinkedList(longArray);
        AddBefore(longCollection, longCollection.Last, "new");
    }
        
    private void AddBefore(LinkedList<string> linkedList, LinkedListNode<string> node, string newElement, bool loggingEnabled = true)
    {
        RunWithStopwatch(() =>
            {
                linkedList.AddBefore(node, newElement);
            },
            loggingEnabled);
    }
    
    private LinkedList<string> ConvertArrayToLinkedList(IEnumerable<string> array)
    {
        var list = new LinkedList<string>();
        foreach (var arrayElement in array)
        {
            list.AddLast(arrayElement);
        }

        return list;
    }

    #endregion
    
}