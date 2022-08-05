using SegunWire.Assignment0003;

namespace SegunWire
{
    internal class Program
    {
        class Teacher : Result
        {
            public override string Test => throw new NotImplementedException();

            public override string Examination => throw new NotImplementedException();

            public override string MentalObservation(string mentalHealth)
            {
                throw new NotImplementedException();
            }

            public override void Res()
            {
                Console.WriteLine("You passed");
            }


        }
        class School : ISchool
        {
            public int StudentNum { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string StudentNextofKin { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public string StudentBioData { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public int PaymnetDebt()
            {
                throw new NotImplementedException();
            }
     
        }
        static void Main(string[] args)
        {
           Teacher teacher=new Teacher();   
            teacher.Res();
        }
    }
}
