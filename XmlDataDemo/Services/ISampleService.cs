using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DWNet.Data;
using SnapObjects.Data;

namespace XmlDataDemo
{
    public interface ISampleService
    {
        int ImportXml(string xml);
        
        string ExportXml();
        string ExportPlainXml();
        string ExportXmlByTemplate1();
        string ExportXmlByTemplate2();
        string ExportXmlByTemplate3();
        string ExportXmlByTemplate4();
        string ExportXmlByTemplate(string template);
        string ExportJsonByTemplate(string tempalte);
    }
}