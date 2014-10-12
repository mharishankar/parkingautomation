using System;
using System.Data;
using Entities;

namespace BusinessLogic {
    public static class enterLift {
        public static void enterTheLift(Customer theCustomer, Garage theGarage) {
            int CustomerType;
            bool hasReservation;
            CustomerType = theCustomer.getCustomerType();
            hasReservation = theCustomer.hasReservation();
            //if the customer is a walk-in or has no reservation at entry time, allow into bottom floor if a spot is available by opening gate and incrememnting 
            if((CustomerType == 1) || (CustomerType == 2 && !hasReservation)) {
                    //openGate();
                    theGarage.getFloor(1).incOccupancy();
                    //closeGate();
            } else {
                if(CustomerType == 2 && hasReservation) {
                    for(int i = 2; i < theGarage.getFloorCount(); i++) {
                        if (theGarage.getFloor(i).isFull()) {
                            continue;
                        } else {
                            theGarage.getFloor(i).incOccupancy();
                            break;
                        }
                    }
                }
            }
        }
    }
}