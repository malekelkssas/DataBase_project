﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace firstpro
{
    public partial class SystemAdmin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //(string)Session["UserName"]  <<-- this is how to get the username
            if (Session["IsLoggedIn"] == null || !((string)Session["IsLoggedIn"]).Equals("SystemAdmin"))
                Response.Redirect("/login.aspx");
            else
            {
                //Lab.Text = "Welcome " + (string)Session["UserName"];
                HtmlGenericControl p = new HtmlGenericControl("h1");
                p.InnerText = "Welcome " + Session["UserName"];
                Lab.Controls.Add(p);
                
            }
            
            
        }

        protected void AddClub(object sender, EventArgs e)
        {
            Response.Redirect("/Addclub.aspx");
        }

        protected void Deleteclub(object sender, EventArgs e)
        {
            Response.Redirect("/deleteClub.aspx");
        }

        protected void AddStadium(object sender, EventArgs e)
        {
            Response.Redirect("/AddStadium.aspx");
        }

        protected void DeleteStadium(object sender, EventArgs e)
        {
            Response.Redirect("/deleteStadium.aspx");
        }

        protected void BlockFan(object sender, EventArgs e)
        {
            Response.Redirect("/BlockFan.aspx");
        }
    }
}