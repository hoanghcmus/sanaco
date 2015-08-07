<%@ Page Title="" Language="C#" MasterPageFile="~/View/MasterPage.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="View_Default" %>

<%@ Register Src="~/UserControls/UC_ProductListOne.ascx" TagPrefix="uc1" TagName="UC_ProductListOne" %>
<%@ Register Src="~/UserControls/UC_Quang_Cao.ascx" TagPrefix="uc1" TagName="UC_Quang_Cao" %>



<asp:Content ID="Header" ContentPlaceHolderID="HeadExtender" runat="Server">
</asp:Content>
<asp:Content ID="Body" ContentPlaceHolderID="MainContent" runat="Server">

    <uc1:UC_ProductListOne runat="server" ID="FirstProductCatList" />

    <div class="ad-wrapper">
        <uc1:UC_Quang_Cao runat="server" ID="QuangCao1" />
        <uc1:UC_Quang_Cao runat="server" ID="QuangCao2" />
    </div>

    <uc1:UC_ProductListOne runat="server" ID="SecondProductCatList" />

    <div class="ad-wrapper">
        <uc1:UC_Quang_Cao runat="server" ID="QuangCao3" />
        <uc1:UC_Quang_Cao runat="server" ID="QuangCao4" />
    </div>

    <uc1:UC_ProductListOne runat="server" ID="ThreeProductCatList" />

    <div class="ad-wrapper">
    </div>

</asp:Content>
<asp:Content ID="Footer" ContentPlaceHolderID="FootExtender" runat="Server">
</asp:Content>

