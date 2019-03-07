<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MicroMQ.aspx.cs" Inherits="MQ.MicroMQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            MicrosoftMQ安装在Windows server2012 r2上的。<br />
            <br />
            队列路径给的是当前路径，所以只能在安装有MSMQ的系统上使用该程序。<br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="37px" Width="174px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="发送消息" />
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" style="height: 21px" Text="返回" Width="64px" />
        </div>
    </form>
</body>
</html>
