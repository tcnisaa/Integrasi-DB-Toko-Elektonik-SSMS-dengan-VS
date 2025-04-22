using System;
using System.Data.SqlClient;
using System.Data;

namespace TokoElektronik
{
    public partial class ListItems : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter sda = new SqlDataAdapter();
        DataSet ds = new DataSet();

        protected void Page_Load(object sender, EventArgs e)
        {
            con.ConnectionString = "Data Source=DESKTOP-ACA\\SQLEXPRESS; Initial Catalog=TokoElektronik; Integrated Security=True";
            con.Open();
            if (!Page.IsPostBack)
            {
                DataShow();
            }
        }

        public void DataShow()
        {
            ds = new DataSet();
            cmd.CommandText = "SELECT * FROM vw_OrderDetails";
            cmd.Connection = con;
            sda = new SqlDataAdapter(cmd);
            sda.Fill(ds);
            GridViewOrders.DataSource = ds;
            GridViewOrders.DataBind();
            con.Close();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "INSERT INTO Orders (CustomerName, Quantity, ProductID) VALUES ('" + txtCustomerName.Text + "', '" + txtQuantity.Text + "', '" + txtProductID.Text + "')";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "UPDATE Orders SET CustomerName='" + txtCustomerName.Text + "', Quantity='" + txtQuantity.Text + "', ProductID='" + txtProductID.Text + "' WHERE OrderID='" + txtOrderID.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            cmd.CommandText = "DELETE FROM Orders WHERE OrderID='" + txtOrderID.Text + "'";
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            DataShow();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            txtOrderID.Text = null;
            txtCustomerName.Text = null;
            txtQuantity.Text = null;
            txtProductID.Text = null;
        }
    }
}
