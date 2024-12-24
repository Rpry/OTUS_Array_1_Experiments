using System.Collections;

namespace Collections;

public static class ArrayExperiments
{
    public static void ExemplarMethods()
    {
        var array = new string[3,2];
        var rank = array.Rank;
        var upperLength1 = array.GetLength(0);
        var upperLength2 = array.GetLength(1);
        var length = array.Length;
    }
    
    public static void StaticMethods()
    {
        var array = new int[] { 1, 2, 4, 6, 8, 10 };
        var element = Array.FindIndex(array, (e)=> e == 4);
        var index = Array.BinarySearch(array, 4);
        Array.Reverse(array);
        
        var newArray = Array.ConvertAll<int, long>(array, input =>  input * 4);
        
        var index1 = Array.LastIndexOf(array, 4);

    }

    public static void IStructuralEquatable()
    {
        var array1 = new int[] { 1, 2, 4, 4, 8, 10 };
        var array2 = new int[] { 1, 2, 4, 4, 8, 10 };

        Console.WriteLine(array1.Equals(array2));
        Console.WriteLine(((IStructuralEquatable)array1).Equals(array2, EqualityComparer<int>.Default));
        
        Console.WriteLine((array1).GetHashCode());
        Console.WriteLine((array2).GetHashCode());
        Console.WriteLine(((IStructuralEquatable)array1).GetHashCode(EqualityComparer<int>.Default));
        Console.WriteLine(((IStructuralEquatable)array2).GetHashCode(EqualityComparer<int>.Default));
    }
    
    public static void ICollection()
    {
        var array1 = new int[] { 1, 2, 4, 4, 8, 10 };
        //var count = array1.Count;
        var syncRoot = array1.SyncRoot;
        var isSynchronized = array1.IsSynchronized;
    }
    
    public static void IList()
    {
        var array1 = new int[] { 1, 2, 4, 4, 8, 10 };
        //array1.Add();
    }
    
    public static void IStructuralComparable()
    {
        var array1 = new int[] { 1, 2, 4, 4, 8, 10 };
        var array2 = new int[] { 1, 2, 4, 4, 8, 10 };

        Console.WriteLine(((IStructuralComparable)array1).CompareTo(array2, Comparer<int>.Default));
    }
    
    public static void CreateInstance()
    {
        Array numbers = Array.CreateInstance(
            typeof(double),
            new int[] { 10 },
            new int[] { 2 });
    }
}