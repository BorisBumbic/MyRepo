using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Bilar.Methods
{
    public class Bilberäkning
    {
        public List<string> ManipulateTextFile(int i)
        {
            string file = null;

            if (i == 1)
                file = "TextFile1.txt";
            else if (i == 2)
                file = "TextFile2.txt";

            string path = $"C:/SOurceTreeTMP/Bilar/Bilar/Files/{file}";

            string readFile = File.ReadAllText(path, Encoding.UTF8);

            return readFile.Split(";").ToList();
        }

        //public List<string> ManipulateDataFromWebPage()
        //{

        //}

        public string Beräkning(List<string> tempList)
        {
            double multiplicator = 1;

            double tempWeight = double.Parse(tempList[1]);
            double tempTime = double.Parse(tempList[2]);

            if (tempList[0] == "lastbil")
                multiplicator *= 2;

            if (tempWeight > 1500)
                multiplicator *= 1.5;

            if (tempTime > 7 && tempTime < 19)
                multiplicator *= 1.2;

            double finalPrice = 10 * multiplicator;

            return $"En {tempList[0]} passerade tullen kl {tempList[2]}. Priset blev {finalPrice}";
        }
    }
}
