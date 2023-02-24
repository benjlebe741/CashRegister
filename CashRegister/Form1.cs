using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Media;

namespace CashRegister
{
    public partial class Form1 : Form
    {
        //keep track of the starting recipt height
        int originalReciptHeight;

        //generate a random order number, and make an int to store that value as the program begins
        Random randomGen = new Random();
        int orderNumber;

        //declare variables which store the player inputs
        double numOfTims = 0, numOfBits = 0, numOfHorts = 0, tenderedAmount = 0;
      
        //declare variables which store program calculations
        double subAmount = 0, taxAmount = 0, totalAmount = 0, changeAmount = 0;

        //pre-determined prices
        double priceOfTims = 3.25, priceOfBits = 1.50, priceOfHorts = 5.99, taxRate = 0.13;

        //declare all play-sound possibilities
        SoundPlayer slash = new SoundPlayer(Properties.Resources.undertaleSlash);
        SoundPlayer click = new SoundPlayer(Properties.Resources.click);

        //=WAIT(TIME)-------------------------------------------------------------------------------------------
        private void wait(int waitTime)
        {
            Refresh();
            Thread.Sleep(waitTime);
        } 
        
        //=UPDATE TIMER-------------------------------------------------------------------------------------------
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                //ORDER BUTTON:
                //Has the player put in a value in each input feild? Are No feilds are left blank?
                 if ((numBitsInput.Text != "") && (numTimsInput.Text != "") && (numHortsInput.Text != ""))
                {
                    //Has the player put in a value >= to zero in each input feild? We cant check both if statements at the same time, because if try {} finds an error it just wont update: a feild is left blank doesnt get recognized
                    if ((Convert.ToDouble(numBitsInput.Text) >= 0 && Convert.ToDouble(numTimsInput.Text) >= 0 && Convert.ToDouble(numHortsInput.Text) >= 0))
                    {
                        //If so, player can use "what do I owe ya" button 
                        owedButton.Enabled = true; 
                    }
                }
                else owedButton.Enabled = false;

                //GIVE CHANGE BUTTON:
                //Has the player found their total amount? and is the amount they gave greated or equal to that total amount? TDLR, player is paying correctly            
                if ((totalOutputLabel.Text != "") && (Convert.ToDouble(tenderedInput.Text) >= totalAmount))
                {
                    //if they have, enable change button
                    changeButton.Enabled = true;
                }
                else { changeButton.Enabled = false; }
            }
            catch { }

            //RECIPT BUTTON:
            //has the player has calculated their change (meaning they have gone through the whole process):
            if (changeOutputLabel.Text != "")
            {
                //if they have, they can calculate their recipt
                reciptButton.Enabled = true;
            }
            else reciptButton.Enabled = false;
        }

        //=NEW ORDER-------------------------------------------------------------------------------------------
        private void newOrderButton_Click(object sender, EventArgs e)
        {
            //play a sound
            click.Play();
            
            //reset everything
            orderNumber++;
            numTimsInput.Text = "";
            numBitsInput.Text = "";
            numHortsInput.Text = "";
            subTotalOutputLabel.Text = "";
            taxOutputLabel.Text = "";
            totalOutputLabel.Text = "";
            reciptOutputLabel.Text = "";
            tenderedInput.Text = "";
            changeOutputLabel.Text = "";
            
            //reset recipt height back to its original height, hopefully seamlessly!
            while (reciptOutputLabel.Height > originalReciptHeight) {
                reciptOutputLabel.Height -= 10;
                wait(3);
            };
            reciptOutputLabel.Height = originalReciptHeight;
        }

        //=ON START-------------------------------------------------------------------------------------------
        public Form1()
        {
            InitializeComponent();
            //generate a number and save it to the originalReciptHeight variable
            orderNumber = randomGen.Next(0,2000);
            originalReciptHeight = reciptOutputLabel.Height;
        }

        //=IS THERE AN ERROR-------------------------------------------------------------------------------------------
        private void error(bool thereIsAnError) 
        {
            switch(thereIsAnError)
            {
                case true:
                    reciptOutputLabel.Text = "ERROR";
                    break;
                case false:
                    reciptOutputLabel.Text = "";
                    break;
            }
        }

        //=WHAT DOES PLAYER OWE-------------------------------------------------------------------------------------------
        private void owedButton_Click(object sender, EventArgs e)
        {
            try
            {
                //play a sound
                slash.Play();

                //there has not been an error
                error(false);

                //define variables
                numOfTims = Convert.ToDouble(numTimsInput.Text);
                numOfBits = Convert.ToDouble(numBitsInput.Text);
                numOfHorts = Convert.ToDouble(numHortsInput.Text);

                //calculations
                subAmount = (numOfBits * priceOfBits) + (numOfTims * priceOfTims) + (numOfHorts * priceOfHorts);
                taxAmount = subAmount * taxRate;
                totalAmount = taxAmount + subAmount;

                //output
                subTotalOutputLabel.Text = subAmount.ToString("C");
                taxOutputLabel.Text = taxAmount.ToString("C");
                totalOutputLabel.Text = totalAmount.ToString("C");
            }
            catch { error(true);}   
        }

        //=WHAT IS PLAYER'S CHANGE-------------------------------------------------------------------------------------------
        private void changeButton_Click(object sender, EventArgs e)
        {
            try
            {
                //play a sound
                slash.Play();

                //there has not been an error
                error(false);
                
                //define variables
               tenderedAmount = Convert.ToDouble(tenderedInput.Text);

                //calculations
                changeAmount = tenderedAmount - totalAmount;

                //output
                changeOutputLabel.Text = changeAmount.ToString("C");
            }
            catch { error(true); }
        }

        //=PRINT RECIPT-------------------------------------------------------------------------------------------
        private void reciptButton_Click(object sender, EventArgs e)
        {
            {
                //Play a sound
                click.Play();
                
                //there has not been an error
                error(false);

                //generate a full copy of recipt
                string reciptFeild = 
                    $"_________|________|_________" +
                    $"~--------+|=RECIPT=|+--------" +
                    $"~____________________________" +
                    $"~" +
                    $"~Order Number {orderNumber}" +
                    $"~" +
                    $"~Tims  x {numOfTims}:{(priceOfTims*numOfTims).ToString("C")}" +
                    $"~Bits  x {numOfBits}:{(priceOfBits * numOfBits).ToString("C")}" +
                    $"~Horts x {numOfHorts}:{(priceOfHorts * numOfHorts).ToString("C")}" +
                    $"~" +
                    $"~Subtotal:{subAmount.ToString("C")}" +
                    $"~Tax Amount:{taxAmount.ToString("C")}" +
                    $"~Total Amount:{totalAmount.ToString("C")}" +
                    $"~" +
                    $"~Tendered:{tenderedAmount.ToString("C")}" +
                    $"~Change:{changeAmount.ToString("C")}" +
                    $"~~__   __   __ _"+
                    $"~||=_=||=_=||X|          =-_"+
                    $"~|[][][][][]|X| __ __ __|"+
                    $"~||________||//.__.__.__/\\"+
                    $"~||////THANK YOU_.__.__/XX\\"+
                    $"~||//HAVE A NICE DAY__/XXXX\\"+
                    $"~||++++++++++++++++++||XXXX||"+
                    $"~||[][][][][][][][][]||XXXX||";
                
                //a variable tracking how far a character is in a sentence, this will be used to line up all "$" signs to the same level, even if the number has multiple digits 
                int characterXPosition = 0;

                //slowly print the full copy of the recipt to the recipt label, one at a time for each variable in the string, I know this isnt realistic but I think it creates a cool animation!
                for (int i = 0; i <= reciptFeild.Length-1; i++)
                {
                    //if the recipt uses "~" do \n, the label wouldnt notice to put this in otherwise. At the same time increase the recipt height to fit, wait, reset the character position, and play a sound.
                    if (reciptFeild[i].ToString() == "~")
                    {
                        reciptOutputLabel.Height += 20;
                        click.Play();
                        characterXPosition = 0;
                        reciptOutputLabel.Text += "\n";
                        wait(200);
                    }
                    //":" means there will be a "$__.__", use dashes to align these up using the characterXPosition variable no matter if the number purchased is 1, 11, 111, 1111 etc; it will always have the right # of dashes
                    else if (reciptFeild[i].ToString() == ":")
                    {
                        reciptOutputLabel.Text += reciptFeild[i];
                        characterXPosition++;

                        while (characterXPosition < 17)
                        {
                            reciptOutputLabel.Text += "-";
                            characterXPosition++;
                        }
                    }
                    else 
                    {
                        //if not a special character, just print the character
                        reciptOutputLabel.Text += reciptFeild[i];
                        characterXPosition++;
                    }
                    //wait a SMALL amount of time before printing each character
                    wait(1);
                }

            }
        }
    }
}
