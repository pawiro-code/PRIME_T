using System;

public class Liczba
{
    internal int liczba { get; set; }
    public Liczba(int liczba)
    {
        this.liczba = liczba;
    }
    public Liczba()
    {

    }
}
public class Pierwsza : Liczba
{
    internal string odpowiedz = "";
    public Pierwsza(int liczba) : base(liczba)
    {

    }
    public Pierwsza()
    {

    }

    public string SprawdzCzyPierwsza(int liczba)
    {
        int tmp = liczba;
        if(tmp == 1)
        {
            return "NIE";
        }
        for (int i = 2; i < liczba; i++)
        {
            if ((tmp % i) != 0)
                continue;
            else
                return "NIE";
        }
       return "TAK"; 
    }
}

public class Program
{
    public static void Main()
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] tab = new string[n];
        Pierwsza pierwsza = new Pierwsza();

        for(int i = 0; i < n; i++)
        {
            int tmp = Int32.Parse(Console.ReadLine());
            tab[i] = pierwsza.SprawdzCzyPierwsza(tmp);
            //Console.WriteLine(pierwsza.SprawdzCzyPierwsza(tmp));
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine(tab[i]);
    }
}
