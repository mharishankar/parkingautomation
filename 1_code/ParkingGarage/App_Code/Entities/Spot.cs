
using System;
namespace Entities {
    public class Spot {
        /* spotStatus - An enumerated type of all the possible states a spot can be. 
         * move this enum to a util package.
         */
        const int VACANT = 1;
        public enum SpotStatus { VACANT, OCCUPIED, RESERVED }
        /* Private data members / Private field summary:
         * theCustomer        - Pointer to the customer object associated with this spot.
         * spotNumber         - The spot's number.
         * spotStatus         - What state the spot is in. 
         * occupancyBeginTime - The time when the customer arrived.
         */
        private Customer theCustomer;
        private int spotNumber;
        private SpotStatus spotStatus;
        private DateTime occupancyBeginTime;
        /* Constructors:
         *
         * Default Constructor
         */
        public Spot() {
            this.theCustomer = null;
            this.spotNumber = 0;
            this.spotStatus = SpotStatus.VACANT;
            this.occupancyBeginTime = DateTime.Today;
        }
        /* Constructor I - Creates an empty spot with a given spot number. 
         */
        public Spot(int spotNumber) {
            this.theCustomer = null;
            this.spotNumber = spotNumber;
            this.occupancyBeginTime = new DateTime();
            this.spotStatus = SpotStatus.VACANT;
        }
        /* Constructor II - Creats a spot object with complete attributes. 
         */
        public Spot(Customer theCustomer, int spotNumber, SpotStatus spotStatus, DateTime occupancyBeginTime) {
            this.theCustomer = theCustomer;
            this.spotNumber = spotNumber;
            this.occupancyBeginTime = occupancyBeginTime;
            this.spotStatus = spotStatus;
        }
        /* Mutator Methods:
         * 
         * assignCustomer - Assigns a customer object to this spot and change the spot state
         * and sets occupancyBeginTime. Allows a customer object to be over written.
         */
        public void assignCustomer(Customer theCustomer) {
            this.occupancyBeginTime = DateTime.Now;
            this.spotStatus = SpotStatus.OCCUPIED;
            this.theCustomer = theCustomer;
        }
        /* removeCustomer will remove a customer object from this spot
         * Returns True : The customer was removed successfully.
         * Returns False: There is no customer object associated with this spot.
         */
        public Boolean removeCustomer() {
            if (this.theCustomer != null) {
                this.spotStatus = SpotStatus.VACANT;
                // theCustomer.getSpotID().setStayDuction();
                this.theCustomer = null;
                return true;
            }
            return false;
        }
        /* setCustomer
         */
        public void setCustomer(Customer theCustomer) {
            this.theCustomer = theCustomer;
        }
        /* setSpotNumber
         */
        public void setSpotNumber(int spotNumber) {
            this.spotNumber = spotNumber;
        }
        /* setSpotStatus
         */
        public void setSpotStatus(SpotStatus spotStatus) {
            this.spotStatus = spotStatus;
        }
        /* setOccypancyBeginTime
         */
        public void setOccupancyBeginTime(DateTime occupancyBeginTime) {
            this.occupancyBeginTime = occupancyBeginTime;
        }
        /* Accessor Methods:
         * 
         * getSpotNumber - will return the spots number. (does not return floor number.)
         */
        public int getSpotNumber() {
            return this.spotNumber;
        }
        /* getStatus - will return the spots state.
         */
        public SpotStatus getStatus() {
            return this.spotStatus;
        }
        /* getCustomer - will return the Customer object associated with this spot if one exists.
         * otherwise will return null.
         */
        public Customer getCustomer() {
            if (this.theCustomer != null) {
                return this.theCustomer;
            }
            return null;
        }
        /* getDuration - will return how long a customer has been occupying the spot, if no customer is present
         * zero will be returned.
         */
        public TimeSpan getOccupancyDuration() {
            if (spotStatus == SpotStatus.OCCUPIED) {
                return DateTime.Now.Subtract(this.occupancyBeginTime);
            }
            return TimeSpan.Zero;
        }
        /* getOccupancyBeginTime - will return the time when a customer first arrived at the spot, if no customer 
         * is present, now's time will be returned. (Until i think of a better way to deal with this.)
         */
        public DateTime getOccupancyBeginTime() {
            if (spotStatus == SpotStatus.OCCUPIED) {
                return this.occupancyBeginTime;
            }
            return DateTime.Now;
        }
    }
}