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

        private void ex7ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var results = dc.ExecuteQuery<EX7>(
@"SELECT t0.Title, t0.FirstName, t0.LastName,t2.Title AS MgrTitle, t2.FirstName AS MgrFistName, t2.LastName  AS MgrLastName
  FROM dbo.Employees AS t0
  LEFT OUTER JOIN (  Select   t1.EmployeeID, t1.LastName, t1.FirstName, t1.Title    FROM dbo.Employees AS t1    ) AS t2 ON t0.ReportsTo = (t2.EmployeeID)
  Where t2.Title  IS NOT NULL ");






            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();


            //var results = from E in dc.Employees
            //              join M1 in dc.Employees on E.ReportsTo equals M1.EmployeeID into M2
            //              from M in M2.DefaultIfEmpty()
            //              select new
            //              {
            //                  E.Title,
            //                  E.FirstName,
            //                  E.LastName,
            //                  MgrTitle = (M == null ? String.Empty : M.Title),
            //                  MgrFistName = (M == null ? String.Empty : M.FirstName),
            //                  MgrLastName = (M == null ? String.Empty : M.LastName)
            //              };

            //this.dataGridViewer.DataSource = results.ToList();
            //this.dataGridViewer.RemoveEmptyColumns();


        }

        private void ex8ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            var results = dc.ExecuteQuery<EX8>(
@"SELECT DISTINCT t4.CompanyName, t1.ProductName, t0.CompanyName AS SupplierName
FROM dbo.Suppliers AS t0
CROSS JOIN dbo.Products AS t1
CROSS JOIN dbo.[Order Details] AS t2
INNER JOIN dbo.Orders AS t3 ON t2.OrderID = t3.OrderID
INNER JOIN dbo.Customers AS t4 ON t3.CustomerID = t4.CustomerID
WHERE 
(t4.City = 'London') 
AND ((t0.CompanyName = 'Pavlova, Ltd.') 
OR (t0.CompanyName = 'Karkki Oy')) 
AND (t1.SupplierID = t0.SupplierID) 
AND (t2.ProductID = t1.ProductID)");






            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();

            //var results = (from S in dc.Suppliers
            //               where S.CompanyName == "Pavlova, Ltd." || S.CompanyName == "Karkki Oy"
            //               from P in S.Products
            //               from D in P.Order_Details
            //               join O in dc.Orders on D.OrderID equals O.OrderID
            //               join C in dc.Customers on O.CustomerID equals C.CustomerID
            //               where C.City == "London"
            //               select new
            //               {
            //                   C.CompanyName,
            //                   P.ProductName,
            //                   SupplierName = S.CompanyName
            //               }).Distinct();

            //this.dataGridViewer.DataSource = results.ToList();
            //this.dataGridViewer.RemoveEmptyColumns();
        }

        private void ex9ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = (from P in dc.Products
                           from D in P.Order_Details
                           join O in dc.Orders on D.OrderID equals O.OrderID
                           join E in dc.Employees on O.EmployeeID equals E.EmployeeID
                           join C in dc.Customers on O.CustomerID equals C.CustomerID
                           where (E.City == "London") || (C.City == "London")
                           select new { P.ProductName }).Distinct();

            this.dataGridViewer.DataSource = results.ToList();
            this.dataGridViewer.RemoveEmptyColumns();
        }

        private void categoyYearSalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = dc.ExecuteQuery<SalesByCategory>(
@"[dbo].[SalesByCategory] Seafood,1998");






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
