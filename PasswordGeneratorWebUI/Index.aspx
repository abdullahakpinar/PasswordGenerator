<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="PasswordGeneratorWebUI.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Şifre Üretici</title>
    <link href="Content/css/style.css" rel="stylesheet" />
</head>
<body>
    <div class="login-box">
        <form id="formPasswordGenerator" runat="server">
            <div class="user-box">
                <asp:TextBox ID="txtMinLength" runat="server" Text="4" onkeypress="return isNumber(this,event);" OnTextChanged="TxtMinLength_TextChanged"></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ID="regexMin"
                    ControlToValidate="txtMinLength" ValidationExpression="^\d+$" EnableClientScript="true" 
                    ErrorMessage="Sadece Sayı Giriniz..." Display="Dynamic" SetFocusOnError="True" />
                <label>En Az Karakter Sayısı</label>
            </div>
            <div class="user-box">
                <asp:TextBox ID="txtMaxLength" runat="server" Text="10" onkeypress="return isNumber(this,event);" OnTextChanged="TxtMaxLength_TextChanged" ></asp:TextBox>
                <asp:RegularExpressionValidator runat="server" ID="regexMax"
                    ControlToValidate="txtMaxLength" ValidationExpression="^\d+$" EnableClientScript="true" 
                    ErrorMessage="Sadece Sayı Giriniz..." Display="Dynamic" SetFocusOnError="True" />
                <label>En Fazla Karakter Sayısı</label>
            </div>
            <table>
                <tr>
                    <td>
                        <div class="user-box">
                            <br />
                            <asp:CheckBox ID="chkUpperChars" runat="server" Text="Büyük Harf" Checked="true" />
                        </div>
                    </td>
                    <td>
                        <div class="user-box">
                            <br />
                            <asp:CheckBox ID="chkLowerChars" runat="server" Text="Küçük Harf" Checked="true" />
                        </div>
                    </td>
                </tr>
                <tr>
                    <td>
                        <div class="user-box">
                            <br />
                            <asp:CheckBox ID="chkNumberChars" runat="server" Text="Sayı" Checked="true" />
                        </div>
                    </td>
                    <td>
                        <div class="user-box">
                            <br />
                            <asp:CheckBox ID="chkSpecialChars" runat="server" Text="Özel Karakter" Checked="true" />
                        </div>
                    </td>
                </tr>
            </table>
            <div class="user-box">
                <asp:TextBox ID="txtAllowChars" runat="server" ToolTip="Olması İstenen Karakterler"></asp:TextBox>
                <label>Olması İstenen Karakterler</label>
            </div>
            <div class="user-box">
                <asp:TextBox ID="txtDenyChars" runat="server" ToolTip="Olması İstenmeyen Karakterler"></asp:TextBox>
                <label>Olmaması İstenen Karakterler</label>
            </div>
            <a>
                <span></span>
                <span></span>
                <asp:Button ID="btnPasswordGenerate" runat="server" Text="Şifre Üretme" OnClick="BtnPasswordGenerate_Click" CssClass="btn" UseSubmitBehavior="false"/>
                <span></span>
                <span></span>
            </a>
            <div class="user-box">
                <asp:TextBox ID="txtGeneratedPassword" runat="server"></asp:TextBox>
            </div>
        </form>
    </div>
</body>
 
</html>
<script>
    function isNumber(e, t) {
        var n;
        var r;
        if (navigator.appName == "Microsoft Internet Explorer" || navigator.appName == "Netscape") {
            n = t.keyCode;
            r = 1;
            if (navigator.appName == "Netscape") {
                n = t.charCode;
                r = 0
            }
        } else {
            n = t.charCode;
            r = 0
        }
        if (r == 1) {
            if (!(n >= 48 && n <= 57 || n == 46)) {
                t.returnValue = false
            }
        } else {
            if (!(n >= 48 && n <= 57 || n == 0 || n == 46)) {
                t.preventDefault()
            }
        }
    }
</script>
