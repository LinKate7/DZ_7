using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Adapter
{
    interface IAirTransport
    {
        void Fly();
    }
    interface IParachute
    {
        void Landing();
    }
    class Plane : IAirTransport
    {
        public void Fly()
        {
            Console.WriteLine("The plane is flying");
        }
    }
    class MilitaryParachute : IParachute
    {
        public void Landing()
        {
            Console.WriteLine("The pilot landed very quickly");
        }
    }
    class Pilot
    {
        public void Flight(IAirTransport airTransport)
        {
            airTransport.Fly();
        }
    }
    class CrashTheAirTransport : IAirTransport
    {
        private IParachute parachute;
        public CrashTheAirTransport(IParachute parachute)
        {
            this.parachute = parachute;
        }
        public void Fly()
        {
            parachute.Landing();
        }
    }
}
