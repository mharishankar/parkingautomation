/* RegisteredCustomer.cs
 * Daniel Selmon 
 * Last Modified: 3/17/12
 */
using System;
using System.Collections.Generic;

    public class RegisteredCustomer : Customer
    {
        /* Private Data Memebers / Private Fields
         * userName         - String representation of the user's login.
         * passWord         - String representation of the user's password.
         * reservationList  - A Linked list of reservation objects.
         */
        private String userName;
        private String passWord;
        private LinkedList<Reservation> reservationList;
        /* Constructors
         * 
         * Constructor which takes a full set of parameters.
         */
        public RegisteredCustomer(
            int customerID,
            String billingName,
            String billingAddress,
            String emailAddress,
            int customerType,
            double accountBalance,
            spotID assignedSpotID,
            String licensePlate,
            String userName,
            String passWord,
            LinkedList<Reservation> reservationList
            )
        {
            /* Inherited from Customer. */
            this.customerID = customerID;
            this.billingName = billingName;
            this.billingAddress = billingAddress;
            this.emailAddress = emailAddress;
            this.customerType = customerType;
            this.accountBalance = accountBalance;
            this.assignedSpotID = assignedSpotID;
            this.licensePlate = licensePlate;
            /* Unique to Registered Customers. */
            this.userName = userName;
            this.passWord = passWord;
            this.reservationList = reservationList;
        }
        /* defaulconstr.t 
         */
        public RegisteredCustomer():base() {
        }
        /* Accessor Methods
         *
         * getUserName - returns the username.
         */
        public String getUserName()
        {
            return this.userName;
        }
        /* getPassWord - returns the password.
         */
        public String getPassWord()
        {
            return this.passWord;
        }
        /* getReservationListCount - will return the number of reservations a customer has.
         */
        public int getReservationListCount()
        {
            if (this.reservationList != null)
            {
                return this.reservationList.Count;
            }
            return 0;
        }
        /* getReservationList - will return a LinkedList containing all of a customer's reservations.
         * will return null if the customer has no reservations.
         */
        public LinkedList<Reservation> getReservationList()
        {
            if (this.reservationList != null)
            {
                return this.reservationList;
            }
            return null;
        }
        /* Mutator Methods
         * 
         * setReservationList - will set the user's reservation list.
         */
        public void setReservationList(LinkedList<Reservation> reservationList)
        {
            this.reservationList = reservationList;
        }
        /* getUserName
         */
        public void setUserName(String userName)
        {
            this.userName = userName;
        }
        /* getPassWord
         */
        public void setPassWord(String passWord)
        {
            this.passWord = passWord;
        }
        /* Existantial/Other Methods:
         */
        public new Boolean hasReservation()
        {
            if ((reservationList != null) && (reservationList.Count != 0))
            {
                return true;
            }
            return false;
        }
    }