using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrbanPlanner.Planner
{
    class Building
    {
        // overloading in c sharp is when you have the same name on multiple methouds but each on has it's own signature(paramaters) ex of signature = Building(string address)
        // constructors
        public Building()
        {

        }
        public Building(string address)
        {
            _address = address;
        }


        //fields
        private string _designer = "Klay T";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;


        // properties
        public int Stories { get; set; }
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get => Width * Depth * (3 * Stories);
        }

        // methods
        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchased(string name)
        {
            _owner = name;
        }
        public void PrintToConsole()
        {
            // @ - string verbatim - will take every keystroke literally including new lines (Enter key)
            string output = $@"
{_address}--------------
Designed by {_designer}
Constructed on {_dateConstructed}
Owned by {_owner}
{Volume} cubic meters of space";
            Console.WriteLine(output);
        }
    }
}


/*public Building()
{
    _address = "123 Address Ave";
}

public Construct()
{
    _dateConstructed = DateTime.Now;
}

public Purchase()
{
    _owner = "Daryl";
}

private string _designer;

private DateTime _dateConstructed;

private string _address;

private string _owner;

public int Stories { get; set; }
public double Width { get; set; }
public double Depth { get; set; }
private double bVolume = double.Empty;
public double Volume
{
    get
    {
        bVolume = Math
    }
}*/
