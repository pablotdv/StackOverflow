<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChamarFuncaoPassandoCampo._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="grid-1-3 margin-txt">
        <asp:Label ID="Label5" runat="server" Text="Tipo de Pessoa:"></asp:Label>
        <asp:DropDownList ID="ddlIDType" runat="server" CssClass="form-control">
            <asp:ListItem Value="P">Física</asp:ListItem>
            <asp:ListItem Value="L">Jurídica</asp:ListItem>
        </asp:DropDownList>
    </div>
    <div class="grid-1-3  margin-txt">
        <asp:Label ID="Label4" runat="server" Text="CPF ou CNPJ"></asp:Label>
        <asp:TextBox ID="txtCpf" runat="server" CssClass="form-control" placeholder="CPF ou CNPJ" required="required"></asp:TextBox>
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            $("[id$='ddlIDType']").on('change', function () {
                $("#txtCpf").mask("999.999.999-99");
                if ($(this).val() == 'P') {
                    document.getElementById('txtCpf').style.display = '';
                    $("#txtCpf").mask("999.999.999-99");
                } else {
                    document.getElementById('txtCpf').style.display = '';

                    $("#txtCpf").mask("99.999.999/9999-99");
                }
            })
        });
    </script>
</asp:Content>
