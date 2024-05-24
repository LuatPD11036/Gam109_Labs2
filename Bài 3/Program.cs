using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class UserData
{
    public int id;
    public string name;
    public List<float> scoreList;

    public UserData() 
    { 
     id = 0;
        name = "null";
        scoreList = new List<float>();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        UserData userData = new UserData();
        Console.WriteLine("Nhap Id: ");

        String id = Console.ReadLine();

        userData.id = Convert.ToInt32(id);

        Console.WriteLine("UserData.id: " + userData.id);

        Console.WriteLine("Nhap danh sach Diem: ");
        Console.WriteLine("So Luong diem can nhap: ");
        int soLuongDiem = Convert.ToInt32(Console.ReadLine());
        for(int i = 0; i < soLuongDiem; i++)
        {
            Console.WriteLine("Nhap diem: ");
            String diem = Console.ReadLine();
            userData.scoreList.Add(Convert.ToInt32(diem));
        }


        /*string[] strings = danhSachDiem.Split(" ");
        foreach (string s in strings)
        {
            userData.scoreList.Add(Convert.ToDouble(s));
        }*/
        foreach (double score  in userData.scoreList)
        {
            Console.WriteLine("Diem: " + score);
        }
        Console.ReadLine();
    }
}
