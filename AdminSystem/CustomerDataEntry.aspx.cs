using System;
using ClassLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


public partial class _1_DataEntry : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
        CustomerId = Convert.ToInt32(Session["CustomerId"]);
        if (IsPostBack == false)
        {
            if (CustomerId != -1)
            {
                DisplayCustomer();
            }
        }


    }

    protected void Unnamed2_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsCustomer
        clsCustomer AnCustomer = new clsCustomer();
        //capture the name
        string CustomerName = txtCustomerName.Text;
        string CustomerEmail = txtCustomerEmail.Text;
        string CustomerDob = txtCustomerDob.Text;
        string CustomerPhoneNumber = txtCustomerPhoneNumber.Text;
        string CustomerAddress = txtCustomerAddress.Text;

        string Error = "";
        Error = AnCustomer.Valid(CustomerName, CustomerEmail, CustomerDob, CustomerPhoneNumber, CustomerAddress);
        if (Error == "")
        {
            AnCustomer.CustomerId = CustomerId;
            AnCustomer.CustomerName = CustomerName;
            AnCustomer.CustomerEmail = CustomerEmail;
            AnCustomer.CustomerDob = Convert.ToDateTime(CustomerDob);
            AnCustomer.CustomerPhoneNumber = CustomerPhoneNumber;
            AnCustomer.CustomerAddress = CustomerAddress;
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = AnCustomer;
           if(CustomerId == -1)
            {
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerId);
                CustomerList.ThisCustomer = AnCustomer;
                CustomerList.Update();
            }

            Response.Redirect("CustomerList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }




    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer AnCustomer = new clsCustomer();
        Int32 CustomerId;
        Boolean Found = false;
        CustomerId = Convert.ToInt32(txtCustomerId.Text);
        Found = AnCustomer.Find(CustomerId);
        if (Found == true)
        {
            txtCustomerName.Text = AnCustomer.CustomerName;
            txtCustomerEmail.Text = AnCustomer.CustomerEmail;
            txtCustomerDob.Text = AnCustomer.CustomerDob.ToString();
            txtCustomerPhoneNumber.Text = AnCustomer.CustomerPhoneNumber;
            txtCustomerAddress.Text = AnCustomer.CustomerAddress;


        }
        }
        void DisplayCustomer()
        {
            clsCustomerCollection CustomerBook = new clsCustomerCollection();
            CustomerBook.ThisCustomer.Find(CustomerId);
            txtCustomerId.Text = CustomerBook.ThisCustomer.CustomerId.ToString();
            txtCustomerName.Text = CustomerBook.ThisCustomer.CustomerName.ToString();
            txtCustomerEmail.Text = CustomerBook.ThisCustomer.CustomerEmail.ToString();
            txtCustomerDob.Text = CustomerBook.ThisCustomer.CustomerDob.ToString();
            txtCustomerPhoneNumber.Text = CustomerBook.ThisCustomer.CustomerPhoneNumber.ToString();
            txtCustomerAddress.Text = CustomerBook.ThisCustomer.CustomerAddress.ToString();

        }
    
}