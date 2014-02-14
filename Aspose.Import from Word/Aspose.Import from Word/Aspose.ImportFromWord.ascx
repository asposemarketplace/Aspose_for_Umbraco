<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Aspose.ImportFromWord.ascx.cs" Inherits="Import_from_Word.importFromWord" %>
<div id="div_main">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:FileUpload ID="FU_Doc" runat="server" />
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="BTN_Import" runat="server" Text="Import from Word" OnClick="BTN_Import_Click" />
    <br />
<br />
    <b>Below is the desired text Imported from Pdf:<br />
    <br />
    </b>&nbsp;<div id="div_display" runat="server" ></div><br />
    <br />
    <asp:Label ID="LBL_Error" runat="server" Text="" ForeColor="Red"></asp:Label>
    </div>

