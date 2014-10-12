using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }
        private Garage myTestGarage;
        /* Build a Sample Garage.
         */
        private void button1_Click(object sender, EventArgs e) {
            int howManyFloors = int.Parse(textBoxFloors.Text.Trim());
            int howManySpots = int.Parse(textBoxSpots.Text.Trim());
            Floor tempFloor = null;
            myTestGarage = new Garage(howManyFloors);
            for(int floorNumber = 0; floorNumber < howManyFloors; floorNumber++) {
                tempFloor = new Floor(howManySpots, floorNumber);
                for(int spotNumber = 0; spotNumber < tempFloor.getMaximumSpots(); spotNumber++) {
                    Spot tempSpot = new Spot(spotNumber);
                    tempFloor.setSpot(spotNumber, tempSpot);
                }
                myTestGarage.setFloor(floorNumber, tempFloor);
            }
            listBox1.Items.Add("Input:");
            listBox1.Items.Add("# of Floors = " + textBoxFloors.Text);
            listBox1.Items.Add("# of Spots = " + textBoxSpots.Text);
            listBox1.Items.Add("");
            listBox1.Items.Add("Output:");
            listBox1.Items.Add("Garage.floorCount = " + myTestGarage.getFloorCount().ToString());
            for(int floorNumber = 0; floorNumber < myTestGarage.getFloorCount(); floorNumber++) {
                listBox1.Items.Add("Garage.floor[" 
                    + floorNumber.ToString() + "].spotCount = " 
                    + myTestGarage.getFloor(floorNumber).getMaximumSpots().ToString()
                );
                for(int spotNumber = 0; spotNumber < myTestGarage.getFloor(floorNumber).getMaximumSpots(); spotNumber++ ) {
                    if(myTestGarage.getFloor(floorNumber).spotExists(spotNumber)) {
                        listBox1.Items.Add("Garage.floor[" 
                        + floorNumber.ToString() + "].Spot["+ spotNumber.ToString() + "] Exists!"
                        ); 
                    }
                }
            }
        }
        /* Clear the input and output fields.
         */
        private void button2_Click(object sender, EventArgs e) {
            listBox1.Items.Clear();
            textBoxFloors.Text = "";
            textBoxSpots.Text = "";
        }
        /* Destroys the garage object.
         */
        private void button3_Click(object sender, EventArgs e) {
            myTestGarage = null;
        }
        /* Save file dialog.
         */
        private void button4_Click(object sender, EventArgs e) {
            saveFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.FileName = "Output";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)	{
                System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName);
                foreach (object item in listBox1.Items) {
    	            sw.WriteLine(item.ToString());
                }
                    sw.Close();
		    }
        }
    }
}