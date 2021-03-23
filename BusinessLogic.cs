using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication22
{
    public class BusinessLogic
    {
        SqlConnection con;
        SqlDataAdapter da;
        SqlCommandBuilder cmb;
        DataRow row;
        DataSet ds;
        public BusinessLogic()
        {
            con = new SqlConnection(@"Data Source=OJAS-LD18\SQLEXPRESS;Initial Catalog=ResultDB;User ID=sa;Password=Ojas@15251525");
            da = new SqlDataAdapter("select * from Student_dt", con);
            cmb = new SqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds, "Student_dt");
            da.Update(ds.Tables["Student_dt"]);
            ds.Tables["Student_dt"].Constraints.Add("Hallticket_pk", ds.Tables["Student_dt"].Columns["Hallticket"], true);
        }
        public bool Display(StudentDetails studentDetails)
        {
            row = ds.Tables["Student_dt"].NewRow();
            row["StudentName"] = studentDetails.StudentName;
            row["Total"] = studentDetails.Total;
            row["Hallticket"] = studentDetails.Hallticket;
            row["Subject1"] = studentDetails.Subject1;
            row["Subject2"] = studentDetails.Subject2;
            
            row["Total"]= studentDetails.Subject1+ studentDetails.Subject2;
            if(studentDetails.Subject1>=35 && studentDetails.Subject2>=35)
            {
                row["Result"] = "Your are Eligible for Next Class";
            }
            else
            {
                row["Result"] = "Your are not Eligible for Next Class Because your fail";
            }
            ds.Tables["Student_dt"].Rows.Add(row);
            return da.Update(ds.Tables["Student_dt"]) == 1;
        }
    }
}