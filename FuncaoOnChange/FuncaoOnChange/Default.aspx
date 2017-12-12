<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FuncaoOnChange._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="grid-1-3  margin-txt">
        <asp:Label ID="Label4" runat="server" Text="CPF ou CNPJ"></asp:Label>
        <asp:TextBox ID="txtEmail" runat="server" CssClass="form-control" placeholder="Email" required="required"></asp:TextBox>
        <asp:Button ID="btnValidaEmail" runat="server" Text="Button" Style="display: none" OnClick="btnValidaEmail_Click" />
    </div>

    <script type="text/javascript">
        $(document).ready(function () {
            function validateEmail(emailField) {
                var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;

                if (reg.test(emailField) == false) {
                    alert('Email inválido.');
                    emailField.value = '';
                    return false;
                }
                $("[id$='btnValidaEmail']").click();
                return true;

            }

            $("[id$='txtEmail']").on('change', function () {
                validateEmail($(this).val());
            })
        });
    </script>

</asp:Content>
