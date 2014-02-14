<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Aspose.ImportfromPdf.ascx.cs" Inherits="Aspose.Import_from_PDF.Import_from_Pdf" %>

<div id="div_main">
    
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    
<asp:FileUpload ID="FU_Doc" runat="server" />
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BTN_Import" runat="server" Text="Import from Pdf" OnClick="BTN_Import_Click" />

    <br />

<br />

<b>Below is the desired text Imported from Words:</b>
<div id="div_display" runat="server" ></div>
    <br />
    <br />
    <asp:Label ID="LBL_Error" runat="server" Text="" ForeColor="Red"></asp:Label>
    <br />
    </div>