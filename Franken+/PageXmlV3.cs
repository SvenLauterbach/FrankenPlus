using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franken_
{
    class PageXmlV3 : PageXml
    {
        public PageXmlV3(string xmlFile) : base(xmlFile)
        {
        }

        public override string ImageExtratorRelPath
        {
            //get { return "ExtractorExporter 1.2\\ExtractorExporter-1-2-50.exe"; }
            get { return "ImgExtractor\\ImageExtractor.exe"; }
        }

        public override string CreateImageExtractorCommandLine(string inputImagePath, string xmlInputPath, string outputFolderPath)
        {
            string options = string.Format(@"-i ""{0}"" -x ""{1}"" -o ""{2}""", inputImagePath, xmlInputPath, outputFolderPath);
            //string options = string.Format(@"-extract imageSnippets -filter-by type -filter glyph -image ""{0}"" -page-content ""{1}"" -output-folder ""{2}"" -boxes", inputImagePath, xmlInputPath, outputFolderPath);

            return options;
        }
    }
}
