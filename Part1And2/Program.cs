namespace Part1And2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a name");
            string name = Console.ReadLine();

            while (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Invalid name entered");
                Console.WriteLine("Please enter a name");
                name = Console.ReadLine();
            }

            Console.WriteLine("Please enter a ID number");
            string idNumber = Console.ReadLine();

            while (!IsValidEmployeeID(idNumber))
            {
                Console.WriteLine("Invalid ID entered");
                Console.WriteLine("Please enter an ID number");
                idNumber = Console.ReadLine();
            }

            double hoursWorked = GetHoursWorkedFromUser();

            double payRate = GetPayRateFromUser();

            double taxDue = CalculateTaxOwed(hoursWorked, payRate);

            double grossPay = hoursWorked * payRate;

            Console.WriteLine($"Tax due is {taxDue} take home pay is {grossPay - taxDue}");

        }

        private static double GetHoursWorkedFromUser()
        {
            Console.WriteLine("Please enter the hours worked");
            string hoursWorkedEntered = Console.ReadLine();
            double hoursWorked;

            while (!Double.TryParse(hoursWorkedEntered, out hoursWorked) ||
                !IsValidHoursWorked(hoursWorked))
            {
                Console.WriteLine("Invalid hours entered");
                Console.WriteLine("Please enter the hours worked");
                hoursWorkedEntered = Console.ReadLine();
            }

            return hoursWorked;
        }

        /// <summary>
        /// This prompts the user to enter a payrate and if it is valid
        /// returns the payrate entered as a double.
        /// Otherwise it prompts again unstil a valid payrate is entered.
        /// </summary>
        /// <returns></returns>
        private static double GetPayRateFromUser()
        {
            Console.WriteLine("Please enter the hourly pay  rate");
            string payRateEntered = Console.ReadLine();
            double payRate;

            while (!Double.TryParse(payRateEntered, out payRate) ||
                !IsValidPayRate(payRate))
            {
                Console.WriteLine("Invalid pay Rate entered");
                Console.WriteLine("Please enter the pay rate");
                payRateEntered = Console.ReadLine();
            }

            return payRate;
        }



        /// <summary>
        /// returns true if the employeeID is valid
        /// </summary>
        /// <param name="employeeID"></param>
        /// <returns></returns>

        static bool IsValidEmployeeID(string employeeID)
        {
            return employeeID.Length == 6 && employeeID.ToUpper()[0] == 'E';
        }
        /// <summary>
        /// return true if the hours worked is in the range 10 to 50 (inclusive)
        /// </summary>
        /// <param name="hoursWorked"></param>
        /// <returns></returns>
        static bool IsValidHoursWorked(double hoursWorked)
        {
            return hoursWorked >= 10 && hoursWorked <= 50;
        }

        /// <summary>
        /// returns true if the payrate is between 10 and 65 (inclusive)
        /// </summary>
        /// <param name="payRate"></param>
        /// <returns></returns>
        static bool IsValidPayRate (double payRate)
        {
            return payRate >= 10 && payRate <= 65;
        }



        static double CalculateTaxOwed (double hoursWorked, double payRate)
        {
            double grossPay = hoursWorked * payRate;
            double taxOwed = 0;

            if (grossPay > 3000 && grossPay <= 3400)
            {
                taxOwed = grossPay * .2;
            }
            else if (grossPay > 3400)
            {
                taxOwed = grossPay * .4;
            }

            return taxOwed;
        }

    }
}