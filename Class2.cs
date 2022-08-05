using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SegunWire
{
    public abstract class Result
    {
        public abstract string Test { get; }
        public abstract string Examination { get; }

        public abstract void Res();

        public void ViralResult()
        {
            Console.WriteLine("Anti-Virus should be recommended");
        }
        public void BacterialResult()
        {
            Console.WriteLine("Anti-Bacterial should be recommended");
        }
        public void Infection()
        {
            Console.WriteLine("Contact Expert for further actions");
        }
        public void OtherPhysicalCondition()
        {
            Console.WriteLine("Patient should go for Xray");
        }

        public abstract string MentalObservation(string mentalHealth);

    }
}
