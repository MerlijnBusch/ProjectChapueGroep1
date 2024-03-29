﻿using SomerenDAL;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Data;
using ChapooDatabaseModel;

namespace ChapooDatabaseDal
{
    public class EmployeeDAO : Base
    {
        public List<Employee> GetAllEmployee()
        {
            string query = "SELECT EmployeeID, Firstname, Lastname, Email, Telephone, Position, [Password] FROM Employees";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        public void UpdateEmploy(int EmployeeID, string Firstname, string Lastname, string Email, float Telephone, string Position)
        {
            string qu = "UPDATE Employees SET Firstname = @first, Lastname = @last, Email = @email, Telephone = @tele, Position = @pos WHERE EmployeeID = @empid";
            SqlParameter[] sqlp = new SqlParameter[6];

            SqlParameter eid = new SqlParameter("@empId", SqlDbType.Int) { Value = EmployeeID };
            sqlp[0] = eid;

            SqlParameter fnm = new SqlParameter("@first", SqlDbType.VarChar) { Value = Firstname };
            sqlp[1] = fnm;

            SqlParameter lnm = new SqlParameter("@last", SqlDbType.VarChar) { Value = Lastname };
            sqlp[2] = lnm;

            SqlParameter enm = new SqlParameter("@email", SqlDbType.VarChar) { Value = Email };
            sqlp[3] = enm;

            SqlParameter tp = new SqlParameter("@tele", SqlDbType.Float) { Value = Telephone };
            sqlp[4] = tp;

            SqlParameter pos = new SqlParameter("@pos", SqlDbType.VarChar) { Value = Position };
            sqlp[5] = pos;

            ExecuteEditQuery(qu, sqlp);
        }
        
        public void UpdateEmployeePassword(int EmployeeID, string password)
        {
            string qu = "UPDATE Employees SET Password = @pass WHERE EmployeeID = @empid";
            SqlParameter[] sqlp = new SqlParameter[2];

            SqlParameter eid = new SqlParameter("@empId", SqlDbType.Int) { Value = EmployeeID };
            sqlp[0] = eid;

            SqlParameter fnm = new SqlParameter("@pass", SqlDbType.VarChar) { Value = password };
            sqlp[1] = fnm;

            ExecuteEditQuery(qu, sqlp);
        }

        public void DeleteEmployee(int id)
        {
            string query = "DELETE FROM [Employees] WHERE EmployeeID = @id";
            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter orderId = new SqlParameter("@id", SqlDbType.Int) { Value = id };
            sqlParameters[0] = orderId;

            ExecuteEditQuery(query, sqlParameters);
        }

        public void AddEmployee(string Firstname, string Lastname, string Email, string Position, string Password, float tele)
        {
            string qu = "insert into [Employees] (Firstname, Lastname, Email, Position, Password, Telephone) VALUES (@first, @last, @email, @pos, @pass, @tele)";
            SqlParameter[] sqlp = new SqlParameter[6];
            SqlParameter fnm = new SqlParameter("@first", SqlDbType.VarChar) { Value = Firstname };
            sqlp[0] = fnm;

            SqlParameter lnm = new SqlParameter("@last", SqlDbType.VarChar) { Value = Lastname };
            sqlp[1] = lnm;

            SqlParameter enm = new SqlParameter("@email", SqlDbType.VarChar) { Value = Email };
            sqlp[2] = enm;

            SqlParameter pnm = new SqlParameter("@pass", SqlDbType.VarChar) { Value = Password };
            sqlp[3] = pnm;

            SqlParameter tp = new SqlParameter("@tele", SqlDbType.Float) { Value = tele };
            sqlp[4] = tp;

            SqlParameter pos = new SqlParameter("@pos", SqlDbType.VarChar) { Value = Position };
            sqlp[5] = pos;

            ExecuteEditQuery(qu, sqlp);
        }
        
        
        private List<Employee> ReadTables(DataTable dataTable)
        {
            List<Employee> employeeList = new List<Employee>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Employee menu = new Employee(
                    Convert.ToInt32(dr["EmployeeID"]),
                    dr["Firstname"].ToString(),
                    dr["Lastname"].ToString(),
                    dr["Email"].ToString(),
                    (float)(double)dataTable.Rows[0]["Telephone"],
                    dr["Position"].ToString()
                );
                employeeList.Add(menu);
            }
            return employeeList;
        }

        public int EmployeeExist(int id)
        {
            string query = "SELECT COUNT(*) FROM Employee WHERE EmployeeID = @EmployeeID";

            SqlParameter[] sqlParameters = new SqlParameter[1];

            SqlParameter pid = new SqlParameter("@EmployeeID", SqlDbType.Int) { Value = id };
            sqlParameters[0] = pid;

            return ExecuteCountInteger(query, sqlParameters);
        }
    }
}
