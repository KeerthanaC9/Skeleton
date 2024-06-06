using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayStaff();
        }

    }

    void DisplayStaff()
    {
        //create an instance of the Staff Collection
        clsStaffCollection staffCollection = new clsStaffCollection();
        //set the data source to list of staff in the collection
        lstStaffList.DataSource = staffCollection.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the data field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StaffID"] = -1;
        //redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StaffID;
        //if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the session object
            Session["StaffID"] = StaffID;
            //redircet to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else       //if no record has been selected
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be delted
        Int32 StaffID;
        //if a record has been selected from the list
        if ( lstStaffList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            //store the data in the sessioon object
            Session["StaffID"] = StaffID;
            //redirect to the delete page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else   //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnStaffRoleApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection staffCollection = new clsStaffCollection(); 
        //retrieve the value of staff role from the presentation layer
        staffCollection.ReportByStaffRole(txtStaffRoleFilter.Text);
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = staffCollection.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set te name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnStaffRoleClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the staff object
        clsStaffCollection staffCollection = new clsStaffCollection();
        //set an empty string
        staffCollection.ReportByStaffRole("");
        //clear any existing filter to tidy up the interface
        txtStaffRoleFilter.Text = "";
        //set the data source to the list of staff in the collection
        lstStaffList.DataSource = staffCollection.StaffList;
        //set the name of the primary key
        lstStaffList.DataValueField = "StaffID";
        //set the name of the field to display
        lstStaffList.DataTextField = "StaffName";
        //bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnMainMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnStPage_Click(object sender, EventArgs e)
    {
        Response.Redirect("StaffStatistics.aspx");
    }
}