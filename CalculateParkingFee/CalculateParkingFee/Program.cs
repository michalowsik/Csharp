using System;
using Npgsql;

namespace Coding.Exercise
{
    class Program
    {


        static int Main(string[] args)
        {

            Console.WriteLine("Podaj numer rejestracyjny pojazdu:");
            string number = Console.ReadLine();
            int hours = 0;
            Console.WriteLine("Wprowadź liczbę godzin:");
            string? input = Console.ReadLine();
            if (input != null)
            {
                hours = int.Parse(input);
            }
            else
            {
                Console.WriteLine("Nie podano takiej liczby");
                return 0;
            }
            int result = 0;

            int fee = 5;



            switch (hours)
            {
                case 1:
                    result = fee;
                    Console.WriteLine("Opłata za parkowanie: " + result + " zł");
                    Console.WriteLine(number);
                    break;

                default:
                    result = fee + (hours - 1) * 3;
                    Console.WriteLine("Opłata za parkowanie: " + result + " zł");
                    Console.WriteLine(number);
                    break;
            }

                    string connString = "Host=localhost;Port=5432;Username=postgres;Password=1234;Database=parkingsystem";
            using (var conn = new NpgsqlConnection(connString))
            {
                conn.Open();

                        using (var cmd = new NpgsqlCommand("INSERT INTO ParkingSessions (licenseplate, hoursparked, fee, parkingdatetime) VALUES (@licenseplate, @hours, @fee, @date)", conn))
                        {
                            cmd.Parameters.AddWithValue("licenseplate", "DZG62129");
                            cmd.Parameters.AddWithValue("hours", 3);
                            cmd.Parameters.AddWithValue("fee", 5.0);
                            cmd.Parameters.AddWithValue("date", DateTime.Now);

                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Dane zapisane w bazie");


                        }

                    }

                    return result;


                }


            }
        }
    

