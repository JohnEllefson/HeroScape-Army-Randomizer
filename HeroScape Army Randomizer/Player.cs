/***********************************************************************
*  File Name:
*     Player
*
*  Author:
*     John Ellefson
*
*  Summary:
*     Creates the Player class to represent each player and manage their army/points.
************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroScape_Army_Randomizer
{
    // The class that represents each player and manages their army and points
    internal class Player
    {
        string name = string.Empty;
        List<Figure> army;
        int pointsUsed;


        // Default constructor for the Player class
        public Player() 
        { 
            army = new List<Figure>();
            pointsUsed = 0;
        }


        // Non-default constructor for the Player class
        public Player(string name)
        {
            this.name = name;
            army = new List<Figure>();
            pointsUsed = 0;
        }


        // Getters/Setters
        public void setName(string name) { this.name = name; }
        public string getName() { return this.name; }
        public void setPointsUsed(int points) { this.pointsUsed = points; }
        public int getPointsUsed() { return this.pointsUsed; }
        public Figure getArmyFigure(int index) { return army[index]; }
        public void addFigureToArmy(Figure figure) { army.Add(figure); }
        public int getArmySize() { return army.Count; }
        public void clearArmy() { army.Clear(); }
    }
}
