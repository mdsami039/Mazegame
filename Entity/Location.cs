///////////////////////////////////////////////////////////
//  Location.cs
//  Implementation of the Class Location
//  Generated by Enterprise Architect
//  Created on:      28-Apr-2014 10:13:37 PM
//  Original author: Gsimmons
///////////////////////////////////////////////////////////

using System;
using System.Collections;

namespace Mazegame.Entity
{
    public class Location
    {
        private Hashtable exits;
        private String description;
        private String label;

        public Location()
        {
        }

        public Location(String description, String label)
        {
            Description = description;
            Label = label;
            exits = new Hashtable();
        }

        public Boolean AddExit(String exitLabel, Exit theExit)
        {
            if (exits.ContainsKey(exitLabel))
                return false;
            exits.Add(exitLabel, theExit);
            return true;
        }

        public Exit GetExit(String exitLabel)
        {
            return (Exit)exits[exitLabel];
        }

        public String Description
        {
            get { return description; }
            set { description = value; }
        }

        public String Label
        {
            get { return label; }
            set { label = value; }
        }
    }
}