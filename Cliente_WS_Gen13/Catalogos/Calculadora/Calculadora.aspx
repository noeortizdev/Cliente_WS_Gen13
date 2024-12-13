<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="Cliente_WS_Gen13.Catalogos.Calculadora.Calculadora" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="container">
        <%-- Campos de Texto --%>
        <div class="col-4">
            <asp:Label ID="lblA" runat="server" Text="Número 1"></asp:Label>
            <asp:TextBox ID="txtA" runat="server" TextMode="Number"></asp:TextBox>
        </div>
        <br />
        <div class="col-4">
            <asp:Label ID="lblB" runat="server" Text="Número 2"></asp:Label>
            <asp:TextBox ID="txtB" runat="server" TextMode="Number"></asp:TextBox>
        </div>
    </div>
    <div class="row text-center">
        <%-- Botones --%>
        <asp:Button ID="btnSumar" runat="server" Text="+" OnClick="btnSumar_Click" CssClass="m-5 col" />
        <asp:Button ID="btnRestar" runat="server" Text="-" OnClick="btnRestar_Click" CssClass="m-5 col" />
        <asp:Button ID="btnMultiplicar" runat="server" Text="*" OnClick="btnMultiplicar_Click" CssClass="m-5 col" />
        <asp:Button ID="btnDividir" runat="server" Text="/" OnClick="btnDividir_Click" CssClass="m-5 col" />
    </div>

    <div class="row">
        <div class="text-center">
            <h2>
                <%-- Resultado --%>
                <asp:Label ID="lblResultado" runat="server" Text=""></asp:Label>
            </h2>
        </div>
    </div>
</asp:Content>
