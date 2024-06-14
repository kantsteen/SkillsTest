using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class GymHall
    {
        private int _id;
        private string _name;
        private string _address;
        private string _phone;
        private string _email;
        private Dictionary<int, Booking> _bookings;


        public int ID { get { return _id; } set { _id = value; } }
        public string Name { get { return _name; } set { _name = value; } }
        public string Address { get { return _address; } set { _address = value; } }
        public string Phone { get { return _phone; } set { _phone = value; } }
        public string Email { get { return _email; } set { _email = value; } }
        public Dictionary<int, Booking> Bookings { get; set; }

        public GymHall(int id, string name, string address, string phone, string email)
        {
            _id = id;
            _name = name;
            _address = address;
            _phone = phone;
            _email = email;
            _bookings = new Dictionary<int, Booking>();
        }



        public void RegisterBooking(Booking booking)
        {
            _bookings.Add(booking.ID, booking);
        }

        public void PrintBookings()
        {
            foreach (var booking in _bookings)
            {
                Console.WriteLine(booking);
            }
        }


        public void RemoveBooking(Booking booking)
        {
            _bookings.Remove(booking.ID);
        }


        public int TotalBookings()
        {
            return _bookings.Count;
        }




        public bool Validate()
        {


        }




        public override string ToString()
        {
            return $"ID: {ID}, gymnastiksal: {Name}, adresse: {Address}, tlf: {Phone}, email: {Email}";
        }












    }



    









}
