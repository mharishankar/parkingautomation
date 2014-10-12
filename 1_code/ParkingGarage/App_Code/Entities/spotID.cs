
using System;
namespace Entities {
    /* This class is bad, I need to rewrite it. */

    public class spotID {
        /* Private data members / Field Summary
         * floorNumber  - Which floor the spot is located on.
         * spotNumber   - Which spot.
         * idString     - Complete id in the form of [floorNumber] + [padded zeroes] + [spotNumber]
         */
        private int floorNumber;
        private int spotNumber;
        private String idString;
        private TimeSpan stayDuration;
        /* Constructor
         */
        public spotID(int floorNumber, int spotNumber, int maxSpotLength) {
            String leadingZeros = "";
            this.floorNumber = floorNumber;
            this.spotNumber = spotNumber;
            /* Pad spot number */
            for (int i = 0; i < maxSpotLength; i++) {
                leadingZeros += "0";
            }
            this.idString = floorNumber.ToString() + spotNumber.ToString(leadingZeros);
        }
        /* getFloorNumber will return just the floor number segment.
         */
        public int getFloorNumber() {
            return this.floorNumber;
        }
        /* getSpotNumber will return the spot number segment.
         */
        public int getSpotNumber() {
            return this.spotNumber;
        }
        public TimeSpan getStayDuration() {
            return this.stayDuration;
        }
        public void setStayDuration(TimeSpan stayDuration) {
            this.stayDuration = stayDuration;
        }
    }
}