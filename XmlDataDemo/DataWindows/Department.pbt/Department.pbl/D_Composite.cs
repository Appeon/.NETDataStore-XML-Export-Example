using DWNet.Data;
using SnapObjects.Data;
using System.Collections.Generic;

namespace XmlDataExportDemo
{
    [DataWindow("d_composite", DwStyle.Composite)]
    [DwTemplate(DataFormat.Xml, "normal", "DataWindows\\Department.pbt\\Department.pbl\\d_composite.tpl.normal.xml", IsDefault = true)]
    public class D_Composite
    {
        public string A { get; set; }

        [DwReport(typeof(D_Sq_Gr_Department))]
        public IList<D_Sq_Gr_Department> Dw_1 { get; set; }

        [DwReport(typeof(D_Sq_Gr_Employee))]
        public IList<D_Sq_Gr_Employee> Dw_2 { get; set; }

    }

}