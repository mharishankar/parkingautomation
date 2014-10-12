using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Entities;

namespace BusinessLogic { 
    public static class NoSpots {
        public static Boolean checkForSpots(Customer theCustomer, Garage theGarage) {
            if (theCustomer.getCustomerType() == 1) {
                return theGarage.getFloor(1).isFull();
            }else{
                for (int i = 2; i < theGarage.getFloorCount(); i++) {
                    if(theGarage.getFloor(i).isFull()) {
                        return true;
                    }
                }
                return false;
            }
        }
    }
}