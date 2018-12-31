
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringExample;

namespace AgeRetirement
{
    class Program
    {
        static void Main(string[] args)
        {
            AgeRetirement();
            Console.ReadLine();
        }

        enum UserGender
        {
            NotInitialised,
            Male,
            Female
        }

        enum BirthDate
        {
            TippingError,
            Yyear,
            Month,
            Day
        }

        public static void AgeRetirement()
        {
            int _case;
            int _caseBirthDate;
            string year, month, day, gender = null;

            year = "0";
            month = "0";
            day = "0";
            _caseBirthDate = 0;

            Console.WriteLine("Enter your Birthdate:");

            try
            {
                do
                {
                    if (!int.TryParse(year, out int yearRange) || !int.TryParse(month, out int monthRange) || !int.TryParse(day, out int dayRange))
                    {
                        _caseBirthDate = 0;
                    }
                    else if (int.Parse(year) > int.Parse(DateTime.Now.ToString("yyyy")) || int.Parse(year) == 0)
                    {
                        _caseBirthDate = 1;
                    }
                    else if (int.Parse(month) > 12 || int.Parse(month) < 1 || int.Parse(month) == 0)
                    {
                        _caseBirthDate = 2;
                    }
                    else if (int.Parse(day) > 31 || int.Parse(day) < 1 || int.Parse(day) == 0)
                    {
                        _caseBirthDate = 3;
                    }
                    else
                    {
                        _caseBirthDate = 0;
                    }

                    switch (_caseBirthDate)
                    {
                        case 0:
                            Console.Write("(This is not a proper value)\n\nPlease try again:\n");
                            if (!int.TryParse(year, out int yearCheck))
                            {
                                year = "0";
                            }

                            if (!int.TryParse(month, out int monthCheck))
                            {
                                month = "0";
                            }

                            if (!int.TryParse(day, out int dayCheck))
                            {
                                day = "0";
                            }
                            continue;
                        case 1:
                            Console.Write("Year :");
                            year = Console.ReadLine();
                            break;
                        case 2:
                            Console.Write("Month :");
                            month = Console.ReadLine();
                            break;
                        case 3:
                            Console.Write("Day :");
                            day = Console.ReadLine();
                            break;
                    }

                } while (!int.TryParse(year, out int validYear)
                        || !int.TryParse(month, out int validMonth)
                        || !int.TryParse(day, out int validDay)
                        || int.Parse(year) == 0
                        || int.Parse(month) == 0
                        || int.Parse(day) == 0
                        || int.Parse(day) > 31);

                Console.Write("Gener (M/F) :");
                gender = Console.ReadLine();

                string userDate = month + " " + day + ", " + year;
                DateTime date = DateTime.Parse(userDate);
                var BirthYear = int.Parse(year);
                var CurrentYear = int.Parse(DateTime.Now.ToString("yyyy"));

                string age = (CurrentYear - BirthYear).ToString();
                Console.WriteLine("\n\nYour Age is " + (age));

                if (gender == "M" || gender == "m")
                {
                    _case = (int)UserGender.Male;
                }
                else if (gender == "F" || gender == "f")
                {
                    _case = (int)UserGender.Female;
                }
                else
                {
                    _case = (int)UserGender.NotInitialised;
                }
                switch (_case)
                {
                    case 0:
                        Console.Write("We haven't any information about your retirement");
                        break;

                    case 1:
                        if (int.Parse(age) >= 65)
                        {
                            Console.WriteLine("You are retired.");
                        }
                        else
                        {
                            Console.WriteLine("You will retire at 65 (yoou have " + (65 - int.Parse(age)) + " years until retirement)");
                        }
                        break;

                    case 2:
                        if (int.Parse(age) >= 63)
                        {
                            Console.WriteLine("You are retired.");
                        }
                        else
                        {
                            Console.WriteLine("You will retire at 63 (yoou have " + (63 - int.Parse(age)) + " years until retirement)");
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
        }
    }
}
