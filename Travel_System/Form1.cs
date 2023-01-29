using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace Travel_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime iTime = DateTime.Now;
            lblTime.Text = iTime.ToLongTimeString();

            DateTime iDate = DateTime.Now;
            lblDate.Text = iDate.ToLongDateString();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            chkAirportTax.Checked = true;
            chkAirMiles.Checked = true;
            chkExtLuggage.Checked = true;
            chkTravelInsurance.Checked = true;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void txtPostCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSubtotal_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
        }
        

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rtReceipt.Clear();
            txtAddress.Clear();
            txtEmail.Clear();
            txtFirstname.Clear();
            txtPostCode.Clear();
            txtSurname.Clear();
            txtTelephone.Clear();

            lblSubtotal.Text = "";
            lblTax.Text = "";
            lblTotal.Text = "";

            cmbAccommodation.Text = "None";
            cmbDeparture.Text = "None";
            cmbDestination.Text = "None";

            chkAirMiles.Checked = false;
            chkAirportTax.Checked = false;
            chkExtLuggage.Checked = false;
            chkSpecialNeeds.Checked = false;
            chkTravelInsurance.Checked = false;
            chkAdult.Checked = false;
            chkChild.Checked = false;
            chkReturn.Checked = false;
            chkSingle.Checked = false;

            rbStandard.Checked = false;
            rbEconomy.Checked = false;
            rbFirstClass.Checked = false;



        }
        private void chkSpecialNeeds_CheckedChanged(object sender, EventArgs e)
        {
        }




        private void btnTotal_Click(object sender, EventArgs e)
        {
            cPrice Travelprice = new cPrice();
            iTax AirTax = new iTax();
            double[] TravelCost = new double[20];
            double[] TaxCost = new double[20];
            Double Total;

            if (cmbDestination.Text == " Islamabad ")
            {
                TravelCost[0] = Travelprice.Islamabad + Travelprice.Airport_Tax + Travelprice.Air_Miles + Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Karachi ")
            {
                TravelCost[0] = Travelprice.Karachi + Travelprice.Airport_Tax + Travelprice.Air_Miles +Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Hyderabad ")
            {
                TravelCost[0] = Travelprice.Hyderabad + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Sukkar ")
            {
                TravelCost[0] = Travelprice.Sukkar + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Multan ")
            {
                TravelCost[0] = Travelprice.Multan + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;
                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Quetta ")
            {
                TravelCost[0] = Travelprice.Quetta + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Bahawalpur ")
            {
                TravelCost[0] = Travelprice.Bahawalpur + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Chaman ")
            {
                TravelCost[0] = Travelprice.Chaman + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Sahiwal ")
            {
                TravelCost[0] = Travelprice.Sahiwal + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Faisalabad ")
            {
                TravelCost[0] = Travelprice.Faisalabad + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Sargodha ")
            {
                TravelCost[0] = Travelprice.Sargodha + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Rawalpindi ")
            {
                TravelCost[0] = Travelprice.Rawalpindi + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Peshawar")
            {
                TravelCost[0] = Travelprice.Peshawar + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Nowshera ")
            {
                TravelCost[0] = Travelprice.Nowshera + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " DIK ")
            {
                TravelCost[0] = Travelprice.Dera_Ismail_Khan + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " DGK ")
            {
                TravelCost[0] = Travelprice.Dera_Ghazi_Khan + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Muzaffarabad ")
            {
                TravelCost[0] = Travelprice.Muzaffarabad + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
            if (cmbDestination.Text == " Azad Kashmir ")
            {
                TravelCost[0] = Travelprice.Azad_Kashmir + Travelprice.Airport_Tax + Travelprice.Air_Miles +
                    Travelprice.Insurance + Travelprice.Ext_Luggage;

                TaxCost[0] = AirTax.iFindTax(TravelCost[0]);
                Total = TravelCost[0] + TaxCost[0];

                lblSubtotal.Text = String.Format("{ 0:C}", TravelCost[0]);
                lblTax.Text = String.Format("{ 0:C}", TaxCost[0]);
                lblTotal.Text = String.Format("{ 0:C}", Total);

            }
        }




        private void btnReceipt_Click(object sender, EventArgs e)
        {
            int num1;
            Random rnd = new Random();
            num1 = rnd.Next(4238, 34238);
            num1 = 1325 + num1;
            String refs = Convert.ToString(num1);
            //==================================================================
                 rtReceipt.AppendText("\tTravel Management System:\n\n"
                 +"Ref:\t\t\t\t" + refs
                 +"\n--------------------------------------------------------------------------"
                 +"\nName:\t\t\t"+txtFirstname.Text
                 +"\nSurname:\t\t\t"+txtSurname.Text
                 +"\nAddress:\t\t\t"+txtAddress.Text
                 +"\nPostcode:\t\t" +txtPostCode.Text
                 +"\nTelephone:\t\t" +txtTelephone.Text
                 +"\nEmail:\t\t\t"+txtEmail.Text
                 +"\nDestination:\t\t"+cmbDestination.Text
                 +"\n--------------------------------------------------------------------------"
                 +"\n Tax:\t\t\t\t" + lblTax.Text
                 +"\n Sub Total:\t\t\t" + lblSubtotal.Text
                 +"\n Total:\t\t\t\t" + lblTotal.Text
                 +"\n--------------------------------------------------------------------------"
                 +"\n"   + lblDate.Text + "\t\t\t" + lblTime.Text
                 +"\n--------------------------------------------------------------------------"
                 +"\n\n   Thanks For Using\n\t Travel Management System"
            );

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void lblTax_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}


    

    



