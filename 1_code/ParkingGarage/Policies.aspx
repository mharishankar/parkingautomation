<%@ Page Language="C#" MasterPageFile="~/ParkingGarage.master" AutoEventWireup="true" CodeFile="Policies.aspx.cs" Inherits="Policies" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<font size = "3">
<ul>
<li>Contract customers have a guaranteed spot.</li>
<li>If a reserved customer arrives and the garage is full, the user will be asked to leave the garage and won’t be charged for <br /> the
reserved duration. To compensate for the inconvenience a rain cheque will be issued to the customer.</li>
<li>If a user wants to make a reservation it has to be for at least 30 minutes.</li>
<li>If a reserved user doesn’t arrive within the reserved period of time he will be charged for the entire reservation time.</li>
<li>If a reserved user decides to leave the garage before the reserved period of time, he will still be charged for the entire <br /> reservation
period.</li>
<li>Users who have made a reservation can extend their reservation anytime before the end of the reserved duration provided <br />there are available
 spots.</li>
<li>If a user wants to cancel a particular reservation, it has to be done at least 30 minutes prior to the end of the <br /> reservation period. If it is
canceled successfully then the user won’t be charged anything. If not then the user will be<br /> just charged for the entire reservation period.</li>
<li>Walk-in customers (unreserved registered and unregistered customers) will be charged at a higher rate than reserved <br /> contract customers.</li>
<li>Customers who do not leave the garage before the end of the reservation period will be charged at overstay rates for the <br /> time of stay after
 the end of the reservation period. Overstay customers will receive a text message warning them of <br /> the overstay policy.</li>
<li>A user can have multiple standing reservations under his account but these reservations cannot be contiguous. A minimum<br /> gap will  be imposed
 between consecutive reservations. If it is less than that minimum gap the user will be asked to <br /> merge the reservation. A user can have up to 3 
 outstanding reservations.</li>
<li>More than one user cannot use the same number plate to make reservations or use the garage for the same time duration.</li>
<li>Registered users have to log into their account in order to pay their monthly bills. They can use either a credit or debit <br /> card to pay their bills.
 In our efforts to go green we won’t be mailing out monthly bills. Instead an email reminding <br />users of their monthly bills will be sent.</li>
<li>Registered users have until the 10th of every month to pay their last month bills. Failure to do so will result in an <br />addition of late fee to their
monthly bill. Users can pay their monthly bill with the late fee until the 20th of next month. If we<br /> don’t receive a payment from the user by 20th an automatic deduction will be made from the user’s account which was<br /> provided during registration.</li>

<li>Unregistered walk-in customers will have to pay the parking fares in order to be able to exit the garage.</li>
 </ul>
 </font>
</asp:Content>

