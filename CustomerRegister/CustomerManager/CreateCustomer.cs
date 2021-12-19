using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerManager {
    internal class CreateCustomer {

        public static void Create() {

            List<Customer> customer = new List<Customer>();
            string filePath = @"C:\WIN21\inlämning-uppgift-cs\Test.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines) {
                string[] entries = line.Split(',');

                Customer newCustomer = new Customer();

                newCustomer.FirstName = entries[0];
                newCustomer.LastName = entries[1];
                newCustomer.Email = entries[2];

                customer.Add(newCustomer);
            }

            Console.Write("Förnamn: ");
            string? firstName = Console.ReadLine();

            Console.Write("Efternamn: ");
            string? lastName = Console.ReadLine();

            Console.Write("E-postadress: ");
            string? email = Console.ReadLine();

            Console.Write("Djur: ");
            string? animal = Console.ReadLine();

            customer.Add(new Customer { FirstName = firstName, LastName = lastName, Email = email, Animal = animal });

            List<string> output = new List<string>();

            foreach (var user in customer) {
                output.Add($"{ user.FirstName },{ user.LastName },{ user.Email },{ user.Animal }");
            }

            File.WriteAllLines(filePath, output);

        }

        public static void LoadList() {

            List<Customer> customer = new List<Customer>();
            string filePath = @"C:\WIN21\inlämning-uppgift-cs\Test.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var line in lines) {
                string[] entries = line.Split(',');

                Customer newCustomer = new Customer();

                newCustomer.FirstName = entries[0];
                newCustomer.LastName = entries[1];
                newCustomer.Email = entries[2];

                customer.Add(newCustomer);
            }

            foreach (var user in customer) {
                Console.WriteLine($"{ user.FirstName }. { user.LastName }. { user.Email }.");
            }
        }

        public static void DiscountAutoGenerator() {
            string number = "123456789";
            int length = number.Length;
            string otp = string.Empty;
            int otpdigit = 5;
            string digit;

            int getindex;

            for (int i = 0; i < otpdigit; i++) {

                do {
                    getindex = new Random().Next(0, length);
                    digit = number.ToCharArray()[getindex].ToString();
                }
                while (otp.IndexOf(digit) != -1);
                otp += digit;

            }
            Console.WriteLine(otp);
        }

        public static void RemoveCustomer() {

            List<Customer> customer = new List<Customer>();
            string filePath = @"C:\WIN21\inlämning-uppgift-cs\Test.txt";

            List<string> lines = File.ReadAllLines(filePath).ToList();

            string[] words = File.ReadAllText(filePath).Split(' ');

            Console.WriteLine("Förnamn: ");
            string wordSearched = Console.ReadLine();

            bool condition = false;

            for (int i = 0; i < words.Length; i++) {
                if (words[i].Contains(wordSearched) == true) {
                    condition = true;
                    break;
                }
                else {
                    condition = false;
                }
            }
            if (condition == true) {
                Console.WriteLine("{0} hittad i filen", wordSearched);
            }
            else {
                Console.WriteLine("{0} inte hittad i filen", wordSearched);
            }

        }

    }
}
