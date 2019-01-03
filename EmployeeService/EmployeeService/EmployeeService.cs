using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace EmployeeService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmployeeService" in both code and config file together.
    public class EmployeeService : IEmployeeService
    {

        public Employee GetEmployee(int Id)
        {
            Employee employee = new Employee();
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spGetEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                parameterId.ParameterName = "@Id";
                parameterId.Value = Id;
                cmd.Parameters.Add(parameterId);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while(reader.Read())
                {
                    employee.Id = Convert.ToInt32(reader["Id"]);
                    employee.Name = reader["Name"].ToString();
                    employee.Gender = reader["Gender"].ToString();
                    employee.DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);
                }
            }
            return employee;
        }

        public void SaveEmployee(Employee Employee)
        {
            string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("spSaveEmployee", con);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlParameter parameterId = new SqlParameter();
                {
                    parameterId.ParameterName = "@Id";
                    parameterId.Value = Employee.Id;
                }
                cmd.Parameters.Add(parameterId);

                SqlParameter parameterName = new SqlParameter();
                {
                    parameterName.ParameterName = "@Name";
                    parameterName.Value = Employee.Name;
                }
                cmd.Parameters.Add(parameterName);

                SqlParameter parameterGender = new SqlParameter();
                {
                    parameterGender.ParameterName = "@Gender";
                    parameterGender.Value = Employee.Gender;
                }
                cmd.Parameters.Add(parameterGender);

                SqlParameter parameterDateOfBirth = new SqlParameter();
                {
                    parameterDateOfBirth.ParameterName = "@DateOfBirth";
                    parameterDateOfBirth.Value = Employee.DateOfBirth;
                }
                cmd.Parameters.Add(parameterDateOfBirth);
                con.Open();
                cmd.ExecuteNonQuery();
            }
        }
    }
}
