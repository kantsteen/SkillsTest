using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillsTest
{
    public class Booking
    {

        private int _id;
        private DateTime _start;
        private DateTime _end;
        private int _participants;


        public int ID { get { return _id; } private set { _id = value; } }

        public DateTime Start { get { return _start; } private set { _start = value; } }

        public DateTime End { get { return _end; } private set { _end = value; } }

        public int Participants { get { return _participants; } private set { _participants = value; } }


        public Booking(int id, DateTime start, DateTime end, int participants)
        {
            _id = id;
            _start = start;
            _end = end;
            _participants = participants;
        }


        public bool BookingDurationOK(Booking booking)
        {
            if (End.Hour - Start.Hour > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool IsSundayBooking(Booking booking)
        {
            if (Start.DayOfWeek == DayOfWeek.Sunday)
            {
                return true;
            }
            else
            {
                return false;
            }
        }








































        public override string ToString()
        {
            return $"ID: {ID}, starttidspunkt: {Start}, sluttidspunkt: {End}, deltagere: {Participants}";
        }







    }
}
