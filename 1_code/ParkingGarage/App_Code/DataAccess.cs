using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Entities;

namespace DataAccess {
    public static class DataAccessing {

        public static void addReservation(Customer customer, DateTime starttime, DateTime endtime) {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Park;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("addReservationToDatabase", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@customerid", customer.getCustomerID());
            cmd.Parameters.AddWithValue("@carno", customer.getLicensePlate());
            cmd.Parameters.AddWithValue("@ReservationStartDate", starttime);
            cmd.Parameters.AddWithValue("@ReservationEndDate", endtime);
            cmd.ExecuteNonQuery();
            if (connection != null) {
                connection.Close();
            }
        }

        public static bool checkifUser(string userName, string password) {
         SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Park;Integrated Security=True");
         connection.Open();
         SqlCommand cmd = new SqlCommand("verifyIfUser", connection);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue("@userName", userName);
         cmd.Parameters.AddWithValue("@user_password", password);
         cmd.Parameters.Add("@return", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
         cmd.ExecuteNonQuery();
         int i = (int)cmd.Parameters["@return"].Value; 
         if (connection != null) {
             connection.Close();
         }
         if (i == 1) {
             return true;
         }

         return false;
        }

        public static bool isRegisteredLicense(string LicensePlate) {
         SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Park;Integrated Security=True");
         connection.Open();
         SqlCommand cmd = new SqlCommand("isRegisteredPlate", connection);
         cmd.CommandType = CommandType.StoredProcedure;
         cmd.Parameters.AddWithValue("@carPlateNo", LicensePlate);
         cmd.Parameters.Add("@return", SqlDbType.Int).Direction = ParameterDirection.ReturnValue;
         cmd.ExecuteNonQuery();
         int i = (int)cmd.Parameters["@return"].Value;
         if (connection != null) {
             connection.Close();
         }
         if (i == 1) {
             return true;
         }

         return false;
        }


        public static void setGarage(int floors, int spots) {
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Park;Integrated Security=True");
            connection.Open();
            SqlCommand cmd = new SqlCommand("setgarage", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@floors", floors);
            cmd.Parameters.AddWithValue("@spots", spots);
            cmd.ExecuteNonQuery();
            if (connection != null) {
                connection.Close();
            }
        }

    
        public static void findCustomerwithLicense(string LicensePlate, Customer theCustomer) {
            string str = "Data Source=(local);Initial Catalog=Park;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("getMemberDetails", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@carPlateNo", LicensePlate);
            if (connection != null) {
                connection.Close();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0) {
                RegisteredCustomer tempCustomer = (RegisteredCustomer) theCustomer;
                tempCustomer.setCustomerID(Convert.ToInt32(ds.Tables[0].Rows[0]["memberid"]));
                tempCustomer.setLicensePlate(LicensePlate);
                Reservation reservation = new Reservation();
                reservation.setBeginDate(Convert.ToDateTime((ds.Tables[0].Rows[0]["reservation_startDate"])));
                reservation.setBeginDate(Convert.ToDateTime((ds.Tables[0].Rows[0]["reservation_endDate"])));
                tempCustomer.getReservationList().AddLast(reservation);                
            }
        }



        public static void findCustomerwithUsername(string username, Customer theCustomer) {
            string str = "Data Source=(local);Initial Catalog=Park;Integrated Security=True";
            SqlConnection connection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("getMemberDetailswithUsername", connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@userName", username);
            if (connection != null) {
                connection.Close();
            }
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0) {
                RegisteredCustomer tempCustomer = (RegisteredCustomer)theCustomer;
                tempCustomer.setCustomerID(Convert.ToInt32(ds.Tables[0].Rows[0]["memberid"]));
                tempCustomer.setLicensePlate((ds.Tables[0].Rows[0]["carPlateNo"]).ToString());
                Reservation reservation = new Reservation();
                reservation.setBeginDate(Convert.ToDateTime((ds.Tables[0].Rows[0]["effectiveStartDate"])));
                reservation.setBeginDate(Convert.ToDateTime((ds.Tables[0].Rows[0]["effectiveEndDate"])));
                tempCustomer.getReservationList().AddLast(reservation);
                int spot = (Convert.ToInt32(ds.Tables[0].Rows[0]["parkingLocation"]));

            }
        }
    }
}