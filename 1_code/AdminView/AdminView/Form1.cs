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
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApplication1 {

    public partial class Form1 : Form {
        private Random random = new Random();
        private ArrayList firstNames;
        private ArrayList lastNames;
        private Garage myTestGarage;
        public Form1() {
            InitializeComponent();
            button1_Click(this, null);
            myTestGarage = new Garage();
            loadFromFile();
            buttonGenerateGC_Click(this, null);
            buttonSaveGF_Click(this, null);
            
            InitializeForm();
        }
        private void InitializeForm() {
            cbFloorSelect.Items.Clear();
            for(int i = 0; i < myTestGarage.getFloorCount(); i++) {
                cbFloorSelect.Items.Add("Floor " + (i + 1));
            }
            if(cbFloorSelect.Items.Count > 0) {
                cbFloorSelect.SelectedIndex = 0;
            }
            //Connecting to the database
            SqlConnection connection = new SqlConnection("Data Source=(local);Initial Catalog=Park;Integrated Security=True");
            connection.Open();
            if (connection == null)
                Close();
        }
        private void button1_Click(object sender, EventArgs e) {
            for(int i = 0; i < gv.ColumnCount; i++) {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                gv.Columns[i].Width = 40;
                gv.Columns[i].Resizable = DataGridViewTriState.False;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gv);
                for(int j = 0; j < gv.ColumnCount; j++) {
                    row.Height = 40;
                    row.Resizable = DataGridViewTriState.False;

                    row.Cells[j].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    row.Cells[j].Value = (j + 1) + (i * 10);
                    row.Cells[j].Style.BackColor = Color.White;
                }
                //row.Cells[1].Style.BackColor = Color.Red;
                gv.Rows.Add(row);
            }
            DataGridViewRow YourNewRow = new DataGridViewRow();
            YourNewRow.CreateCells(gv);
            gv.Rows[1].Cells[1].Style.BackColor = Color.Red;
        }
        private void createGV2() {
            for(int i = 0; i < 200; i++) {
                DataGridViewTextBoxColumn newCol = new DataGridViewTextBoxColumn();
                //gv2.Columns[i].Width = 40;
                //gv2.Columns[i].Resizable = DataGridViewTriState.False;
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(gv2);
                row.Cells[0].Value = lastNames[random.Next(0, lastNames.Count - 1)];
                row.Cells[1].Value = firstNames[random.Next(0, firstNames.Count - 1)];
                row.Cells[2].Value = generatePlate();
                gv2.Rows.Add(row);
            }
            
 
        }
        private void gv_CellClick(object sender, DataGridViewCellEventArgs e) {
            DataGridViewCell cell = (DataGridViewTextBoxCell)gv.Rows[e.RowIndex].Cells[e.ColumnIndex];
        //    if (cell.Style.BackColor == Color.Red) {
        //        label1.Text = "You bastard " + cell.Value + "you have over stayed since March 8th!";
        //    }
            int spotNumber = (e.ColumnIndex + 1) + (e.RowIndex * 10) - 1;
            int floorNumber = cbFloorSelect.SelectedIndex;
            label1.Text = "Displaying Spot # " + cell.Value.ToString();
            Customer tempCustomer = myTestGarage.getFloor(floorNumber).getSpot(spotNumber).getCustomer();
            if(tempCustomer != null) {
                label22.Text = tempCustomer.getBillingName();
                label22.Visible = true;
                label24.Text = tempCustomer.getLicensePlate();
                label24.Visible = true;
            }
            if(cell.Style.BackColor == Color.White) {
                label22.Visible = false;
                label24.Visible = false;
            }
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
                    tempCustomer.setLicensePlate(generatePlate());
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
        private void cbFloorSelect_SelectedIndexChanged(object sender, EventArgs e) {
            for(int x = 0; x < 10; x++) {
                for(int y = 0; y < 10; y++) {
                    DataGridViewCell cell = (DataGridViewTextBoxCell)gv.Rows[x].Cells[y];
                    cell.Style.BackColor = Color.White;
                }
            }
            
            
            int floor = cbFloorSelect.SelectedIndex;
            labelDFloor.Text = "Displaying Floor " + (floor + 1).ToString();
            if(myTestGarage.floorExists(floor)) {
                
        
                int floorNumber = cbFloorSelect.SelectedIndex;
               // label1.Text = "Displaying Spot # " + cell.Value.ToString();
                
                
                
                labelOccupancy.Text = "Occupancy " + myTestGarage.getFloor(floor).getOccupancyCount().ToString()
                    + " / " + myTestGarage.getFloor(floor).getMaximumSpots().ToString();
                for(int i = 0; i < 10; i++) {
                    for(int j = 0; j < 10; j++) {
                        DataGridViewCell cell = (DataGridViewTextBoxCell)gv.Rows[i].Cells[j];
                        int spotNumber = (j + 1) + (i * 10) - 1;
                        if (spotNumber > (myTestGarage.getFloor(floorNumber).getOccupancyCount() - 1)) {
                            return;
                        }
                        Customer tempCustomer = myTestGarage.getFloor(floorNumber).getSpot(spotNumber).getCustomer();
                        
                        if(tempCustomer.color == 1) {
                            cell.Style.BackColor = Color.Yellow;
                        }
                        if (tempCustomer.color == 2) {
                            cell.Style.BackColor = Color.Red;
                        }
                        if (tempCustomer.color == 3) {
                            cell.Style.BackColor = Color.Green;
                        }
                        if (tempCustomer.color == 0) {
                            cell.Style.BackColor = Color.White;
                        }

                    }
                }
            }else{
                labelOccupancy.Text = "Occupancy 0 / 0";
            }
        }

        private void buttonSaveGF_Click(object sender, EventArgs e) {
            loadFromFile();
            for(int i = 0; i < 100; i++) {
                listBox1.Items.Add(generatePlate());
            }
            createGV2();
        }
        private String generatePlate() {
            int randomNumber = random.Next(100, 999);
            String[] letter = {"A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","V","W","X","Y","Z"};
            return randomNumber.ToString() + letter[random.Next(0, 25)] + letter[random.Next(0, 25)] + letter[random.Next(0, 25)]; 
        }

        private void buttonSearch_Click(object sender, EventArgs e) {
            String st = "";
            for(int i = 0; i < 100; i++) {
                st = gv2.Rows[i].Cells[0].Value.ToString();
                if(st.CompareTo(textBox1.Text) == 0) {
                   // gv2.Select(gv.Rows[1].Cells);
                }
            }
        }
    }
}