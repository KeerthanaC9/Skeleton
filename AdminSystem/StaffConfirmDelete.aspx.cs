using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{
    //variable to store the primary key value of the record to be deleted
    Int32 StaffID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the staff to be deleted from the session object
        StaffID = Convert.ToInt32(Session["StaffID"]);

    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create a new instance of the staff collection class
        clsStaffCollection StaffCollection = new clsStaffCollection();
        //find the record to delete
        StaffCollection.ThisStaff.Find(StaffID);
        //delete the record
        StaffCollection.Delete();
        //redirect back to the list page
        Response.Redirect("StaffList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect tback to the list page
        Response.Redirect("StaffList.aspx");
    }
}