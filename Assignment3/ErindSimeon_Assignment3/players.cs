/*
 * Course: CSCI-473   Assignment :2    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 02/25/2021
 * 
 * Description:
 * This file contains the player class. With all getters and setters for 
 * the private data types. It implements the iComperable interface to sort
 * by name. 
 * Overloads ToString() to print the output nicely
 */

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
namespace ErindSimeon_Assignment3
{
    /*
  * enum Race Type which hold the races for the players
  */
    public enum Race { Orc, Troll, Tauren, Forsaken };
    /*
     * enum ClassType which holds ClassType Items
     */
    public enum ClassType
    {
        Warrior, Mage, Druid, Priest,
        Warlock, Rogue, Paladin, Hunter, Shaman
    }
    /*
     * enum Role to hold the roles for a player
     */
    public enum Role { Tank, Healer, Damage };
    public class Player : IComparable
    {
        //global variables 
        private static uint MAX_LEVEL = 60;
        //private attributes
        private readonly uint id;
        private readonly string name;
        private readonly Race race;
        private readonly ClassType classType;
        private readonly Role role;
        private uint level;
        private uint exp;
        private uint guildID;

        /*
         * Constructor Player
         * Default constructor for Player
         * parameters none
         */
        public Player()
        {
            id = 0;
            name = "";
            race = 0;
            classType = 0;
            role = 0;
            level = 0;
            exp = 0;
            guildID = 0;

        }
        /* constructor that takes a number of arguments
         * params: an array of arguments
         */
        public Player(string[] args)
        {
            id = Convert.ToUInt32(args[0]);
            name = args[1];
            race = (Race)Convert.ToUInt32(args[2]);
            classType = (ClassType)Convert.ToUInt32(args[3]);
            role = (Role)Convert.ToUInt32(args[4]);
            level = Convert.ToUInt32(args[5]);
            exp = Convert.ToUInt32(args[6]);
            guildID = Convert.ToUInt32(args[7]);
        }
        /*
         * Alternative constructor
         * params: uint id, string name, Race race,  classType classType, ROle role , uint level, uint exp, uint guildID
         */
        public Player(uint id, string name, Race race, ClassType classType,Role role, uint level, uint exp,  uint guildID)
        {
            this.id = id;
            this.name = name;
            this.race = race;
            this.classType = classType;
            this.role = role;
            this.level = level;
            this.exp = exp;
            this.guildID = guildID;
        }
        // id has only read access
        public uint Id
        {
            get { return id; }
        }
        // name -- only R access
        public string Name
        {
            get { return name; }
        }
        // race -- only R access
        public Race Race
        {
            get { return race; }
        }
        // ClassType containing only read access
        public ClassType ClassType
        {
            get { return classType; }
        }
        public Role Role
        {
            get { return role; }
        }

        //level -- free R/W access, range is [0, MAX_LEVEL].
        public uint Level
        {
            get { return level; }
            set
            {
                // if the value is less than 0 or bigger then max_level reutrn
                if (value < 0 || value > MAX_LEVEL)
                {
                    return;
                }
                Console.WriteLine("Ding!");
                level = value;

            }
        }
        //exp -- normal R access, but the W access should instead increment the value of exp by... value. 
        //If this should make the exp value exceed the required experience for this player to increase their level (but not exceed MAX_LEVEL), it should do as such.
        public uint Exp
        {
            get { return exp; }
            set
            {
                exp += value;
                //loop to increment the level based on the entered exp value
                while (exp > (1000 * Level))
                {
                    Level++;
                    if (exp < (1000 * Level))
                    {
                        break;
                    }
                    exp = exp - ((1000 * Level));
                }
            }
        }

        // guildID -- free R/W access
        public uint GuildID
        {
            get { return guildID; }
            set { guildID = value; }
        }

        /*
        * Function : CompareTo sorts by name
        * Comares player object by name
        * it return -1 , 0 or 1 based on the result of condition (-1 if its< . 0 if == and 1 if
        * params: object alpha
        * return -1 || 0 || -1
        * 
        */

        public int CompareTo(object alpha)
        {
            if (alpha == null)
                throw new ArgumentNullException();

            Player rightOp = alpha as Player;

            if (rightOp != null)
            {
                if (name.CompareTo(rightOp.name) == 0)
                {
                    return level.CompareTo(rightOp.level);
                }
                else
                    return name.CompareTo(rightOp.name);
            }
            else
                throw new ArgumentException();
        }

        /*
         * Function: TOString, overrride  It prints Name: Race: Level: Guild
         * ex: Name: Beauregard          	(Warrior         - Tank           )  Race: Tauren      Level:46          <Roll For Initiative >
         * Formats the output
         * Parametrs: none
         * return: the formated string
         */

        public override string ToString()
        {
            StringBuilder result = new StringBuilder(String.Format("Name: {0}\t({1} - {2})\tRace: {3,-10}\tLevel:{4}\t<{5}>\n", Name.Trim().PadRight(15), ClassType, Role, Race, Level.ToString(), globals.map[GuildID].Name));
            return result.ToString();
        }

    }
}