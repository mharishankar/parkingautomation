using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Entities;

namespace BusinessLogic
{
    public class Billpay  
    {
        // The value of the billing rates can be modified.
        const double contract_amount = 200.00;
        const double walkin_amount = 30.00;
        const double overstay_amount = 15.00;
        const double regular_rate = 10.00;
        public double amount(Customer curr_customer, Reservation curr_reservation) // will execute at the end of reservaiton time for no shows or at exit for reserved and walkins)
        {
            double amountDue = 0;
            // if the customer has a reservation, that means this returns the entire amount owed for all unpaid reservations
            if (curr_customer.getCustomerType() == 1) // walk in customer
            { 
                TimeSpan duration = curr_customer.getSpotID().getStayDuration();
               
                curr_customer.setAccountBalance(curr_customer.getAccountBalance() + amountDue);
            }
            if (curr_customer.getCustomerType() == 2) // Registered contract type customer
            {
                curr_customer.setAccountBalance(contract_amount);                
            }

            if (curr_customer.getCustomerType() == 3) //Registered Reserved Customer
            {
                double overstayAmount = 0;
                //check whether the customer has overstayed or not
                if (overstay.checkOverStayStatus(curr_customer)) 
                    overstayAmount = overstay.overstayTime(curr_customer, curr_reservation) * overstay_amount; //if the customer overstayed
                amountDue = curr_reservation.getDuration().Minutes * regular_rate + overstayAmount; // if the customer didn't overstay
            }
            return amountDue;
        }
    }
}
