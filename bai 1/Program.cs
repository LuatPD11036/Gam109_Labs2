using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class userData
{
    public int ID;
    public string userName;
    public int level;
    public userData(int ID, string userName, int level)
    {
        this.ID = ID;
        this.userName = userName;
        this.level = level;
    }
    public void showData()
    {
        Console.WriteLine("ID: " + ID);
        Console.WriteLine("User name : " + userName);
        Console.WriteLine("Level: " + level);

    }
    public void showData(dynamic attribute)
    {
        Console.WriteLine(attribute);
    }
}
internal class Program
{
    public static int Main(string[] args)
    {
        var x = 0;

        void bai1a()
        {
            Console.WriteLine("bai 1 a");
            Console.WriteLine("X: " + x);
        }

        void getDetail(dynamic value)
        {
            Console.WriteLine("Value: " + value);
        }

        void bai1b()
        {
            Console.WriteLine("bai 1 b");

            getDetail(10);
            getDetail("game");
            getDetail(true);
            getDetail(9.5);
        }

        void bai1c()
        {
            Console.WriteLine("bai 1 c");
            userData data = new userData(01, "nem", 1);
            data.showData();
        }

        bai1a();
        bai1b();
        bai1c();

        return 0;
    }
}
