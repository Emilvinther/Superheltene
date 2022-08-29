using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheltene
{
    internal class Superhero
    {
        private string secretidentity;
        private string power;
        private string costume;
        private bool moralcode;
        private byte nemisis;
        private string lair;


        // Identity property
        public string Secretidentity
        {
            get { return secretidentity; }
            set { secretidentity = value; }
        }
        // power property
        public string Power
        {
            get { return power; }
            set { power = value; }
        }

        // moral code property
        public bool Moralcode
        {
            get { return moralcode; }
            set { moralcode = value; }
        }
        // costume property
        public string Costume
        {
            get { return costume; }
            set { costume = value; }
        }
        // nemisis property
        public byte Nemisis
        {
            get { return nemisis; }
            set { nemisis = value; }
        }
        // lair property
        public string Lair
        {
            get { return lair; }
            set { lair = value; }
        }


        // flying method
        public void Flying()
        {
            Console.WriteLine("Flying!!!!");
        }
        // power usage method
        public void UserPower()
        {
            Console.WriteLine("Uses superpower!!!!");
        }
    }
}
