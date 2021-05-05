/*
 * Course: CSCI-473   Assignment :3    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 02/25/2021
 * 
 * Description:
 * This file contains the code for the main window that implements the form.
 * It contains 1 RichText box to output the results of the queries. It has 6 functions
 * which are to print out all class types from a single server, to print out percentage of each
 * race from a single player, to print out all role from a single server within a level range,
 * to print all guilds of a single type, to print all players who could fill a role but presently
 * arent, to print percentage of max level player in all guilds
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ErindSimeon_Assignment3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //for loop to populae the classComboBox with ClassType values
            foreach (ClassType val in Enum.GetValues(typeof(ClassType)))
            {
                classComboBox.Items.Add(val);
            }
            //Populae serverComboBox with their valeus
            serverComboBox1.Items.Add("Beta4Azeroth");
            serverComboBox1.Items.Add("TKWasASetback");
            serverComboBox1.Items.Add("ZappyBoi");
            serverComboBox2.Items.Add("Beta4Azeroth");
            serverComboBox2.Items.Add("TKWasASetback");
            serverComboBox2.Items.Add("ZappyBoi");
            serverComboBox3.Items.Add("Beta4Azeroth");
            serverComboBox3.Items.Add("TKWasASetback");
            serverComboBox3.Items.Add("ZappyBoi");
            //populae roleComboBox3 with item in ROle enum
            foreach (Role val in Enum.GetValues(typeof(Role)))
            {
                roleComboBox3.Items.Add(val);
            }
            //populae classComboBox4 with items in GuildType enum
            foreach (GuildType val in Enum.GetValues(typeof(GuildType)))
            {
                classComboBox4.Items.Add(val);   
            }
        }
        /*
         * ShowResult1(object sender, EventArgs e)
         * this function asks the user to pick a class from the combobox and the server and prints
         * all players that are from that class and server calling the overloaded method ToString to 
         * nicely format the output.
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void ShowResult1(object sender, EventArgs e)
        {
            OutputText.Clear(); // clear output text
            //check to see if the class combobox and the server combobox are selected
            if (classComboBox.SelectedIndex != -1 && serverComboBox1.SelectedIndex != -1)
            {   // querty that grabs all the players from the player dictionary where Players class is the same as the selected player
                // and players server is same as selected server, it orders the query by Level ascending
                var PlayersFromServer =
                      from p in globals.player
                      where (Convert.ToInt32(p.Value.ClassType)  == classComboBox.SelectedIndex) &&
                      globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox1.SelectedItem)
                      orderby p.Value.Level ascending
                      select p
                      ;
                OutputText.Text += "All Warrior from " + serverComboBox1.SelectedItem + "\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
                //for loop that iterates through the PlayersFromSserver query and calls ToString to format the output
                foreach (var p in PlayersFromServer)
                {
                    OutputText.Text += p.Value.ToString();
                }
                //if the count of query is 0 then we print NO RESULT on teh outputText field
                if(PlayersFromServer.Count() == 0)
                {
                    OutputText.Text += "NO RESULTS\n";
                }

                OutputText.Text += "\nEND RESULTS\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";

            }//if no class and no server is selected show the message below
            else
            {
                OutputText.Text += "Please select a ClassType and Server name in order for this query to work!";
            }
        }
        /*
         * private void ShowResult2(object sender, EventArgs e)
         * this function lets the user pick a server and shows the percentage of each race from the selected server
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void ShowResult2(object sender, EventArgs e)
        {
            OutputText.Clear(); // clear output text
            //check to see if serverComboBox is selected
            if ( serverComboBox2.SelectedIndex != -1)
            {
                double countOrc=0; // variables to hold the percentege of orcs
                double countTroll = 0; // variable to hodls the percentage of Trollls
                double count_Tauren = 0; //variable to hold the percentage of Taurens
                double count_Forsaken = 0; //variable to hold the percentage of Forsaken
                //query to select all players that are on a server
                var PlayersFromServer = (
                      from p in globals.player
                      where globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox2.SelectedItem)
                      select p).Count();
                //query to select all orcs that are on a server
               var  OrcsFromServer =
                    (from p in globals.player
                    where globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox2.SelectedItem)
                     && p.Value.Race == (Race) 0 
                    select p).Count() ;
                //query that select all Trolls from the selected server
                var TrollsFromServer =
                    (from p in globals.player
                    where globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox2.SelectedItem)
                    && p.Value.Race == (Race) 1
                    select p).Count();
                //query that select all Taurens from the selected server
                var TaurensFromServer =
                    (from p in globals.player
                    where globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox2.SelectedItem)
                    && p.Value.Race == (Race) 2
                    select p).Count();
                //query that selects all Forsaken from the selected server
                var ForsakensFromServer =
                    (from p in globals.player
                    where globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox2.SelectedItem)
                    && p.Value.Race == (Race) 3
                    select p).Count();
                countOrc = ((double)OrcsFromServer/(double) PlayersFromServer); // calculate the percentage of Orcs
                countTroll=((double) TrollsFromServer / (double)PlayersFromServer) ; // calculate the percentage of Trolls
                count_Tauren=((double)TaurensFromServer / (double)PlayersFromServer) ; //Calculate the percentage of Tauren
                count_Forsaken = ((double)ForsakensFromServer / (double)PlayersFromServer); //calculate the percentage of Forsaken
                OutputText.Text += "Percentage of Each Race from  " + serverComboBox2.SelectedItem + "\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
                // if there are orcs on the server then print their percentage
                if (OrcsFromServer != 0)
                {
                    OutputText.Text += string.Format("{0,-20}\t\t{1:P2}","Orc:",countOrc) +"\n";
                }
                // if there are trolls on the server then print their percentage
                if ( TrollsFromServer != 0)
                {
                    OutputText.Text += string.Format("{0,-20}\t\t{1:P2}", "Troll:", countTroll) + "\n";
                }
                // if there are Tauren on the server then print their percentage
                if (TaurensFromServer != 0)
                {
                    OutputText.Text += string.Format("{0,-20}\t\t{1:P2}", "Tauren:", count_Tauren) + "\n";
                }
                // if there are Forsaken on the server then print their percentage
                if (ForsakensFromServer != 0)
                {
                    OutputText.Text += string.Format("{0,-20}\t\t{1:P2}", "Forsaken:", count_Forsaken) + "\n";
                }
                //if server is empty then print out no results
                if (OrcsFromServer == 0 && TrollsFromServer == 0 && TaurensFromServer == 0 && ForsakensFromServer == 0)
                {
                    OutputText.Text += "\nNO RESULTS\n";
                }
                OutputText.Text += "\nEND RESULTS\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
            }
            //if Server name isnt selected print the message below
            else
            {
                OutputText.Text += "Please select a Server name in order for this query to work!";
            }
        }
        /*
         * InstantiateMyNumericUpDown()
         * this function initiliazes the numericUpDown to 1 and max to MAX_LEVEL
         * params:none
         * return:none
         */
        public void InstantiateMyNumericUpDown()
        {
            // Create and initialize a NumericUpDown control.
            numericUpDownMin = new NumericUpDown();
            // Dock the control to the top of the form.
            numericUpDownMin.Dock = System.Windows.Forms.DockStyle.Top;
            //set the minimum maximum and initial value
            numericUpDownMin.Value = 1;
            numericUpDownMin.Minimum = 1;
            numericUpDownMin.Maximum = globals.MAX_LEVEL;
            // Add the NumericUpDown to the Form.
            Controls.Add(numericUpDownMin);
        }
        /*
         * NumericMinClicked(object sender, EventArgs e)
         * function is to increment the max where min is incremented so max wont be smaller than min
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void NumericMinClicked(object sender, EventArgs e)
        {
            if(numericUpDownMin.Value != 1)
            {
                numericUpDownMax.Value = numericUpDownMin.Value;
            }
        }
        /*
         * NumericMaxClicked(object sender, EventArgs e)
         * decrement the min if max becoems smaller than min
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void NumericMaxClicked(object sender, EventArgs e)
        {
            if (numericUpDownMax.Value != 1 && numericUpDownMax.Value< numericUpDownMin.Value)
            {
                numericUpDownMin.Value = numericUpDownMax.Value;
            }

        }
        /*
         * ShowResult3(object sender, EventArgs e)
         * this function asks the user to pick a role and server from combo box and pick a minimum and max level
         * from the numericupdown and shows all the players that are between the selected min and max level and they aare
         * of that Rol and from the selected server
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void ShowResult3(object sender, EventArgs e)
        {
            OutputText.Clear(); // clear output text
            //check if the Role combobox and serverCobmboBox is selected
            if (roleComboBox3.SelectedIndex != -1 && serverComboBox3.SelectedIndex != -1)
            {
                //query to grab all players where the selected Role and Selected server match also they are
                //between the minimum and maximum level
                var PlayersFromServer =
                      from p in globals.player
                      where (Convert.ToInt32(p.Value.Role) == roleComboBox3.SelectedIndex) &&
                      globals.map[p.Value.GuildID].Server == Convert.ToString(serverComboBox3.SelectedItem) &&
                      p.Value.Level >= numericUpDownMin.Value && p.Value.Level<= numericUpDownMax.Value
                      orderby p.Value.Level , p.Value.Name
                      select p
                      ;
                OutputText.Text += "All" +roleComboBox3.SelectedItem + " from ["+serverComboBox3.SelectedItem+"], Levels " + numericUpDownMin.Value + " to " +numericUpDownMax.Value +  "\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
                //for loop that iterates throu playerfromServer query and calls TOString to format them nicely
                foreach (var p in PlayersFromServer)
                {
                    OutputText.Text += p.Value.ToString();
                }
                // if there are no rows on the playerfromServer query then show NO RESULTS
                if (PlayersFromServer.Count() == 0)
                {
                    OutputText.Text += "NO RESULTS\n";
                }
                OutputText.Text += "\nEND RESULTS\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
            }
            //if classType and ServerName are not selected print the message below
            else
            {
                OutputText.Text += "Please select a Role and Server name in order for this query to work!";
            }
        }
        /*
         * ShowResult4(object sender, EventArgs e)
         * this function shows all guild of a single type and prints out the server name and the guilds that that server has
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void ShowResult4(object sender, EventArgs e)
        {
            OutputText.Clear(); // clear output text
            //check to see if Type is selected
            if (classComboBox4.SelectedIndex != -1)
            {
                //query to select all players that are on a server and groups them by server 
                var TypeOfGuild =
                      from g in globals.map
                      where Convert.ToUInt32(g.Value.GuildType) == classComboBox4.SelectedIndex
                      orderby g.Value.Server descending
                      group g by g.Value.Server into guild
                      select guild;
                OutputText.Text += "All "+ classComboBox4.SelectedItem+"-Type of Guilds" + "\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
                //for loop that iterates throug typeofguild query and the outer loop prints the server name
                foreach (var guild in TypeOfGuild)
                {
                    OutputText.Text +=  guild.Key + "\n";
                    //for loop that prints out the guilds that are on the server
                    foreach (var item in guild)
                    {
                        OutputText.Text += "\t<"+ item.Value.Name + ">" + "\n";
                    }
                }
                //if the query typeofGuild has no rows print NO RESULTS
                if(TypeOfGuild.Count() == 0)
                {
                    OutputText.Text += "NO RESULTS\n";
                }
                OutputText.Text += "\nEND RESULTS\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
            }
            //if that guild type isnt selected print the message below
            else
            {
                OutputText.Text += "Please select a Guild Type in order for this query to work!";
            }
        }
        /*
         * ShowResult5(object sender, EventArgs e)
         * this fuction asks the user to pick a role from the radio button and will show all player who could filla a Role but presently Aren't
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void ShowResult5(object sender, EventArgs e)
        {
            OutputText.Clear(); // clear output text
            //check to see if a Role is checked
            if (Tank.Checked || Healer.Checked || Damage.Checked)
            {   //query to grab all the players and orders them by level and name
                var AllPlayers =
                  from p in globals.player
                  orderby p.Value.Level,p.Value.Name
                  select p ;
                //query to grab all players of Role Tank
                var TankRole =
                      from p in globals.player
                      where p.Value.Role == (Role) 0
                      select p;
                //query to grab all players of Role Healer
                var HealerRole =
                      from p in globals.player
                      where p.Value.Role == (Role)1
                      select p;
                //query to grab all players of Role Damage
                var DamageRole =
                      from p in globals.player
                      where p.Value.Role == (Role)2
                      select p;
                OutputText.Text += "All Eligible Players Not Fulfulling the ";
                //if tanks is chekced print tank
                if (Tank.Checked)
                {
                    OutputText.Text += "Tank Role\n";
                } // if healer is checked print healer
                if (Healer.Checked)
                {
                    OutputText.Text += "Healer Role\n";
                } // if damage is checkeed print damage
                if (Damage.Checked)
                {
                    OutputText.Text += "Damage Role\n";
                }
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
                //for loop that iterates through all players from allPlayers query
                foreach (var p in AllPlayers)
                {
                    //if the selected radibutton is Tank and tankRolequery doesnt contain the player and the classType is either Warrior or Druid or Palading
                    if (Tank.Checked && !TankRole.Contains(p) && (p.Value.ClassType == (ClassType) 0 || p.Value.ClassType== (ClassType) 2 || p.Value.ClassType == (ClassType) 6))
                    {
                            OutputText.Text += p.Value.ToString() + "\n";
                    }
                    //if the selected radibutton is Healer and healer role query  doesnt contain the player and the classType is either  Druid or Priest or Palading or Shaman
                    else if (Healer.Checked && !HealerRole.Contains(p) && (p.Value.ClassType == (ClassType)2 || p.Value.ClassType == (ClassType) 3 || p.Value.ClassType == (ClassType)6
                             || p.Value.ClassType == (ClassType) 8))
                    {
                        OutputText.Text += p.Value.ToString() + "\n";
                    }
                    //if the selected radibutton is Damage and damagerole query  doesnt contain the player and the classType is either  Warrior or Druid or Priest or Palading or paladin  or Shaman
                    else if (Damage.Checked && !DamageRole.Contains(p) && (p.Value.ClassType == (ClassType) 0 || p.Value.ClassType == (ClassType) 2 || p.Value.ClassType == (ClassType) 3
                             || p.Value.ClassType == (ClassType) 6 || p.Value.ClassType == (ClassType) 8 ))
                    {
                        OutputText.Text += p.Value.ToString() + "\n";
                    }
                }
                OutputText.Text += "\nEND RESULTS\n";
                OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
            }// if the radiobutton issnt selected show the message below
            else
            {
                OutputText.Text += "Please select a Role in order for this query to work!";
            }
        }
        /*
         * ShowResult6(object sender, EventArgs e)
         * this function show the percentage of max levels player in all guilds
         * params: Sender: Reference to the object that called this function,
         *         EventArgs: The arguments passed from the calling object
         * return: none
         */
        private void ShowResult6(object sender, EventArgs e)
        {
            OutputText.Clear(); // clear output text
            double percent; //variable to hold the percentage
            //query to select all guilds
            var AllGuilds = 
                from g in globals.map
                select g;
            OutputText.Text += "Percentage of Max Level Players in All Guilds " + "\n";
            OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
            //loop that iterates through all guilds
            foreach (var g in AllGuilds)
            {
                //query that selects all players in guild
                var allPlayersInGuild =
                    from p in globals.player
                    where p.Value.GuildID == g.Value.Id
                    select p;
                //query that selects all maxPlayers in a guild
                var allMaxPlayers =
                    from p in globals.player
                    where p.Value.Level == 60 && p.Value.GuildID == g.Value.Id
                    select p;
                //calcualte the percentage of max_players in a guild
                percent = ((double)allMaxPlayers.Count() / (double)allPlayersInGuild.Count());
                //if the number of max_players in guild isnt 0 then show the percentage
                if (allPlayersInGuild.Count() != 0)
                {
                    //  OutputText.Text += "<"+g.Value.Name+">".PadRight(30)  + string.Format("{0,6:F2}",percent)+" %"  + "\n";
                    OutputText.AppendText ( string.Format("\n{0,-30}\t{1,10:P2}\n", ("<"+g.Value.Name+">"), percent));
                }
            }
            OutputText.Text += "\nEND RESULTS\n";
            OutputText.Text += "--------------------------------------------------------------------------------------------------\n";
        }
    }
}
