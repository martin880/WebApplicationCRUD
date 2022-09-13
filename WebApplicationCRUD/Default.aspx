<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplicationCRUD._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div style="margin-bottom: 43px">
        <div style ="font-size:x-large" align ="center">Student Info Manage Form</div>
        <br />

        <table class="nav-justified">
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 212px">Student ID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="195px"></asp:TextBox>
                     &nbsp
                    <asp:Button ID="Button5" runat="server" Font-Bold="True" ForeColor="#3333FF" OnClick="Button5_Click" Text="Get" />
                </td>
            </tr>
            <tr>
                <td style="width: 164px; height: 22px;"></td>
                <td style="width: 212px; height: 22px;">Student Name</td>
                <td style="height: 22px">
                    <asp:TextBox ID="TextBox2" runat="server" Width="195px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 212px">Address</td>
                <td>
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>Batuaji</asp:ListItem>
                        <asp:ListItem>Batam Center</asp:ListItem>
                        <asp:ListItem>Bengkong</asp:ListItem>
                        <asp:ListItem>Tj.Piayu</asp:ListItem>
                        <asp:ListItem>Marina</asp:ListItem>
                        <asp:ListItem>Nongsa</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 212px">Age</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Width="195px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 164px">&nbsp;</td>
                <td style="width: 212px">Contact</td>
                <td>
                    <asp:TextBox ID="TextBox4" runat="server" Width="195px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 62px; width: 164px"></td>
                <td style="width: 212px; height: 62px"></td>
                <td style="height: 62px">
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" ForeColor="#00CC00" OnClick="Button1_Click" Text="Insert" />
                    &nbsp
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" ForeColor="#FF9900" OnClick="Button2_Click" Text="Update" />
                     &nbsp
                    <asp:Button ID="Button3" runat="server" Font-Bold="True" ForeColor="Red" OnClick="Button3_Click" OnClientClick="return confirm('Apa kamu yakin akan menghapus data ini??')" Text="Delete" />
                    &nbsp
                    <asp:Button ID="Button4" runat="server" Font-Bold="True" ForeColor="#3333FF" OnClick="Button4_Click" Text="Search" />
                    &nbsp
                    <asp:Button ID="Button6" runat="server" Font-Bold="True" ForeColor="#3333FF" OnClick="Button6_Click" Text="Clear" />
                </td>
            </tr>
            <tr>
                <td style="height: 62px; width: 164px">&nbsp;</td>
                <td style="width: 212px; height: 62px">&nbsp;</td>
                <td style="height: 62px">
                    <asp:GridView ID="GridView1" runat="server" Width="601px">
                    </asp:GridView>
                </td>
            </tr>
        </table>

    </div>

</asp:Content>
