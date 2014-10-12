using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApplication1 {

    public partial class Form1 : Form {
        private Random random = new Random();
        private ArrayList firstNames;
        private ArrayList lastNames;
        private Garage myTestGarage;
        public Form1() {
            InitializeComponent();
            myTestGarage = new Garage();
            loadFromFile();
            buttonGenerateGC_Click(this, null);
            
            InitializeForm();
        }
        private void InitializeForm() {
 
        }
       
   
        private void buttonGenerateGC_Click(object sender, EventArgs e) {
            //int howManyFloors = (int)numericFloors.Value;
            //int howManySpots = (int)numericSpots.Value;
            int howManyFloors = 3;
            int howManySpots = 100;
            Floor tempFloor = null;
            myTestGarage = new Garage(howManyFloors);
            for (int floorNumber = 0; floorNumber < howManyFloors; floorNumber++) {
                tempFloor = new Floor(howManySpots, floorNumber);
                for (int spotNumber = 0; spotNumber < tempFloor.getMaximumSpots(); spotNumber++) {
                    Spot tempSpot = new Spot(spotNumber);
                    Customer tempCustomer = new Customer();
                    tempCustomer.setBillingName(firstNames[random.Next(0, firstNames.Count - 1)].ToString() +" "+ lastNames[random.Next(0, lastNames.Count - 1)].ToString()); 
               //     tempCustomer.setLicensePlate(generatePlate());
                    int c = random.Next(1, 100);
                    if((c >= 1) && (c < 10)) {
                        tempCustomer.color = 1;
                    }
                    if ((c >= 10) && (c < 30)) {
                        tempCustomer.color = 2;
                    }
                    if ((c >= 30) && (c < 100)) {
                        tempCustomer.color = 3;
                    }
                    tempSpot.assignCustomer(tempCustomer);
                    //tempFloor.incOccupancy();
                    tempFloor.setOccupancyCount(random.Next(50, 100));
                    tempFloor.setSpot(spotNumber, tempSpot);
                }
                myTestGarage.setFloor(floorNumber, tempFloor);
            }
            listBox1.Items.Clear();
            listBox1.Items.Add("Input:");
            listBox1.Items.Add("# of Floors = " + howManyFloors.ToString());
            if(howManyFloors != 0) {
                listBox1.Items.Add("# of Spots = " + howManySpots.ToString());
            } else {
                listBox1.Items.Add("# of Spots = " + 0);
            }
            listBox1.Items.Add("");
            listBox1.Items.Add("Output:");
            listBox1.Items.Add("Garage.floorCount = " + myTestGarage.getFloorCount().ToString());
            for (int floorNumber = 0; floorNumber < myTestGarage.getFloorCount(); floorNumber++) {
                listBox1.Items.Add("Garage.floor["
                    + floorNumber.ToString() + "].spotCount = "
                    + myTestGarage.getFloor(floorNumber).getMaximumSpots().ToString()
                );
                for (int spotNumber = 0; spotNumber < myTestGarage.getFloor(floorNumber).getMaximumSpots(); spotNumber++) {
                    if (myTestGarage.getFloor(floorNumber).spotExists(spotNumber)) {
                        listBox1.Items.Add("Garage.floor["
                        + floorNumber.ToString() + "].Spot[" + spotNumber.ToString() + "] Exists!"
                        );
                    }
                }
            }
            InitializeForm();
        }
        public void loadFromFile() {
            firstNames = new ArrayList();
            lastNames = new ArrayList();
            StreamReader objReader = new StreamReader("firstnames.txt");
            string sLine = "";
            while (sLine != null) {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    firstNames.Add(sLine);
            }
            objReader.Close();

            objReader = new StreamReader("lastnames.txt");
            sLine = "";
            while (sLine != null) {
                sLine = objReader.ReadLine();
                if (sLine != null)
                    lastNames.Add(sLine);
            }
            objReader.Close();
            //listBox1.Items.Add("firstnames = " + firstNames.Count);
            //listBox1.Items.Add("lastnames = " + lastNames.Count);
        }
        /* Clear the input and output fields.
         */
        private void buttonClearGF_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            numericSpots.Value = 0;
            numericFloors.Value = 0;
        }
        /* Destroys the garage object.
         */
        private void buttonDestroyGF_Click(object sender, EventArgs e) {
            myTestGarage = null;
        }
       
        }

        }
    
