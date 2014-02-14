using Aspose.Words;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Import_from_Word
{
    public partial class importFromWord : System.Web.UI.UserControl
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
                Stream stream = FU_Doc.FileContent;
                Document doc = new Document(stream);
                doc.Save(FU_Doc.FileName, SaveFormat.Html);
                string outputText = File.ReadAllText(FU_Doc.FileName);
                    div_display.InnerHtml = outputText;
                
            }
            else
            {
                LBL_Error.Text = "Please Upload File";
            }
        }
    }
}