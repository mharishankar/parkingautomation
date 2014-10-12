using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Xml.Linq;
using Entities; 


namespace BusinessLogic
{
    public class Exit
    {
        bool sensor_update(Spot spotNumber, spotID spotid, Floor floorno) //return true if the spot availability is updated successfully when a car leaves a spot
        {
            bool update_successful = false; //the return variable is initially set to false

            if ((spotNumber.getCustomer()).getCustomerType() == 3)
            {    //if the leaving customer is a contract customer we do not have to update the availability of the spot or increase the number of spots available in that floor. A contract customer's spot is always marked as occupied for the duration of the contract.
                update_successful = true;
            }

            else // if the leaving customer is not a contract customer
            {
                spotNumber.setSpotStatus(Entities.Spot.SpotStatus.VACANT); //set the spot that the customer left from as vacant.
                int fn = spotid.getFloorNumber(); //floor number of the spot that just became vacant.

                update_successful = floorno.decOccupancy(); //returns true if the occupancy of the floor is decreased successfully.
            }

            return update_successful;
       }
   }
}
