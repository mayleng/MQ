<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RabbitMq.aspx.cs" Inherits="MQ.RabbitMq" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            RabbitMQ安装在Windows server2012r2上
        </div>
        <p>
            RabbitMQ.Client3.5.0</p>
        <p>
            在server2012r2上输入 http://localhost:15672/ 默认用户名：guest 密码：guest 可以进入web页面的rabbitmq中。</p>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" Height="99px" Width="194px"></asp:TextBox>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="发送消息" />
        </p>
        <p>
            &nbsp;</p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
    </form>
</body>
</html>
