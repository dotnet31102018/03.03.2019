using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _0303HW
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp tzehelim1 = new Camp(800, 400, 1500, 100, 20);
            Camp zikim1 = new Camp(100, -2, 900, 1200, 2000);

            Camp joined = tzehelim1 + zikim1;
            Console.WriteLine($"joines = {joined}");
            Console.WriteLine($"tzehelim > zikim {tzehelim1 > zikim1}");
            Console.WriteLine($"tzehelim < zikim {tzehelim1 < zikim1}");
            Console.WriteLine(tzehelim1 == zikim1);

            if (tzehelim1 > zikim1)
                Console.WriteLine("Tzehelim is bigger");

            Console.WriteLine("===========================================");
            Console.WriteLine("Etgdar");

            CampSer tzehelim = new CampSer(800, 400, 1500, 100, 20);
            CampSer zikim = new CampSer(100, -2, 900, 1200, 2000);

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(CampSer));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Create)) // creating new file stream
            {
                myXmlSerializer.Serialize(file, tzehelim);

            } //closing file stream

            CampSer readCampOne = null;
            CampSer readCampTwo = null;
            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                readCampOne = myXmlSerializer.Deserialize(file) as CampSer;

            } //closing file stream
            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                readCampTwo = myXmlSerializer.Deserialize(file) as CampSer;
            }

            Console.WriteLine(readCampOne.GetHashCode() == readCampTwo.GetHashCode());
            

        }
        }
}
