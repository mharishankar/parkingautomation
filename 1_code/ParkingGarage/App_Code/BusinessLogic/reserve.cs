using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Entities;

namespace BusinessLogic
{
    public class reserve
    {
        public bool makeReservation(Customer customer, DateTime startTime, DateTime endTime)
        {

            bool reservationSuccessful = false;
            Reservation newReservation = new Reservation(startTime, endTime);
            TimeSpan duration = newReservation.getDuration();
           // reservationSuccessful = addReservationToDatabase(customer.getCustomerID(), newReservation);

            return reservationSuccessful;
        }

        bool cancelReservation(Customer customer,Reservation oldReservation)
        {
            bool cancellationDeadline = false;
           // deleteReservationFromDatabase(customer.getCustomerID(), oldReservation);
            DateTime now = new DateTime();
            if (oldReservation.getBeginDate().CompareTo(now) < 0)
                cancellationDeadline = true;

            return cancellationDeadline;
        }

        bool editReservation(Customer customer, Reservation oldReservation, DateTime endTime)
        {
            if (!makeReservation(customer, oldReservation.getBeginDate(), endTime))
                return false;
            cancelReservation(customer, oldReservation);
            oldReservation.setEndDate(endTime);
            return true;
        }
    }
}