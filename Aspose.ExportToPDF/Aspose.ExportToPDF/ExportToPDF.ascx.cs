using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Net;
using System.Text;
using Aspose.Words;

namespace Aspose.ExportToPDF
{
    public partial class ExportToPDF : System.Web.UI.UserControl
    {
        private string OutputFileName
        {
            get
            {
                string name = HttpContext.Current.Request.RawUrl.Substring(HttpContext.Current.Request.RawUrl.LastIndexOf("/"));
                name = name.Replace("/", string.Empty).Replace(".aspx", ".pdf");
                return name;
            }
        }

        private string CurrentPageURL
        {
            get
            {
                string url = Request.Url.Authority + HttpContext.Current.Request.RawUrl.ToString();

                if (Request.ServerVariables["HTTPS"] == "on")
                {
                    url = "https://" + url;
                }
                else
                {
                    url = "http://" + url;
                }

                return url;
            }
        }

        private string BaseURL
        {
            get
            {
                string url = Request.Url.Authority;

                if (Request.ServerVariables["HTTPS"] == "on")
                {
                    url = "https://" + url;
                }
                else
                {
                    url = "http://" + url;
                }

                return url;
            }
        }

        protected void ExportButton_Click(object sender, EventArgs e)
        {
            string html = new WebClient().DownloadString(CurrentPageURL);

            // To make the relative image paths work, base URL must be included in head section
            html = html.Replace("</head>", string.Format("<base href='{0}'></base></head>", BaseURL));

            // Check for license and apply if exists
            string licenseFile = Server.MapPath("~/App_Data/Aspose.Words.lic");
            if (File.Exists(licenseFile))
            {
                License license = new License();
                license.SetLicense(licenseFile);
            }

            MemoryStream stream = new MemoryStream(Encoding.UTF8.GetBytes(html));
            Document doc = new Document(stream);
            doc.Save(Response, OutputFileName, ContentDisposition.Inline, null);
            Response.End();
        }
    }
}