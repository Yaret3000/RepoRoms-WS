using Microsoft.Reporting.WebForms;
using RepoRomsWS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace RepoRomsWS.ReportViewers
{
    public partial class ReportConsolas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("ReporteConsolas.rdlc");
            RomsContext db = new RomsContext();
            ReportDataSource datasource = new ReportDataSource("Consolas", (from Consolas in db.Consolas
                                                                        select Consolas));
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }
    }
}