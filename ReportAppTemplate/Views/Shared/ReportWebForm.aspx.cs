using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ReportAppTemplate.Views.Shared
{
    public partial class ReportWebForm : System.Web.Mvc.ViewPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ReportViewer1.Reset();
                ReportViewer1.LocalReport.ReportPath = Server.MapPath("~/Reports/Report1.rdlc");
                string Parameter1 = "" + ViewData["Parameter1"];
                string Parameter2 = "" + ViewData["Parameter2"];
                var report_params = new ReportParameter[]
                        {
                        new ReportParameter("Parameter1", Parameter1),
                        new ReportParameter("Parameter2",  Parameter2)

                        };
                ReportViewer1.LocalReport.DataSources.Clear();
                ReportViewer1.LocalReport.SetParameters(report_params);
                ReportViewer1.LocalReport.Refresh();

            }

        }
    }
}