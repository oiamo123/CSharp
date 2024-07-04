// See https://aka.ms/new-console-template for more information

using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text.RegularExpressions;

List<Person> people = new List<Person>();
Question quest = new Question(ref people);


public class Question
{
    public Question(ref List<Person> people)
    {
        question(ref people);
    }

    // adds a person
    static void addPerson(ref List<Person> people)
    {
        bool firstNameValid = false;
        bool lastNameValid = false;
        bool dobValid = false;

        string? firstName = "";
        string? lastName = "";
        DateTime dob = new DateTime();

        // while values are invalid formats, continue to ask for valid format.
        while (!dobValid || !firstNameValid || !lastNameValid)
        {
            // validate first name
            if (!firstNameValid)
            {
                Console.WriteLine("What is your first name?");
                firstName = Console.ReadLine();
                firstNameValid = Person.getName(firstName);
            }

            // reask for first name if not valid format
            if (!firstNameValid) continue;

            // validate last name
            if (!lastNameValid)
            {
                Console.WriteLine("What is your last name?");
                lastName = Console.ReadLine();
                lastNameValid = Person.getName(lastName);

            }

            // reask for last name if not valid format
            if (!lastNameValid) continue;

            // validate date of birth
            if (!dobValid)
            {
                Console.WriteLine(@"What is your date of birth in the format dd\mm\yyyy?");
                string? dobString = Console.ReadLine();
                dob = Person.getDate(dobString, out dobValid);
            }
            // will automatically ask for dob if dob is not valid
        }

        // add person to list and reprompt question
        people.Add(new Person(dob, firstName, lastName));
        question(ref people);
    }

    // question function/method
    static void question(ref List<Person> people)
    {
        bool answerValid = false;

        // will continue to loop while answer is not valid ie "add, list" etc
        while (!answerValid)
        {
            // prompt question
            Console.WriteLine("What would you like to do? quit or add, list, remove or update a person or quit?");
            string answer = Console.ReadLine().ToLower();

            // check answer
            if (
                !answer.Equals("add") &&
                !answer.Equals("list") &&
                !answer.Equals("remove") &&
                !answer.Equals("update") &&
                !answer.Equals("quit"))
            {
                Console.WriteLine("Invalid response, please try again!");
            }
            else
            {
                answerValid = true;
            }
            // re ask question if answer is invalid
            if (!answerValid) continue;

            // add another person if selection is add
            if (answer.Equals("add"))
            {
                addPerson(ref people);
            }

            // list people if selection is list
            else if (answer.Equals("list"))
            {
                listPeople(people);
                answerValid = false;
            }

            // update person
            else if (answer.Equals("update"))
            {
                bool newValueValid = false;

                // list people to update
                listPeople(people);

                // prompt
                Console.WriteLine("Who would you like to update? Make a selection by first name.");
                string? nameToUpdate = Console.ReadLine();

                // check to see if person exists
                bool personExists = people.Exists(person => person.firstName.Equals(nameToUpdate));

                // if person doesn't exist, reprompt question and inform them
                if (!personExists)
                {
                    Console.WriteLine($"{nameToUpdate} does not exist");
                    answerValid = false;
                    continue;
                }

                // finds person
                Person? person = people.Find(p => p.firstName.Equals(nameToUpdate));

                // asks user what they would like to update
                Console.WriteLine("What would you like to update? dob, firstname or lastname?");
                string valueToUpdate = Console.ReadLine().ToLower();

                // verify's answer
                if (!valueToUpdate.Equals("dob") &&
                    !valueToUpdate.Equals("firstname") &&
                    !valueToUpdate.Equals("lastname"))
                {
                    Console.WriteLine("Not a valid response");
                    answerValid = false;
                    continue;
                }

                // asks user what they would like the new value to be
                Console.WriteLine("What would you like the new value to be?");
                string? newValue = Console.ReadLine();


                if (valueToUpdate.Equals("dob"))
                {
                    // validate date before you set it
                    DateTime tempValue = Person.getDate(newValue, out newValueValid);

                    // if the new value is not valid 
                    if (newValueValid)
                    {
                        person.dob = tempValue;
                        Console.WriteLine("Value updated");
                    }
                    else
                    {
                        Console.WriteLine("Date is invalid");
                    }
                }
                // rinse and repeat
                else if (valueToUpdate.Equals("firstname"))
                {
                    bool validName = Person.getName(newValue);
                    if (validName)
                    {
                        person.firstName = newValue;
                        Console.WriteLine("Value updated");
                    }
                    else
                    {
                        Console.WriteLine("Name is not valid");
                    }
                }
                else if (valueToUpdate.Equals("lastname"))
                {
                    bool validName = Person.getName(newValue);
                    if (validName)
                    {
                        person.lastName = newValue;
                        Console.WriteLine("Value updated");
                    }
                    else
                    {
                        Console.WriteLine("Name is not valid");
                    }
                }
                answerValid = false;
            }

            // user selected remove
            else if (answer.Equals("remove"))
            {
                // list people and ask user who to remove
                listPeople(people);
                Console.WriteLine("Who would you like to remove? Make a selection by first name.");
                string personToRemove = Console.ReadLine();

                // check if person exists
                bool personExists = people.Exists(person => person.firstName.Equals(personToRemove));

                // if person doesn't exist, inform user
                if (!personExists)
                {
                    Console.WriteLine("Person does not exist");
                    answerValid = false;
                    continue;
                    
                }

                // find user and remove them and inform user
                else
                {
                    people.Remove(people.Find(person => person.firstName.Equals(personToRemove)));
                    Console.WriteLine("Person removed");
                }

                answerValid = false;
            }

            // close enviroment if answer is quit
            else if (answer.Equals("quit"))
            {
                Console.WriteLine("See ya!");
                Environment.Exit(0);
            }

        }

        // method to list people
        static void listPeople(List<Person> people)
        {
            foreach (Person person in people)
            {
                Console.WriteLine($"First name: {person.firstName}, Last name: {person.lastName}, Date of Birth: {person.dob}");
            }
        }
    }
}


public class Person
{
    public DateTime dob { get; set; }
    public string firstName { get; set; }

    public string lastName { get; set; }


    public Person(DateTime dob, string firstName = "Unknown", string lastName = "Unknown")
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.dob = dob;
    }

    // verify name
    public static bool getName(string name = "")
    {
        try
        {
            // check to make sure string isn't empty
            if (name == "") throw new Exception("Invalid name format");

            // foreach character in name, check to make sure it's a letter. If it isn't, it's an invalid name otherwise return true
            foreach (char c in name)
            {
                if (!Char.IsLetter(c))
                {
                    throw new Exception("Invalid name format");
                }
            }

            return true;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return false;
        }

    }

    // validate dob
    public static DateTime getDate(string dob, out bool dobValid)
    {
        int[] evenMonths = [1, 3, 5, 7, 8, 10, 12]; // january, march, may ...
        int[] oddMonths = [2, 4, 6, 9, 11]; // february, april ...
        int year = 0;
        int month = 0;
        int day = 0;
        string dobString = "";
        DateTime today = DateTime.Today;

        try
        {
            // foreach char in the dob, if char is a digit, add it to dobString
            foreach (char c in dob)
            {
                if (Char.IsDigit(c))
                {
                    dobString += c;
                }
            }

            // throw error if length is incorrect ie invalid format
            if (dobString.Length != 8) throw new Exception("Date of birth is not valid!");

            // get dates out of dobString
            year = int.Parse(dob.Substring(4, 4));
            day = int.Parse(dob.Substring(0, 2));
            month = int.Parse(dob.Substring(2, 2));

            // exception handling
            if (year > today.Year - 3 || year < today.Year - 125) throw new Exception($"Surely you're not {today.Year - year} years old. Please try again!");
            if (month > 12) throw new Exception("There's only 12 months in a year. Please try again!");
            if ((day > 29 && DateTime.IsLeapYear(year) && month == 2) || (day > 28 && !DateTime.IsLeapYear(year) && month == 2) || (day > 30 && evenMonths.Contains(month)) || (day > 31 && evenMonths.Contains(month))) throw new Exception($"There's too many days for that month!");

            // returns validity
            else
            {
                dobValid = true;
            }

        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            dobValid = false;
            return new DateTime();
        }

        DateTime birthday = new DateTime(year, month, day);
        return birthday;

    }
}