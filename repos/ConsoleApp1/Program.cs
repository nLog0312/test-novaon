// See https://aka.ms/new-console-template for more information
using System.Numerics;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

try
{
    List<int> data = new List<int>();
    using (StreamReader sr = new StreamReader("C:\\Users\\Admin\\source\\repos\\In.txt"))
    {
        string line;

        // doc va hien thi cac dong trong file cho toi
        // khi tien toi cuoi file. 
        while ((line = sr.ReadLine()) != null)
        {
            data.Add(int.Parse(line));
        }
    }
    // Tạo từ điển để đếm số lần xuất hiện
    Dictionary<int, int> countDict = new Dictionary<int, int>();

    // Duyệt qua từng phần tử và cập nhật số lần xuất hiện
    foreach (int number in data)
    {
        if (countDict.ContainsKey(number))
        {
            countDict[number]++;
        }
        else
        {
            countDict[number] = 1;
        }
    }

    using (StreamWriter sw = new StreamWriter("C:\\Users\\Admin\\source\\repos\\Out.txt"))
    {

        foreach (var s in countDict)
        {
            sw.WriteLine(s.Key.ToString() + ": " + s.Value);
        }
    }

    Console.ReadKey();
}
catch (Exception e)
{
    // thong bao loi.
    Console.WriteLine("Khong the doc du lieu tu file da cho: ");
    Console.WriteLine(e.Message);
}
