/* Garage.cs
 * Daniel Selmon 
 * Last Modified 3/24/12
 */
using System;

public class Garage {
    /* Private data members / Field Summary
     * floorCount - The number of floors the garage will have.
     * floorArray - an array of floor objects. An array was chosen because the # of floors is constant and for direct access.
     */
    private int floorCount;
    private Floor[] floorArray;   
	/* Constructors
     * 
     * Default Constructor - will create a generic garage object. (Not useful yet)
     */
    public Garage() {
        this.floorCount = 0;
        floorArray = null;
	}
    /* Overloaded Constructor (Useful)
     */
    public Garage(int floorCount) {
        if(floorCount >= 0) {
            this.floorCount = floorCount;
            this.floorArray = new Floor[floorCount];
        }
    }
    /* Mutator Methods:
     * 
     * setFloor - will set a pointer in the floorArray to the given floor Object.
     * Returns True : when the floor was created successfully.
     * Returns False: when the index is out of bounds.
     */
    public Boolean setFloor(int floorNumber, Floor floorObject) {
       if((floorNumber >= 0) && (floorNumber < floorCount)) {
           this.floorArray[floorNumber] = floorObject;
           return true;
       }
       return false;
    }
    /* setFloorCount
     */
    public Boolean setFloorCount(int floorCount) {
        if(floorCount > 0 ) {
            this.floorCount = floorCount;
            return true;
        }
        return false;
    }
    /* setFloorArray
     */
    public void setFloorArray(Floor[] floorArray) {
        this.floorArray = floorArray;
    }
    /* Accessor Methods:
     * 
     * getFloor - will return a floor object if it exists, otherwise it will return null.
     */
    public Floor getFloor(int floorNumber) {
        if(floorExists(floorNumber)) {
            return floorArray[floorNumber];
        }
        return null;
    }
    public Floor[] getFloorArray() {
        return this.floorArray;
    }
    /* getFloorCount - will return the number of floors in this garage. 
     */
    public int getFloorCount() {
        return this.floorCount;
    }
    /* Existantial Methods:
     * 
     * floorExits - will return a boolean t/f
     * Returns true : when the floor exists. 
     * Returns false: array out of bounds and null pointer.
     */
    public Boolean floorExists(int floorNumber) {
        if((floorNumber >= 0) && (floorNumber < floorCount)) {
            if(floorArray[floorNumber] != null) {
                return true;
            }
        }
        return false;
    }
}