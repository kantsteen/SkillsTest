namespace SkillsTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // opgave 1
            Console.WriteLine("opgave 1");
            Booking testBooking = new Booking(1, new DateTime(2024, 6, 21, 14, 0, 0), new DateTime(2024, 6, 21, 16, 0, 0), 10);
            Console.WriteLine(testBooking);
            Console.WriteLine();



            // opgave 2
            Console.WriteLine("opgave 2");

            GymHall testGymHall = new GymHall(1, "Den lille gymnastiksal", "Højvangen 2", "71 72 17 00", "højen@højen.dk");
            GymHall testGymHall2 = new GymHall(2, "Den store gymnastiksal", "Højvangen 2", "71 72 17 00", "højen@højen.dk");

            Console.WriteLine(testGymHall);
            Console.WriteLine(testGymHall2);
            Console.WriteLine();


            // opgave 4
            Console.WriteLine("opgave 4");
            Booking testBooking2 = new Booking(2, new DateTime(2024, 6, 21, 16, 0, 0), new DateTime(2024, 6, 21, 18, 0, 0), 12);

            testGymHall.RegisterBooking(testBooking);
            testGymHall.RegisterBooking(testBooking2);

            testGymHall.PrintBookings();

            Console.WriteLine(Environment.NewLine + "removed 'testBooking' from dictionary and called PrintBooking method");
            testGymHall.RemoveBooking(testBooking);

            testGymHall.PrintBookings();
            Console.WriteLine();

            Console.WriteLine("opgave 6");
            Booking testBooking3 = new Booking(1, new DateTime(2024, 6, 23, 12, 0, 0), new DateTime(2024, 6, 23, 14, 0, 0), 20);

            // BookingDurationOK test
            Console.WriteLine(testBooking3.BookingDurationOK(testBooking3));

            // IsSundayBooking test
            Console.WriteLine(testBooking3.IsSundayBooking(testBooking3));

            // TotalBookings test - testBooking 2 and 3 are added to testGymHall
            testGymHall.RegisterBooking(testBooking3);
            Console.WriteLine(testGymHall.TotalBookings());



        }
    }
}
