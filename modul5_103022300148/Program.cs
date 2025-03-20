public class SimpleDataBase<T> { 
    private List<T> storedData;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        storedData = new List<T>();
        inputDates = new List<DateTime>();
    }

    public void addNewData(T data) { 
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void printAllData() {
        for (int i = 0; i < storedData.Count; i++) {
            Console.WriteLine("Data " + (i + 1) + " berisi : " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i]);
        }
    }
}

public class Program() {
    public static void Main(string[] args) {
        SimpleDataBase<int> sDB = new SimpleDataBase<int>();
        sDB.addNewData(10);
        sDB.addNewData(30);
        sDB.addNewData(22);
        sDB.printAllData();
    }
}