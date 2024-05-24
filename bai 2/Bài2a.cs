using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public partial class bai2
{
    public void bai2a()
    {
        var userInfo = new
        {
            id = "123",
            name = "Faker",
            isDisplay = false,
            bag = new
            {
                skins = 0,
                cups = 20,
            }

        };
        Console.WriteLine("id" + userInfo.id);
        Console.WriteLine("name" + userInfo.name);
        Console.WriteLine("isplaying: " + userInfo.isDisplay);
        Console.WriteLine("bag skin" + userInfo.bag.skins);
        Console.WriteLine("bag cups" + userInfo.bag.cups);
    }
}
