using System.Reflection.Metadata.Ecma335;
using WebApp.Models.PersonDep;

namespace WebApp.Models;

public class Person
{
    public string ShowClothesData()
    {
        Clothes clothes = new();
        return clothes.ShowClothes();
    }

    public string ShowFoodData()
    {
        Food food = new();
        return food.ShowFood();
    }

    public string ShowHomeData()
    {
        Home home = new();
        return home.ShowHome();
    }

    public string ShowMoneyData()
    {
        Money money = new();
        return money.ShowMoney();
    }
}
