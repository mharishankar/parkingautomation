using System;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic {
    public class ManageReservation {
        //input reservation and cancel/extend
        public bool manageReservation(Reservation HandlingNowReservation, string cancelORextend) {   
            //if cancelling
            if (cancelORextend == "cancel") {
                // get the begin date and time
                DateTime beginDate = HandlingNowReservation.getBeginDate();
                //calculate short notice time
                DateTime ShortNoticeTime = beginDate.Add(new TimeSpan(0, -30, 0));
                // compare short notice time with current time
                int compareValue = ShortNoticeTime.CompareTo(DateTime.Now);
                //if current time is is earlier than or the same as the short notice time
                if (compareValue <= 0) {
                    //then it is safe to delete/cancel the reservation
                    HandlingNowReservation = null;
                    return true;
                }
            } else {
                if (cancelORextend == "extend") {
                    // get end date of reservation
                    DateTime endDate;
                    endDate = HandlingNowReservation.getEndDate();
                    // compare time and date now with time and date of end
                    int compareValue2 = endDate.CompareTo(DateTime.Now);
                    // if current time is earlier than end time
                    if (compareValue2 < 0) {
                        //extension possible, input new date and time
                        //HandlingNowReservation.setEndDate(newEndDate); 
                        return true;
                    }
                } else {
                    return false;
                }
            }
            return false;
        }
    }
}