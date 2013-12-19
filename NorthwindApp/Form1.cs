using NorthwindApp.Ex;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NorthwindApp
{
    public partial class Form1 : Form
    {
        DataContextDataContext dc;
        public Form1()
        {
            InitializeComponent();
         dc=   new DataContextDataContext();
        }

        private void q1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           this.dataGridViewer.DataSource= dc.Customers.ToList();
        }

        private void q2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
 
        }

        private void deleteCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var selected = (from x in dc.Customers where x.CustomerID == "1"
                            select x).SingleOrDefault();
            selected.Country = "Palestine";

            dc.Customers.Context.SubmitChanges();


        }

        private void ex1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          //  var x = from r in dc.Employees.ToList() select new  {Name = r.FirstName + " " + r.LastName, Address = r.Address, Region = r.Region };

            var results = dc.ExecuteQuery<Employee>
     (@"SELECT EmployeeID,FirstName,Address,Region FROM Employees"
     );
            this.dataGridViewer.DataSource = results.ToList();
          this.dataGridViewer.RemoveEmptyColumns();
        }

        private void ex2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = dc.ExecuteQuery<Employee>
(@"SELECT TOP 1000 [EmployeeID]
      ,[LastName]
      ,[FirstName]
      ,[Title]
      ,[TitleOfCourtesy]
      ,[BirthDate]
      ,[HireDate]
      ,[Address]
      ,[City]
      ,[Region]
      ,[PostalCode]
      ,[Country]
      ,[HomePhone]
      ,[Extension]
      ,[Photo]
      ,[Notes]
      ,[ReportsTo]
      ,[PhotoPath]
  FROM [northwind].[dbo].[Employees] where Country='USA'"
);
            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();
        }

        private void ex3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var results = from E in dc.Employees
            //        where E.BirthDate < DateTime.Today.AddYears(-50)
            //        select new { E.FirstName, E.LastName, E.Address, E.City, E.Region };

//            var results = dc.ExecuteQuery<Employee>
//(@"SELECT TOP 1000 [EmployeeID]
//      ,[LastName]
//      ,[FirstName]
//      ,[Title]
//      ,[TitleOfCourtesy]
//      ,[BirthDate]
//      ,[HireDate]
//      ,[Address]
//      ,[City]
//      ,[Region]
//      ,[PostalCode]
//      ,[Country]
//      ,[HomePhone]
//      ,[Extension]
//      ,[Photo]
//      ,[Notes]
//      ,[ReportsTo]
//      ,[PhotoPath]
//  FROM [northwind].[dbo].[Employees]
//WHERE convert(varchar, [northwind].[dbo].[Employees].[BirthDate], 111) < '1962/1/1'"
//);

            var results = dc.ExecuteQuery<Employee>
(@"SELECT EmployeeID,Address,Region,city,FirstName,BirthDate FROM Employees WHERE(select DATEDIFF(yy,BirthDate, getdate()))>50"
);


            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();
        }

        private void ex4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var results = from E in dc.Employees
            //              from O in E.Orders
            //              where O.ShipCountry == "Belgium"
            //              select new { E.FirstName, E.LastName, E.Address, E.City, E.Region,O.ShipCountry };

            var results = dc.ExecuteQuery<EX4>
(@"SELECT FirstName, LastName, Address, City, Region, ShipCountry
FROM dbo.Employees , dbo.Orders
WHERE (dbo.Orders.ShipCountry = 'Belgium' ) 
AND (dbo.Orders.EmployeeID = dbo.Employees.EmployeeID)

"
);


            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();
        }
        

    }

    public static class ExtensionGridView
    {
        public static DataGridView RemoveEmptyColumns(this DataGridView dataGridViewer)
        {
            foreach (DataGridViewColumn clm in dataGridViewer.Columns)
            {
                bool notAvailable = true;

                foreach (DataGridViewRow row in dataGridViewer.Rows)
                {
                    if (row.Cells[clm.Index].Value != null)
                    {
                        if (!string.IsNullOrEmpty(row.Cells[clm.Index].Value.ToString()))
                        {
                            notAvailable = false;
                            break;
                        }
                    }
                }
                if (notAvailable)
                {
                    dataGridViewer.Columns[clm.Index].Visible = false;
                }
            }

            return dataGridViewer;
        }
    }
}
