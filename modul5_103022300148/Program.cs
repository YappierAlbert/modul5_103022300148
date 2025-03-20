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

public class PemrosesData() {
    public dynamic DapatkanNilaiTerbesar<T>(T x1, T x2, T x3) {
        dynamic x = x1;
        dynamic y = x2;
        dynamic z = x3;
        if (x > y)
        {
            return x;
        }
        else if (z > y)
        {
            return z;
        }
        else {
            return y;

        }
}
public class Program() {
    public static void Main(string[] args) { 
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Nilai Max : " + data.DapatkanNilaiTerbesar<int>(10, 30, 22));
        SimpleDataBase<int> sDB = new SimpleDataBase<int>();
        sDB.addNewData(10);
        sDB.addNewData(30);
        sDB.addNewData(22);
        sDB.printAllData();
    }
}