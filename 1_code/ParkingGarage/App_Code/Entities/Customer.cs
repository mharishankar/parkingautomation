using System;
namespace Entities {
    public class Customer {
        /* customerType - An enumerated type of all the possible states a customer can be.
         * This needs to be moved to a util package.
         */
        const int WALK_IN = 1;
        const int RESERVED_CUSTOMER = 2;
        const int CONTRACT_CUSTOMER = 3;
        /* Private data members / Protected fields summary:
         * customerID       Some server sided unique ID that is assigned to all customers. Will be used to indexing.
         * billingName      Customer's name. We might want to split this into 2 separate fields first and last name.
         * billingAddress   Customer's billinf address.
         * customerType     Customer Type, this will be one of those billion states that I don't understand.
         * accountBalance   The customer's account balance.
         * assignedSpotID   The spotID assigned to this customer.
         * licensePlate     The customer's license plate id.
         */
        protected int customerID;
        protected String billingName;
        protected String billingAddress;
        protected String emailAddress;
        protected int customerType;
        protected double accountBalance;
        protected spotID assignedSpotID;
        protected String licensePlate;// Design Question, Can a user have more than 1 plate on file ?
        /* Constructors:
         * 
         * Default Constructor (C# requires this for inheritence.)
         */
        public Customer() {
        }
        /* Constructor (Minimal)
         * This constructor will create a new customer object.
         * This should be called when we want to add a new user to our system.
         */
        public Customer(int customerID, int customerType, String licensePlate) {
            this.customerID = customerID;
            this.customerType = customerType;
            this.licensePlate = licensePlate;
        }
        /* Constructor (From Database)
         * This constructor is to be called when populating the model with records from the database.
         */
        public Customer(
            int customerID,
            String billingName,
            String billingAddress,
            String emailAddress,
            int customerType,
            double accountBalance,
            spotID assignedSpotID,
            String licensePlate
            ) {
            this.customerID = customerID;
            this.billingName = billingName;
            this.billingAddress = billingAddress;
            this.emailAddress = emailAddress;
            this.customerType = customerType;
            this.accountBalance = accountBalance;
            this.assignedSpotID = assignedSpotID;
            this.licensePlate = licensePlate;
        }
        /* Accessor Methods
         * 
         * getCustomerID - will return the customer's ID number.
         */
        public int getCustomerID() {
            return this.customerID;
        }
        /* getBillingName - will return the customer's Billing Name.
         */
        public String getBillingName() {
            return this.billingName;
        }
        /* get Billing Address - will return the customer's Billing Address.
         */
        public String getBillingAddress() {
            return this.billingAddress;
        }
        /* getCustomerType - will return the customer's type.
         */
        public int getCustomerType() {
            return this.customerType;
        }
        /* getAccountBalance - will return the customer's account balance.
         */
        public double getAccountBalance() {
            return this.accountBalance;
        }
        /* getLicensePlate - will return the custom's license plate number.
         */
        public String getLicensePlate() {
            return this.licensePlate;
        }
        /* getSpotID - gets the spot id.
         */
        public spotID getSpotID() {
            return this.assignedSpotID;
        }
        /* Mutator Methods:
         *
         * setCustomerID
         */
        public void setCustomerID(int customerID) {
            this.customerID = customerID;
        }
        /* setBillingName - sets the customer's billing name.
         */
        public void setBillingName(String billingName) {
            this.billingName = billingName;
        }
        /* setCustomerName - sets the customer's billing address.
         */
        public void setBillingAddress(String billingAddress) {
            this.billingAddress = billingAddress;
        }
        /* setCustomerType - sets the customer's type.
         */
        public void setCustomerType(int customerType) {
            this.customerType = customerType;
        }
        /* setEmailAddress - sets the customer's email address.
         */
        public void setEmailAddress(String emailAddress) {
            this.emailAddress = emailAddress;
        }
        /* setAccountBalance - sets the customer's account balance.
         */
        public void setAccountBalance(double accountBalance) {
            this.accountBalance = accountBalance;
        }
        /* setLicensePlate - sets the customer's license plate.
         */
        public void setLicensePlate(String licensePlate) {
            this.licensePlate = licensePlate;
        }
        /* setAssignedSpotID
         */
        public void setAssignedSpotID(spotID assignedSpotID) {
            this.assignedSpotID = assignedSpotID;
        }
        /* Existantial/Other Methods:
         * 
         * hasReservatin - This function isn't implemented yet.
         */
        public Boolean hasReservation() {
            return false;
        }
        /* hasBalance - will return a boolean t/f, to answer the question, "does the customer have a balance?"
         * Returns True: The customer has a balance.  
         * Return False: The custmer's balance is zero.
         */
        public Boolean hasBalance() {
            if (this.accountBalance == 0) {
                return false;
            }
            return true;
        }
    }
}