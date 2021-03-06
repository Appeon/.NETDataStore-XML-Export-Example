using DWNet.Data;
using SnapObjects.Data;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlDataExportDemo
{
    [DataWindow("d_sq_gr_employee", DwStyle.Grid)]
    [Table("Employee", Schema = "HumanResources")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT( VERSION(400) TABLE(NAME=\"HumanResources.Employee\" ) COLUMN(NAME=\"HumanResources.Employee.BusinessEntityID\") COLUMN(NAME=\"HumanResources.Employee.NationalIDNumber\") COLUMN(NAME=\"HumanResources.Employee.LoginID\") COLUMN(NAME=\"HumanResources.Employee.OrganizationLevel\") COLUMN(NAME=\"HumanResources.Employee.JobTitle\")) ")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [DwTemplate(DataFormat.Xml, "normal", "DataWindows\\Department.pbt\\Department.pbl\\d_sq_gr_employee.tpl.normal.xml", IsDefault = true)]
    [DwData(typeof(D_Sq_Gr_Employee_Data))]
    public class D_Sq_Gr_Employee
    {
        [Key]
        public int Businessentityid { get; set; }

        [ConcurrencyCheck]
        public string Nationalidnumber { get; set; }

        [ConcurrencyCheck]
        public string Loginid { get; set; }

        [ConcurrencyCheck]
        public int? Organizationlevel { get; set; }

        [ConcurrencyCheck]
        public string Jobtitle { get; set; }

    }

    #region D_Sq_Gr_Employee_Data
    public class D_Sq_Gr_Employee_Data : DwDataInitializer<D_Sq_Gr_Employee>
    {
        public override IList<D_Sq_Gr_Employee> GetDefaultData()
        {
            var datas = new List<D_Sq_Gr_Employee>()
            {
                 new D_Sq_Gr_Employee() { Businessentityid = 1, Nationalidnumber = "295847284 ", Loginid = "adventure-works~\\roberto0 ", Organizationlevel = 1, Jobtitle = "Vice President of Engineering " },
                 new D_Sq_Gr_Employee() { Businessentityid = 2, Nationalidnumber = "509647174 ", Loginid = "adventure-works~\\ovidiu0 ", Organizationlevel = 2, Jobtitle = "Senior Tool Designer " },
                 new D_Sq_Gr_Employee() { Businessentityid = 3, Nationalidnumber = "134969118 ", Loginid = "adventure-works~\\david0 ", Organizationlevel = 3, Jobtitle = "Research and Development Manager " },
            };

            return datas;
        }
    }
    #endregion
}