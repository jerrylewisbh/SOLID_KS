using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace Project
{
    public class Board
    {
        private List<Property> properties = new List<Property>();

        public Board()
        {
            var directoryInfo = Directory.GetParent(Directory.GetCurrentDirectory()).Parent;
            string[] lines = System.IO.File.ReadAllLines(directoryInfo + "/gameConfig.txt");

            foreach (string line in lines)
            {
                //replace multiple spaces with single space
                string formmatedLine = Regex.Replace(line, @"\s+", " ");
                string[] settings = formmatedLine.Split(' ');

                Property p = new House(int.Parse(settings[0]), int.Parse(settings[1]));
                properties.Add(p);
            }

        }
    }
}