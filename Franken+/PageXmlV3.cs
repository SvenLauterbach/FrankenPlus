using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Franken_
{
    class PageXmlV3 : PageXml
    {
        private bool useNewImageExtractor;

        public PageXmlV3(string xmlFile, bool useNewImageExtractor) : base(xmlFile)
        {
            this.useNewImageExtractor = useNewImageExtractor;
        }

        public override string ImageExtratorRelPath
        {
            //get { return "ExtractorExporter 1.2\\ExtractorExporter-1-2-50.exe"; }
            get
            {
                if (useNewImageExtractor)
                {
                    return "ImgExtractor\\ImageExtractor.exe";   
                }
                return "ExtractorExporter 1.2\\ExtractorExporter-1-2-50.exe";
            }
        }

        public override string CreateImageExtractorCommandLine(string inputImagePath, string xmlInputPath, string outputFolderPath)
        {
            string options = null; 

            if (useNewImageExtractor)
            {
                options = string.Format(@"-i ""{0}"" -x ""{1}"" -o ""{2}""", inputImagePath, xmlInputPath, outputFolderPath);    
            }
            else
            {
                options = string.Format(@"-extract imageSnippets -filter-by type -filter glyph -image ""{0}"" -page-content ""{1}"" -output-folder ""{2}"" -boxes", inputImagePath, xmlInputPath, outputFolderPath);  
            }
            return options;
        }
    }
}
