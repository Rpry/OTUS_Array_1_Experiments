namespace Collections.Complexity;

public class ArrayComplexityTests : ComplexityTests
{
    #region List

        public async Task Array_Indexing()
        {
            var shortCollection = shortArray.ToArray();
            GetElementByIndex(shortCollection);
                
            var middleCollection = middleArray.ToArray();
            GetElementByIndex(middleCollection);
                
            var longCollection = longArray.ToArray();
            GetElementByIndex(longCollection);
        }
        
        public async Task Array_Find()
        {
            var shortCollection = shortArray.ToArray();
            FindElement(shortCollection, shortCollection.Last());

            var middleCollection = middleArray.ToArray();
            FindElement(middleCollection, middleCollection.Last());

            var longCollection = longArray.ToArray();
            FindElement(longCollection, longCollection.Last());
        }
        
        private void GetElementByIndex(string[] collection, bool loggingEnabled = true)
        {
            RunWithStopwatch(() =>
                {
                    var element = collection[collection.Count() -1];
                },
                loggingEnabled);
        }
        
        private void FindElement(string[] collection, string item, bool loggingEnabled = true)
        {
            RunWithStopwatch(() =>
                {
                    Array.Find(collection,e=> e == item);
                    //Array.BinarySearch(collection, 0, collection.Length, collection[collection.Length - 1]);
                },
                loggingEnabled);
        }

    #endregion
}