using NorthwindApp.Ex;
using NorthwindApp.QueryObjects;
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
            //              where E.BirthDate < DateTime.Today.AddYears(-50)
            //              select new { E.FirstName, E.LastName, E.Address, E.City, E.Region };

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
(@"SELECT EmployeeID,Address,Region,city,FirstName,BirthDate FROM Employees WHERE (select DATEDIFF(yy,BirthDate, getdate())) >= 50"
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

        private void ex5ToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //var results = from E in dc.Employees
            //              join O in dc.Orders on E.EmployeeID equals O.EmployeeID
            //              join C in dc.Customers on O.CustomerID equals C.CustomerID
            //              join S in dc.Shippers on O.ShipVia equals S.ShipperID
            //              where C.City == "Bruxelles"
            //              where S.CompanyName == "Speedy Express"
            //              select new { E.FirstName, E.LastName, C.CompanyName };

                        var results = dc.ExecuteQuery<EX5>
(@"SELECT t0.FirstName, t0.LastName, t2.CompanyName as CustomerCompanyName  ,t3.CompanyName as ShipperCompanyName, t2.City
FROM dbo.Employees AS t0
INNER JOIN dbo.Orders AS t1 ON (t0.EmployeeID) = t1.EmployeeID
INNER JOIN dbo.Customers AS t2 ON t1.CustomerID = t2.CustomerID
INNER JOIN dbo.Shippers AS t3 ON t1.ShipVia = (t3.ShipperID)
WHERE (t3.CompanyName = 'Speedy Express') AND (t2.City = 'Bruxelles')");

            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();
        }

        private void ex6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //var results = (from E in dc.Employees
            //               from O in E.Orders
            //               from D in O.Order_Details
            //               join P in dc.Products on D.ProductID equals P.ProductID
            //               where P.ProductName == "Gravad Lax" || P.ProductName == "Mishi Kobe Niku"
            //               select new { E.Title, E.FirstName, E.LastName }).Distinct();

//           var results = dc.ExecuteQuery<EX6>(
//@"SELECT DISTINCT t0.Title, t0.FirstName, t0.LastName 
//FROM dbo.Employees AS t0
//CROSS JOIN dbo.Orders AS t1
//CROSS JOIN dbo.[Order Details] AS t2
//INNER JOIN dbo.Products AS t3 ON t2.ProductID = t3.ProductID
//WHERE ((t3.ProductName = 'Gravad Lax') OR (t3.ProductName = 'Mishi Kobe Niku')) AND (t1.EmployeeID = t0.EmployeeID) AND (t2.OrderID = t1.OrderID)");


                       var results = dc.ExecuteQuery<EX6>(
@"            SELECT DISTINCT t0.Title, t0.FirstName, t0.LastName 
FROM dbo.Employees AS t0 
INNER JOIN dbo.Orders AS t1 ON (t1.EmployeeID = t0.EmployeeID) 
INNER JOIN dbo.[Order Details] AS t2 ON  (t2.OrderID = t1.OrderID)
INNER JOIN dbo.Products AS t3 ON t2.ProductID = t3.ProductID
WHERE ((t3.ProductName = 'Gravad Lax') OR (t3.ProductName = 'Mishi Kobe Niku')) ");






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
