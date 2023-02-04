/***********************************************************************
*  File Name:
*     Figure
*
*  Author:
*     John Ellefson
*
*  Summary:
*     Creates the Figure class and the FigureType and Availability enumerations
*     to represent a HeroScape Figure
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroScape_Army_Randomizer
{
    enum FigureType {Common, Uncommon, Unique, None};
    enum Availability { Available, Taken, None };

    // The class that represents each Figure
    internal class Figure
    {
        string name;
        FigureType type;
        bool isHero;
        int points;
        Availability availability;


        // Default constructor for the Figure class
        public Figure() 
        { 
            name = "NULL";
            type = FigureType.None;
            isHero = true; 
            points = 0;
            availability = Availability.None;
        }


        // Non-default constructor for the Figure class
        public Figure(string name, FigureType type, bool isHero, int points)
        {
            this.name = name;
            this.type = type;
            this.points = points;
            this.isHero = isHero;
            availability = Availability.Available;
        }


        // Getters/Setters
        public string getName() { return name; }
        public FigureType getType() { return type; }
        public bool isHeroFig() { return isHero; }
        public int getPointCost() { return points; }
        public Availability getAvailability() { return availability; }
        public void setAvailability(Availability availability) { this.availability = availability; }
    }
}
