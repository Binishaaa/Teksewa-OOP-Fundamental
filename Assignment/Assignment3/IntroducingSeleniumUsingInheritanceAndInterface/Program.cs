using System;

namespace YourNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of HomePage
            HomePage homePage = new HomePage
            {
                MenuItems = new[] { "Home", "About", "Contact","Help" },
                Height= 800,
                Width = 600,
                // ProfileAvatar = 0xFF
            };

            homePage.Navigate("http://test.com/");
            Console.WriteLine($"Current URL: {homePage.GetCurrentURL()}");

            homePage.HandleMenuClick("About");
            homePage.Login("userA", "password1122");

            AboutUsPage aboutUsPage = new AboutUsPage
            {
                MenuItems = new[] { "Home", "About", "Contact" },
                Height = 800,
                Width = 600,
                // ProfileAvatar = 0xFF,
                Title = "About Us",
                Contacts = 5551234
            };
            aboutUsPage.Navigate("http://test.com/about");
            Console.WriteLine($"Current URL: {aboutUsPage.GetCurrentURL()}");

            aboutUsPage.InitiatePhone("555-1234");
            aboutUsPage.InitiateEmail("test@gmail.com");
        }
    }
}