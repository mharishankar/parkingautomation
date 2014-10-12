using System;
using Entities;
using System.Collections.Generic;

namespace BusinessLogic {
    public static class Register {
        public static Boolean RegisterUser(String billingName, String billingAddress, String emailAddress, String licensePlate, String userName, String passWord, int creditCard) {
           // if ((!verifyBILLING(billingName, billingAddress, creditCard)) || (!verifyEMAIL(emailAddress))) {
           //     return false;
           // }else{
              //  int customerID = getLastCustomerID() + 1;
              //  Customer newCustomer = new RegisteredCustomer(customerID, billingName, billingAddress, emailAddress, 2, 0, null, licensePlate, userName, passWord, null);
              //addNewCusomter(newCustomer);
            //}
            return true;
        }   
        private static Boolean verifyBILLING(String billingName, String billingAddress, int creditCard) {
            return true;
        }
        private static bool verifyEMAIL(String emailAddress1){
            return true;
        }
    }
}