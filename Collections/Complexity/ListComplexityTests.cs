namespace Collections.Complexity;

public class ListComplexityTests : ComplexityTests
{
    #region List

        public async Task List_Indexing()
        {
            var shortList = new List<string>(shortArray);
            GetElementFromList(shortList);
                
            var middleList = new List<string>(middleArray);
            GetElementFromList(middleList);
                
            var longList = new List<string>(longArray);
            GetElementFromList(longList);
        }
        
        public async Task List_Find()
        {
            var shortList = new List<string>(shortArray);
            FindElementInList(shortList, shortList.Last());

            var middleList = new List<string>(middleArray);
            FindElementInList(middleList, middleList.Last());

            var longList = new List<string>(longArray);
            FindElementInList(longList, longList.Last());
        }
        
        private void GetElementFromList(List<string> list, bool loggingEnabled = true)
        {
            RunWithStopwatch(() =>
                {
                    var element = list[list.Count -1];
                },
                loggingEnabled);
        }
        
        private void FindElementInList(List<string> list, string item, bool loggingEnabled = true)
        {
            RunWithStopwatch(() =>
                {
                    list.Find(e=> e == item);
                },
                loggingEnabled);
        }

    #endregion
}