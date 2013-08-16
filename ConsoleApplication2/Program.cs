using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("meta file test.txt");
            string assocFile, siteName, owner, gpsLat, gpsLong, gpsGrid, elev, conName, conOrg, conPhone, conEmail, numSensors;
            int iss;

            assocFile = reader.ReadLine();
            siteName = reader.ReadLine();
            owner = reader.ReadLine();
            gpsLat = reader.ReadLine();
            gpsLong = reader.ReadLine();
            gpsGrid = reader.ReadLine();
            elev = reader.ReadLine();
            reader.ReadLine();
            conName = reader.ReadLine();
            conOrg = reader.ReadLine();
            conPhone = reader.ReadLine();
            conEmail = reader.ReadLine();
            numSensors = reader.ReadLine();


            System.Console.WriteLine(CleanMetaIn(assocFile,17));
            System.Console.WriteLine(CleanMetaIn(siteName, 11));
            System.Console.WriteLine(CleanMetaIn(owner, 7));
            System.Console.WriteLine(CleanMetaIn(gpsLat, 19));
            System.Console.WriteLine(CleanMetaIn(gpsLong, 19));
            System.Console.WriteLine(CleanMetaIn(gpsGrid, 17));
            System.Console.WriteLine(CleanMetaIn(elev, 11));
            System.Console.WriteLine(CleanMetaIn(conName, 6));
            System.Console.WriteLine(CleanMetaIn(conOrg, 14));
            System.Console.WriteLine(CleanMetaIn(conPhone, 7));
            System.Console.WriteLine(CleanMetaIn(conEmail, 7));
            System.Console.WriteLine(CleanMetaIn(numSensors, 19));
            Console.ReadLine();
        }


        static string CleanMetaIn(string raw, int toRemove)
        {
            string clean;
            clean = raw.Substring(toRemove);
            return clean;
        }

    }
}
