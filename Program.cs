namespace Zadanie_1___Litera_a;

class Program
{
    static void Main(string[] args)
    {
        string readTxt = File.ReadAllText("C:/test/test_piotr_zarzycki.txt");
        Console.WriteLine("Tekst z pliku txt : " + readTxt);
        Console.WriteLine("Ilość 'a' w tym pliku : " + readTxt.Count(s => s == 'a'));
        
        // lub 2 sposob.
        
        int a = 0;
        for (int i = 0; i < readTxt.Length; i++)
        {
            if (readTxt[i] == 'a')
            {
                a += 1;
            }
        }
        
    }
}