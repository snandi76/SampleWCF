using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EmployeeWebClient
{
    public partial class WebForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            EmployeeService.Employee emp= client.GetEmployee(Convert.ToInt32(TextBox1.Text));
            TextBox2.Text = emp.Name;
            TextBox3.Text = emp.Gender;
            TextBox4.Text = emp.DateOfBirth.ToShortDateString();
            Label5.Text = "Employee Retrived";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            EmployeeService.EmployeeServiceClient client = new EmployeeService.EmployeeServiceClient("BasicHttpBinding_IEmployeeService");
            EmployeeService.Employee emp = new EmployeeService.Employee();
            emp.Id = Convert.ToInt32(TextBox1.Text);
            emp.Name = TextBox2.Text;
            emp.Gender = TextBox3.Text;
            emp.DateOfBirth = Convert.ToDateTime(TextBox4.Text);
            client.SaveEmployee(emp);
            Label5.Text = "stored successfully";
        }
    }
}