using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Jaarwerk_domain4.Buissines;

namespace Default
{
    public partial class Default : System.Web.UI.Page
    {
        Jaarwerk_domain4.Buissines.Controller _controller;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (IsPostBack)

            {

                _controller = (Controller)HttpContext.Current.Session["_controller"];

            }

            else

            {

                if (HttpContext.Current.Session["_controller"] == null)

                {

                    _controller = new Controller();

                    HttpContext.Current.Session["_controller"] = _controller;

                }

                else

                {

                    _controller = (Controller)HttpContext.Current.Session["_controller"];

                }

            }

        } 
    } 
}
