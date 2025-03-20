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
}

public class Program() {
    public static void Main(string[] args) { 
        PemrosesData data = new PemrosesData();
        Console.WriteLine("Nilai Max : " + data.DapatkanNilaiTerbesar<int>(1030, 2230, 0148));
    }
}