using System;

namespace OOP
{
    /// <summary>
    /// Represents a Human
    /// </summary>
    public class Human
    {
        //member variable
        private string FirstName;
        private string LastName;
        private string EyeColor;
        private int Age;

        #region Constructors

        // public Human()
        // {
        //     
        // }
        public Human(string firstname, string lastname, string eyeColor, int age)
        {
            FirstName = firstname;
            LastName = lastname;
            EyeColor = eyeColor;
            Age = age;
        }

        #endregion

        public void IntroduceMyself()
        {
            Console.WriteLine($"Hi, I'm {FirstName} {LastName}. I'm {Age} years old and have {EyeColor} eyes.");
        }
    }
}