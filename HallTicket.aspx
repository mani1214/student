<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="HallTicket.aspx.cs" Inherits="WebApplication22.HallTicket" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 50%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <table align="center" class="auto-style2">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>HallTicket</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Button" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ResultDBConnectionString %>" SelectCommand="SELECT * FROM [Student_dt] WHERE ([Hallticket] = @Hallticket)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextBox1" Name="Hallticket" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
                <td>
                    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="Hallticket" DataSourceID="SqlDataSource1">
                        <Columns>
                            <asp:BoundField DataField="StudentName" HeaderText="StudentName" SortExpression="StudentName" />
                            <asp:BoundField DataField="Total" HeaderText="Total" SortExpression="Total" />
                            <asp:BoundField DataField="Hallticket" HeaderText="Hallticket" ReadOnly="True" SortExpression="Hallticket" />
                            <asp:BoundField DataField="Subject1" HeaderText="Subject1" SortExpression="Subject1" />
                            <asp:BoundField DataField="Subject2" HeaderText="Subject2" SortExpression="Subject2" />
                            <asp:BoundField DataField="Result" HeaderText="Result" SortExpression="Result" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
        </table>
    <br />
</p>
<p>
</p>
<p>
</p>
<p>
</p>
</asp:Content>
