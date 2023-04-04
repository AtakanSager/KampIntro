internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım geliştirici yetiştirme kampı ";


        //array - dizi

        string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı", 
            "Programlamaya başlangıç için temel kurs" ,"Java", "Python"};
        for (int i = 0; i < kurslar.Length; i++)  
        {
            Console.WriteLine(kurslar[i]);
        }

        Console.WriteLine("For bitti");

        foreach (string kurs in kurslar) 
        {
            Console.WriteLine(kurs);
        }
        Console.WriteLine("sayfa sonu - footer");
    }
}