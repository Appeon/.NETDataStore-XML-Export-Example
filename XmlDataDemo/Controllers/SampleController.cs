using Microsoft.AspNetCore.Mvc;

namespace XmlDataExportDemo
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class SampleController : ControllerBase
    {
        private readonly ISampleService _sampleService;
        public SampleController(ISampleService sampleService)
        {
            _sampleService = sampleService;
        }

        //Import XML data of standard or simlple format, no template used
        // Post api/sample/ImportXml
        [HttpPost]
        public int ImportXml([FromBody] string xml)
            => _sampleService.ImportXml(xml);


        //Export to XML in standard format, no template used
        //Get api/sample/ExportXml
        [HttpGet]
        public string ExportXml()
            => _sampleService.ExportXml();

        //Export to XML in simple format, no template used
        //Get api/sample/ExportPlainXml
        [HttpGet]
        public string ExportPlainXml()
            => _sampleService.ExportPlainXml();


        //Export to XML using a template
        //Get api/sample/Normal
        [HttpGet]
        public string Normal()
            => _sampleService.ExportXmlByTemplate1();


        //Export to XML using a template which has defined groupby
        //Get api/sample/Group
        [HttpGet]
        public string Group()
            => _sampleService.ExportXmlByTemplate2();


        //Export to XML using a template which has defined sortby
        //Get api/sample/Sort
        [HttpGet]
        public string Sort()
            => _sampleService.ExportXmlByTemplate3();


        //Export to XML using a template from a composite DataWindow
        //Get api/sample/Composite
        [HttpGet]
        public string Composite()
            => _sampleService.ExportXmlByTemplate4();


        //Export to XML using a user-defined template
        //Get api/sample/ExportXmlByTemplate2
        [HttpPost]
        public string ExportByTemplate([FromBody] string template)
            => _sampleService.ExportXmlByTemplate(template);


        //Export JSON to XML using a user-defined template
        //If no user-defined template exists, use a JSON template
        //Get api/sample/ExportJson
        [HttpPost]
        public string ExportJson([FromBody] string template)
            => _sampleService.ExportJsonByTemplate(template);

    }
}
