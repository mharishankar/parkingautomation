using System;
using System.Collections.Generic;
using System.Text;
using DataAccess;
using Entities;

namespace BusinessLogic {
    public static class PlateChecker {
         public static bool isRegisteredPlate (string LicensePlate){
            return DataAccessing.isRegisteredLicense(LicensePlate);
    }
        public static void customerLookupWithLicense(string LicensePlate, Customer theCustomer) {
            
            DataAccessing.findCustomerwithLicense(LicensePlate, (RegisteredCustomer) theCustomer);
        }
        public static void customerLookupWithUsername(string Username, Customer theCustomer) {
            
            DataAccess.DataAccessing.findCustomerwithLicense(Username, (RegisteredCustomer)theCustomer);
        }
    }
}