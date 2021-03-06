using DWNet.Data;
using SnapObjects.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace XmlDataExportDemo
{
    [DataWindow("d_sq_gr_department", DwStyle.Grid)]
    [Table("Department", Schema = "HumanResources")]
    #region DwSelectAttribute  
    [DwSelect("PBSELECT(TABLE(NAME=\"HumanResources.Department\") COLUMN(NAME=\"HumanResources.Department.DepartmentID\") COLUMN(NAME=\"HumanResources.Department.Name\") COLUMN(NAME=\"HumanResources.Department.GroupName\") COLUMN(NAME=\"HumanResources.Department.ModifiedDate\") )")]
    #endregion
    [UpdateWhereStrategy(UpdateWhereStrategy.KeyAndConcurrencyCheckColumns)]
    [DwKeyModificationStrategy(UpdateSqlStrategy.DeleteThenInsert)]
    [DwGroupBy(1, "modifieddate")]
    [DwTemplate(DataFormat.Xml, "normal", "DataWindows\\Department.pbt\\Department.pbl\\d_sq_gr_department.tpl.normal.xml", IsDefault = true)]
    [DwTemplate(DataFormat.Xml, "group", "DataWindows\\Department.pbt\\Department.pbl\\d_sq_gr_department.tpl.group.xml")]
    [DwTemplate(DataFormat.Xml, "sort", "DataWindows\\Department.pbt\\Department.pbl\\d_sq_gr_department.tpl.sort.xml")]
    [DwData(typeof(D_Sq_Gr_Department_Data))]
    public class D_Sq_Gr_Department
    {
        [Identity]
        [Key]
        public int Departmentid { get; set; }

        [ConcurrencyCheck]
        public string Name { get; set; }

        [ConcurrencyCheck]
        public string Groupname { get; set; }

        [ConcurrencyCheck]
        public DateTime? Modifieddate { get; set; }

    }

    #region D_Sq_Gr_Department_Data
    public class D_Sq_Gr_Department_Data : DwDataInitializer<D_Sq_Gr_Department>
    {
        public override IList<D_Sq_Gr_Department> GetDefaultData()
        {
            var datas = new List<D_Sq_Gr_Department>()
            {
                 new D_Sq_Gr_Department() { Departmentid = 1, Name = "Engineering ", Groupname = "Research and Development1 ", Modifieddate = DateTime.Parse("2011-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 2, Name = "Tool Design ", Groupname = "Research and Development ", Modifieddate = DateTime.Parse("2011-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 3, Name = "Sales ", Groupname = "Sales and Marketing ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 4, Name = "Marketing ", Groupname = "Sales and Marketing ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 5, Name = "Purchasing ", Groupname = "Inventory Management ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 6, Name = "Research and Development ", Groupname = "Research and Development ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 7, Name = "Production ", Groupname = "Manufacturing ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 8, Name = "Production Control ", Groupname = "Manufacturing ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 9, Name = "Human Resources ", Groupname = "Sales and Marketing ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 10, Name = "Finance ", Groupname = "Inventory Management ", Modifieddate = DateTime.Parse("2012-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 11, Name = "Information Services ", Groupname = "Executive General and Administration ", Modifieddate = DateTime.Parse("2015-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 12, Name = "Document Control ", Groupname = "Quality Assurance ", Modifieddate = DateTime.Parse("2015-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 14, Name = "Quality Assurance ", Groupname = "Quality Assurance ", Modifieddate = DateTime.Parse("2015-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 15, Name = "Facilities and Maintenance ", Groupname = "Executive General and Administration ", Modifieddate = DateTime.Parse("2015-01-02 00:00:00.000000") },
                 new D_Sq_Gr_Department() { Departmentid = 16, Name = "Shipping and Receiving ", Groupname = "Inventory Management ", Modifieddate = DateTime.Parse("2015-01-02 00:00:00.000000") },
            };

            return datas;
        }
    }
    #endregion
}