using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using SnapObjects.Data;
using DWNet.Data;

namespace XmlDataDemo
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