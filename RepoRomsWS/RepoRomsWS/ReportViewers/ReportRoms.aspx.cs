using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Microsoft.Reporting.WebForms;
using RepoRomsWS.Models;

namespace RepoRomsWS.ReportViewers
{
    public partial class ReportRoms : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ReportViewer1.ProcessingMode = ProcessingMode.Local;
            ReportViewer1.LocalReport.ReportPath = Server.MapPath("ReporteRoms.rdlc");
            RomsContext db = new RomsContext();
            ReportDataSource datasource = new ReportDataSource("Roms", (from Roms in db.Roms
                                                                        select Roms));
            ReportViewer1.LocalReport.DataSources.Clear();
            ReportViewer1.LocalReport.DataSources.Add(datasource);
        }
    }
}