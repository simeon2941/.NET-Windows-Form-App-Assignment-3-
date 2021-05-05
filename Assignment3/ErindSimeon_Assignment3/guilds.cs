
/*
 * Course: CSCI-473   Assignment :3    Spring 2021
 * 
 * Erind Hysa   zid: z1879691
 * Simeon Lico  zid: z1885981
 * 
 * Due Date : 02/25/2021
 * 
 * Description:
 * This file contains the guilds class. With all getters and setters for 
 * the private data types. It implements the iComperable interface to sort
 * by server. )
 * Overloads ToString() to print the output nicely
 */
using System;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;
using System.Linq;
using System.Text;

namespace ErindSimeon_Assignment3
{
    /*
     * enum GuildType which holds guilds Types
     */
    public enum GuildType
    {
        Casual, Questing, Mythic,
        Raiding, PVP
    }
    public class Guilds : IComparable
    {

        //lsit of the private variables
        private readonly uint id;
        private readonly GuildType guildType;
        private readonly string name;
        private readonly string server;

        /*
        * default constructor setting all the variables to 0 and ""
        */
        public Guilds()
        {
            id = 0;
            guildType = 0;
            name = "";
            server = "";
        }
        /*
         * alternative constructor setting the values to the provided value
         */
        public Guilds(uint id, GuildType guildType ,string name, string server)
        {
            this.id = id;
            this.guildType = guildType;
            this.name = name;
            this.server = server;
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
        public string Server
        {
            get { return server; }
        }
        //guild type only r access
        public GuildType GuildType
        {
            get { return guildType; }
        }

        /*
        * Function : CompareTo sorts by serverName
        * Comares guilds objects by server name
        * it return -1 , 0 or 1 based on the result of condition (-1 if its< . 0 if == and 1 if
        * params: object alpha
        * return -1 || 0 || -1
        * 
        */
        public int CompareTo(object alpha)
        {
            if (alpha == null) // No good
                throw new ArgumentNullException();

            Guilds rightOp = alpha as Guilds;

            if (rightOp != null)
            {
                //return FullName.CompareTo(rightOp.FullName);

                if (name.CompareTo(rightOp.name) == 0)
                {
                    return server.CompareTo(rightOp.server);
                }
                else
                    return name.CompareTo(rightOp.name);

            }
            else
                throw new ArgumentException();
        }
        /*
* Function: TOString, overrride  It prints ID,guildType, Name and Server
* ex: 12321 0 Death And Taxes ZappyBoi
* Formats the output
* Parametrs: none
* return: the formated string
*/
        public override string ToString()
        {
            StringBuilder result = new StringBuilder(String.Format("{0,-30}\t[{1} \t {2} \t{3}]", Id,GuildType, Name,Server));
            return result.ToString();
        }


    }
}
