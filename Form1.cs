/* Student Name: AKASH RAGUPATHI
 * Student ID: 24232954
 * Date: 04/10/2024
 * Assignment: 1
 * Assignment: Create a sales quote calculator
 * for Solar4U company
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Solar4U
{
    public partial class mainForm : Form
    {
        // Declaring global variables for totalQuoteGroupBox
        int quoteTotal;
        decimal totalQuoteValue, averageQuoteValue;
        decimal totalSolarPanelCost, totalBatteryCost, totalInverterCost, totalInstallationCost;
        public mainForm()
        {
            InitializeComponent();
        // Setting up ToolTip for all buttons in the application
            InformationToolTip.SetToolTip(loginButton, "Click to Login");
            InformationToolTip.SetToolTip(quoteButton, "Click to generate quote");
            InformationToolTip.SetToolTip(clearButton, "Click to generate new quote");
            InformationToolTip.SetToolTip(summaryButton, "Click to view summary");
            InformationToolTip.SetToolTip(exitButton, "Click to exit");
        }
        
        // Setting up actions for Enter Button
        private void loginButton_Click(object sender, EventArgs e)
        {
            loginPanel.Visible = false;
            logoBox.Visible = false;
            itemCountGroupBox.Visible = true;
            controlPanel.Visible = true;
            footerImage.Visible = true;
            summaryButton.Enabled = false;
            this.Text = "Data Entry for Sales Rep " +nameBox.Text+ " Quote ID: " +idBox.Text;
            panelInputTextBox.Focus();
            
        }

        // Setting up actions for Exit Button
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Setting up actions for Summary Button
        private void summaryButton_Click(object sender, EventArgs e)
        {
            itemCountGroupBox.Visible = false;
            summaryGroupBox.Visible = false;
            totalQuoteGroupBox.Visible = true;
            quoteButton.Enabled = false;
        }

        // Setting up actions for Clear Button
        private void clearButton_Click(object sender, EventArgs e)
        {
            itemCountGroupBox.Enabled = true;
            quoteButton.Enabled = true;
            loginPanel.Visible = true;
            logoBox.Visible = true;
            itemCountGroupBox.Visible = false;
            controlPanel.Visible = false;
            summaryGroupBox.Visible = false;
            footerImage.Visible = false;
            totalQuoteGroupBox.Visible=false;
            nameBox.Clear();
            idBox.Clear();
            panelCostOutputLabel.Text = "";
            batteryCostOutputLabel.Text="";
            inverterCostOutputLabel.Text="";
            totalCostOutputLabel.Text="";
            panelPercentageLabel.Text="";
            batteryPercentageLabel.Text="";
            inverterPercentageLabel.Text="";
            installationPercentageLabel.Text="";

            panelInputTextBox.Text = "0";
            batteryInputTextBox.Text = "0";
            inverterInputTextBox.Text = "0";

            this.Text = "Solar4U Sales Quote Calculator";
            nameBox.Focus();
        }

        /*  Setting up execption handeling, actions and calculations  
         *  for Quote Button to display result in Quote Summary 
         *  and Total Quote Summary or provide error message
         *  if invalid input is entered
        */
        private void quoteButton_Click(object sender, EventArgs e)
        {
            
            try // try block for SolarPanel
            {
                int solarPanel = int.Parse(panelInputTextBox.Text);
                try // try block for Battery
                {
                    int battery = int.Parse(batteryInputTextBox.Text);
                    try // try block for Inverter
                    {
                        int inverter = int.Parse(inverterInputTextBox.Text);
                        itemCountGroupBox.Enabled = false;
                        summaryGroupBox.Visible = false;
                        itemCountGroupBox.Visible = true;
                        controlPanel.Visible = true;
                        summaryButton.Enabled = true;
                        quoteButton.Enabled = false;
                        summaryGroupBox.Visible = true;
                        

                        decimal solarPanelCost, batteryCost, inverterCost, totalCost, panelCostPercentage, batteryCostPercentage, inverterCostPercentage, installationCostPercentage;
                    // Declaring static cost values for each item
                        const decimal installationCost = 499m;
                        const decimal costOfpannel = 119.50m;
                        const decimal costOfBattery = 568.75m;
                        const decimal costOfInverter = 244m;


                    // Calculating the individual cost of products and total cost  
                        solarPanelCost = solarPanel * costOfpannel;
                        batteryCost = battery * costOfBattery;
                        inverterCost = inverter * costOfInverter;
                        totalCost = solarPanelCost + batteryCost + inverterCost + installationCost;
                    // Calculating the cost percentage of products
                        panelCostPercentage = solarPanelCost / totalCost;
                        batteryCostPercentage = batteryCost / totalCost;
                        inverterCostPercentage = inverterCost / totalCost;
                        installationCostPercentage = installationCost / totalCost;

                    // Calculating values for totalQuoteGroupBox
                        quoteTotal++;
                        totalSolarPanelCost += solarPanelCost;
                        totalBatteryCost += batteryCost;
                        totalInverterCost += inverterCost;
                        totalInstallationCost += installationCost;
                        totalQuoteValue += totalCost;
                        averageQuoteValue = totalQuoteValue / quoteTotal;

                    // Appending cost output and percentage output into summaryGroupBox
                        panelCostOutputLabel.Text = solarPanelCost.ToString("C");
                        batteryCostOutputLabel.Text = batteryCost.ToString("C");
                        inverterCostOutputLabel.Text = inverterCost.ToString("C");
                        installationCostOutputLabel.Text = installationCost.ToString("C");
                        totalCostOutputLabel.Text = totalCost.ToString("C");
                        panelPercentageLabel.Text = panelCostPercentage.ToString("P");
                        batteryPercentageLabel.Text = batteryCostPercentage.ToString("P");
                        inverterPercentageLabel.Text = inverterCostPercentage.ToString("P");
                        installationPercentageLabel.Text = installationCostPercentage.ToString("P");
                    // Appending incremental output into totalQuoteGroupBox
                        quoteCountLabel.Text = quoteTotal.ToString();
                        totalPanelCostLabel.Text = totalSolarPanelCost.ToString("C");
                        totalBatteryCostLabel.Text = totalBatteryCost.ToString("C");
                        totalInverterCostLabel.Text = totalInverterCost.ToString("C");
                        totalInstallationCostlabel.Text = totalInstallationCost.ToString("C");
                        quoteTotalValueLabel.Text = totalQuoteValue.ToString("C");
                        quoteAverageValueLabel.Text = averageQuoteValue.ToString("C");
                    }
                    catch // catch block for inverter

                    {
                        MessageBox.Show("Please enter numerical data for Inverters","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        inverterInputTextBox.Focus();
                        inverterInputTextBox.SelectAll();

                    }
                }
                catch // catch block for battery
                {
                    MessageBox.Show("Please enter numerical data for Batteries","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    batteryInputTextBox.Focus();
                    batteryInputTextBox.SelectAll();
                }
            }
            catch // catch block for SolarPanel
            {
                MessageBox.Show("Please enter numerical data for Solar Panel ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                panelInputTextBox.Focus();
                panelInputTextBox.SelectAll();
            }
        }
      
    }
}
