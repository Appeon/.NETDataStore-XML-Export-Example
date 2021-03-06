using DWNet.Data;
using SnapObjects.Data;
using System;
using System.IO;

namespace XmlDataExportDemo
{
    /// <summary>
    /// DataWindow is initialized with data, so no need to retrieve into DataStore
    /// </summary>
    public class SampleService : ISampleService
    {
        private readonly SampleDataContext _dataContext;

        public SampleService(SampleDataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public int ImportXml(string xml)
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            return dataStore.ImportXml(xml);
        }

        public string ExportXml()
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            return dataStore.ExportXml(MappingMethod.ColumnIndex);
        }

        public string ExportPlainXml()
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            return dataStore.ExportPlainXml();
        }

        public string ExportXmlByTemplate1()
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            var template = dataStore.GetTemplate();

            var data = DwTemplateExporter.Export(dataStore, template);

            return data;
        }

        public string ExportXmlByTemplate2()
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            var tempalte = dataStore.GetTemplate("group");

            var data = DwTemplateExporter.Export(dataStore, tempalte);

            return data;
        }

        public string ExportXmlByTemplate3()
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            var template = dataStore.GetTemplate("sort");

            var data = DwTemplateExporter.Export(dataStore, template);

            return data;
        }

        public string ExportXmlByTemplate4()
        {
            var dataStore = new DataStore("d_composite", _dataContext);

            var template = dataStore.GetTemplate();

            var data = DwTemplateExporter.Export(dataStore, template);

            return data;
        }

        public string ExportXmlByTemplate(string template)
        {
            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            var dataTemplate = new DataTemplate();

            dataTemplate.LoadContent(template);

            var data = DwTemplateExporter.Export(dataStore, dataTemplate);

            return data;
        }

        public string ExportJsonByTemplate(string template)
        {
            var filePath = AppContext.BaseDirectory
                + "datawindows/department.pbt/department.pbl/d_sq_gr_department.tpl.normal.json";

            if (string.IsNullOrWhiteSpace(template) && File.Exists(filePath))
            {
                template = File.ReadAllText(filePath);
            }

            var dataStore = new DataStore("d_sq_gr_department", _dataContext);

            var dataTemplate = new DataTemplate();

            dataTemplate.LoadContent(template);

            var data = DwTemplateExporter.Export(dataStore, dataTemplate);

            return data;
        }
    }
}