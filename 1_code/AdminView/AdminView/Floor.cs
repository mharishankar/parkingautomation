/* Floor.cs
 * Daniel Selmon 
 * Last Modified: 3/24/12
 */
using System;
    public class Floor {
        /* Private data members / Private field summary:
         * floorNumber      - What level this floor is with respect to the ground.
         * spotCount        - Total number of spots on this floor.
         * occupancyCount   - How many cars are on this floor.
         * spotArray        - An Array containing pointers to spot objects.
         */
        private int maxSpots;
        private int floorNumber;
        private int occupancyCount;
        private Spot[] spotArray;
        /* Constructors:
         * 
         * Default Constructor - creates an generic floor object.
         */
        public Floor() {
            this.floorNumber = 0;
            this.maxSpots = 0;
            this.occupancyCount = 0;
            this.spotArray = null;
        }
        /* Overloaded constructor - creates a floor object with a level number and a number of spots.
         */
        public Floor(int maxSpots, int levelNumber) {
            if ((maxSpots >= 0) && (levelNumber >= 0)) {
                this.floorNumber = levelNumber;
                this.maxSpots = maxSpots;
                this.occupancyCount = 0;
                this.spotArray = new Spot[maxSpots];
            }
        }
        /* Mutator Methods:
         * 
         * incOccupancy - Will increment the floor's occupancyCount by 1. Should be called when a car enters the floor.
         * Returns True : The occupancy count was successfully incremented.
         * Returns False: You attempted to increment occupancy Count beyong the maximum spots on the floor.
         */
        public Boolean incOccupancy() {
            if (occupancyCount < maxSpots) {
                this.occupancyCount++;
                return true;
            }
            return false;
        }
        /* decOccupancy - Will decrement the floor's occupancyCount by 1. Should be called when a car leaves the floor.
         * Returns True : The occupancy count is sucessfully decremented.
         * Returns False: You attemp to decrement the occupany count below zero. 
         */
        public Boolean decOccupancy() {
            if (occupancyCount > 0) {
                this.occupancyCount--;
                return true;
            }
            return false;
        }
        /* setSpot - Will add a spot object to this floor.
         * Returns True : Spot was successfully added.
         * Returns False: The spotNumber is out of bounds of the spotArray.
         */
        public Boolean setSpot(int spotNumber, Spot theSpotObject) {
            if ((spotNumber >= 0) && (spotNumber < maxSpots)) {
                spotArray[spotNumber] = theSpotObject;
                return true;
            }
            return false;
        }
        /* setMaxSpots
         */
        public void setMaxSpots(int maxSpots) {
            if (maxSpots >= 0) {
                this.maxSpots = maxSpots;
            }
        }
        /* setOccupancyCount
         */
        public void setOccupancyCount(int occupancyCount) {
            if (occupancyCount >= 0) {
                this.occupancyCount = occupancyCount;
            }
        }
        /* setFloorNumber - sets the floornumber if the the input is
         * greater than zero.
         */
        public void setFloorNumber(int floorNumber) {
            if (floorNumber >= 0) {
                this.floorNumber = floorNumber;
            }
        }
        /* setSpotArray
         */
        public void setSpotArray(Spot[] spotArray) {
            this.spotArray = spotArray;
        }
        /* Accessor Methods:
         * 
         * getSpotCount - Will return the total number of spots on this floor.
         */
        public int getMaximumSpots() {
            return this.maxSpots;
        }
        /* getOccupancyCount - Will return how many cars are on this floor.
         */
        public int getOccupancyCount() {
            return this.occupancyCount;
        }
        /* getFloorNumber - Will return this floor's assigned number.
         */
        public int getFloorNumber() {
            return this.floorNumber;
        }
        /* getSpot - will return a spot object if it exists, otherwise will return null.
         */
        public Spot getSpot(int spotNumber) {
            if (spotExists(spotNumber)) {
                return spotArray[spotNumber];
            }
            return null;
        }
        /* getVacancy - will return this how many are vacant on this floor.
         */
        public int getVacancyCount() {
            return (maxSpots - occupancyCount);
        }
        /* Existantial/Other Methods
         * 
         * isEmpty - will return a boolean t/f that answers "is the floor Empty?".
         * Returns True : The floor is empty.
         * Returns False: The floor is not empty.
         */
        public Boolean isEmpty() {
            if (this.occupancyCount == 0) {
                return true;
            }
            return false;
        }
        /* isFull - will return a boolean t/f  that answers the question "is the floor Full?"
         * Returns True : The garage is full.
         * Returns False: The garage is not full.
         */
        public Boolean isFull() {
            if (this.occupancyCount == this.maxSpots) {
                return true;
            }
            return false;
        }
        /* spotExists - will determine if a spot exists.
         * Returns True : Spot is in bounds and not a null pointer. -> Exists
         * Returns False: Spot is a null pointer or out of the bounds of the spot array. -> DNE.
         */
        public Boolean spotExists(int spotNumber) {
            if ((spotNumber >= 0) && (spotNumber < maxSpots)) {
                if (spotArray[spotNumber] != null) {
                    return true;
                }
            }
            return false;
        }
    }
