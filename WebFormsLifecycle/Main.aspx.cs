using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebFormsLifecycle
{
    public partial class Main : System.Web.UI.Page
    {
        /*protected void Page_PreInit(object sender, EventArgs e)
        {
            string preInit = @"
                <div class='d-grid gap-2 col-6 mx-auto mt-3'>
                    <div class='shadow-sm p-1 m-0 bg-info rounded bg-gradient'>
                        <p class='text-success-50 p-0 m-0'>&#128221;  Page_PreInit event executed.</p>
                    </div>
                </div>";
            Response.Write(preInit);
            Response.End();
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            string pageInit = @"
                <div class='d-grid gap-2 col-6 mx-auto mt-3'>
                    <div class='shadow-sm p-1 m-0 bg-info rounded bg-gradient'>
                        <p class='text-success-50 p-0 m-0'>&#128190;  Page_Init event executed.</p>
                    </div>
                </div>";
            Response.Write(pageInit);
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string pageLoad = @"
                <div class='d-grid gap-2 col-6 mx-auto mt-3'>
                    <div class='shadow-sm p-1 m-0 bg-secondary rounded bg-gradient'>
                        <p class='text-success-50 p-0 m-0'>&#128204;  Page_Load event executed for the first time.</p>
                    </div>
                </div>";
            if (!IsPostBack)
            {
                Response.Write(pageLoad);
            }
            else
            {
                pageLoad = @"
                <div class='d-grid gap-2 col-6 mx-auto mt-3'>
                    <div class='shadow-sm p-1 m-0 bg-info rounded bg-gradient'>
                        <p class='text-success-50 p-0 m-0'>&#128176;  Page_Load event executed on postback.</p>
                    </div>
                </div>";

                Response.Write(pageLoad);
            }
        }

        protected void Page_Unload(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Page_Unload event executed.");
            //Response.Write("Page_Unload event executed.<br />");
        }

        protected override void Render(HtmlTextWriter writer)
        {
            string render = @"
                <div class='d-grid gap-2 col-6 mx-auto mt-3'>
                    <div class='shadow-sm p-1 m-0 bg-info rounded bg-gradient'>
                        <p class='text-success-50 p-0 m-0'>&#128221;  Page_Render event executed.</p>
                    </div>
                </div>";
            Response.Write(render);

            base.Render(writer);
        }

        protected void ClickMe_BTN_Click1(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if (ClickLabel.Text == "Cat is shy")
            {
                btn.CssClass = "btn btn-success w-50 mt-3";
                ClickLabel.Text = "Cat is now out";
                cat.ImageUrl = "~/Content/cat/cat2.png";
            }
            else
            {
                btn.CssClass = "btn btn-danger w-50 mt-3";
                ClickLabel.Text = "Cat is shy";
                cat.ImageUrl = "~/Content/cat/cat1.png";
            }
        }*/
        private string CurrentStage
        {
            get { return ViewState["CurrentStage"] as string ?? "Page_PreInit"; }
            set { ViewState["CurrentStage"] = value; }
        }

        protected void Page_PreInit(object sender, EventArgs e)
        {
            if (CurrentStage == "Page_PreInit")
            {
            }
        }

        protected void Page_Init(object sender, EventArgs e)
        {
            if (CurrentStage == "Page_Init")
            {
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (CurrentStage == "Page_Load")
            {
            }
        }

        protected void Page_PreRender(object sender, EventArgs e)
        {
            if (CurrentStage == "Page_PreRender")
            {
            }
        }

        protected void ClickMe_BTN_Click1(object sender, EventArgs e)
        {
            switch (CurrentStage)
            {
                case "Page_PreInit":
                    CurrentStage = "Page_Init";
                    ClickLabel.Text = "Page_PreInit event executed.";
                    cat.Visible = true;
                    cat.ImageUrl = "~/Content/images/page1.png";
                    break;
                case "Page_Init":
                    CurrentStage = "Page_Load";
                    ClickLabel.Text = "Page_Init event executed.";
                    cat.ImageUrl = "~/Content/images/page2.png";
                    break;
                case "Page_Load":
                    CurrentStage = "Page_PreRender";
                    ClickLabel.Text = "Page_PreRender event executed.";
                    cat.ImageUrl = "~/Content/images/page3.png";
                    break;
                case "Page_PreRender":
                    ClickLabel.Text = "Lifecycle completed!";
                    cat.ImageUrl = "~/Content/images/page4.png";
                    ClickMe_BTN.Enabled = false; // Disable button
                    break;
            }
        }
    }
}