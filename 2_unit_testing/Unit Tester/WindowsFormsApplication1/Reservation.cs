/* Reservation.cs
 * Daniel Selmon 
 * Last Modified 3/17/12
 */
using System;

public class Reservation {
    /* Private data members / Field summary
     * beginDate    - Start date/time of the reservation.
     * endDate      - End date/time of the reservation.
     */
    private DateTime beginDate;
    private DateTime endDate;
    /* Constructors 
     *
     * Default Constructor
     */
    private Reservation() {
        this.beginDate = DateTime.Now;
        this.endDate = DateTime.Now;
    }
    /* Constructor 
     */
	public Reservation(DateTime beginDate, DateTime endDate) {
        this.beginDate = beginDate;
        this.endDate = endDate;
    }
    /* Accessor Methods
     */
    public DateTime getBeginDate() {
        return this.beginDate;
    }
    public DateTime getEndDate() {
        return this.endDate;
    }
    public TimeSpan getDuration() {
        return endDate.Subtract(beginDate); ;
    }
    /* Mutator Methods
     * 
     * setBeginDate
     */
    public void setBeginDate(DateTime beginDate) {
        this.beginDate = beginDate;
    }
    /* setEndDate
     */
    public void setEndDate(DateTime endDate) {
        this.endDate = endDate;
    }
}