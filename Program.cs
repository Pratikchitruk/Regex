using System;

namespace UserRegistrationProblem // Note: actual namespace depends on the project name.
{
    public class Program
    {
       public static void Main(string[] args)
        {
            EnterFirstName entername = new EnterFirstName();


            Console.WriteLine("Enter the name");
            string value = Console.ReadLine();
               bool match=entername.ValidName(value);

            if (match)
                Console.WriteLine("name match");
            else
                Console.WriteLine("name not math");

            EnterLastName.LastName();
            Email.MyEmail();
            MobileNo.MyNo();
            Password.MyPassword();
            AddUpeer.AddUpperPassword();
            Addspacial.AddspacialPassword();


                
        }

    }
}