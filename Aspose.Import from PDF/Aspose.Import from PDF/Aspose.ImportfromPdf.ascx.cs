
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Aspose.Pdf;

namespace Aspose.Import_from_PDF
{
    public partial class Import_from_Pdf : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void BTN_Import_Click(object sender, EventArgs e)
        {
            if (FU_Doc.HasFile)
            {
                // Check for license and apply if exists
                string licenseFile = Server.MapPath("~/App_Data/Aspose.Total.lic");
                if (File.Exists(licenseFile))
                {
                    License license = new License();
                    license.SetLicense(licenseFile);
                }

                // Initialize the stream to read the uploaded file.
                Stream myStream = FU_Doc.FileContent;
                //open document
                Document pdfDocument = new Document(myStream);
                string path = Server.MapPath(".")+"//"+FU_Doc.FileName.Replace(".pdf",".html");
                pdfDocument.Save(path,SaveFormat.Html);
                string extractedText = File.ReadAllText(path);
                div_display.InnerHtml = extractedText;
            }
            else
            {
                LBL_Error.Text = "Please Upload File";
            }
        }
    }
}