using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;

namespace SqlCommandBuilder
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGetStudent_Click(object sender, EventArgs e)
        {
            string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
           
            using (SqlConnection con = new SqlConnection(CS))
            {
                string sqlQuery = "select * from tblStudents where ID = " + txtStudentID.Text;
                SqlDataAdapter da = new SqlDataAdapter(sqlQuery, con);

                DataSet ds = new DataSet();
                da.Fill(ds, "Students");

                ViewState["SQL_Query"] = sqlQuery;
                ViewState["DataSet"] = ds;

                if (ds.Tables["Students"].Rows.Count > 0)
                {
                    DataRow dr = ds.Tables["Students"].Rows[0];
                    txtStudentName.Text = dr["Name"].ToString();
                    txtTotalMarks.Text = dr["TotalMarks"].ToString();
                    ddlGender.SelectedValue = dr["Gender"].ToString();
                   
                }
                else
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "No Student record with ID =" + txtStudentID.Text;
                }
                //Console.WriteLine(ds.Tables["Students"]);
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
             string CS = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;

             using (SqlConnection con = new SqlConnection(CS))
             {
                 string sqlQuery = "select * from tblStudents where ID = " + txtStudentID.Text;
                 SqlDataAdapter da = new SqlDataAdapter((string)ViewState["SQL_Query"], con);

                 SqlCommandBuilder builder = new SqlCommandBuilder(da);

                 DataSet ds = (DataSet)ViewState["DataSet"];

                 if (ds.Tables["Students"].Rows.Count > 0)
                 {
                     DataRow dr = ds.Tables["Students"].Rows[0];
                     dr["Name"] = txtStudentName.Text;
                     dr["Gender"] = ddlGender.SelectedValue;
                     dr["TotalMarks"] = txtTotalMarks.Text;
                 }
    
                int row = da.Update(ds, "Students");
                if (row > 0)
                {
                    lblStatus.ForeColor = System.Drawing.Color.Green;
                    lblStatus.Text = row.ToString() + "rows updates";

                }
                else
                {
                    lblStatus.ForeColor = System.Drawing.Color.Red;
                    lblStatus.Text = "No rows updates";
                }
                //var va = builder.GetDeleteCommand().CommandText;
             }
        }
    }
}