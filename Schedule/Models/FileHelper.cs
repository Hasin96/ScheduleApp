using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Schedule.Models
{
    static public class FileHelper
    {
        static public string GetSvgFromFile(string wwwRoot, string folderUrl, string fileName) 
        {
            var pathToSvgFile = System.IO.Path.Combine(folderUrl, fileName);
            var svgURL = System.IO.Path.Combine(wwwRoot, pathToSvgFile);

            return System.IO.File.ReadAllText(svgURL);
        }
    }
}
