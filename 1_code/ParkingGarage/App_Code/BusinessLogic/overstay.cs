using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Entities;

namespace BusinessLogic{
  
    public static class overstay{
           static public int overstayTime(Customer curr_customer, Reservation ongoingReservation){
               var timeDifference = curr_customer.getSpotID().getStayDuration() - ongoingReservation.getDuration();
               int difference = timeDifference.Minutes;
               return difference;
        }
           static public bool checkOverStayStatus(Customer customer)
            {
                return true;
            }
    }
}