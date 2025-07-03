using System;
using ClubMembership;
using ClubMembership.Views;
using Microsoft.EntityFrameworkCore.Metadata;
namespace ClubMembership
{
    class Program
    {
        static void Main(string[] args)
        {
            Views.IView mainView = Factory.GetMainViewObject();
            mainView.RunView();

            Console.ReadKey();
        }
    }
}