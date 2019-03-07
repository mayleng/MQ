<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="IBMMQ.aspx.cs" Inherits="MQ.IBMMQ" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            IBM WebSphereMQ安装在Windows server2008r2上。         
             
            <br />
            <br />
            <span style="color: rgb(51, 51, 51); font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 14px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: start; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">引用amqmdnet.dll&nbsp;
            <span style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; font-family: &quot;Times New Roman&quot;;">imqc23vn.dll</span><span style="color: rgb(0, 0, 0); font-family: Verdana, Arial, Helvetica, sans-serif; font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; display: inline !important; float: none;">，</span><span style="margin: 0px; padding: 0px; color: rgb(0, 0, 0); font-size: 15px; font-style: normal; font-variant-ligatures: normal; font-variant-caps: normal; font-weight: 400; letter-spacing: normal; orphans: 2; text-align: left; text-indent: 0px; text-transform: none; white-space: normal; widows: 2; word-spacing: 0px; -webkit-text-stroke-width: 0px; background-color: rgb(255, 255, 255); text-decoration-style: initial; text-decoration-color: initial; font-family: &quot;Times New Roman&quot;;">mqic32.dll</span>（在客户端的安装目录下可以找到)安装iBM 
            MQ d的系统中找到该文件</span><br />
            <br />
            <br />
            <asp:TextBox ID="TextBox1" runat="server" Height="32px" Width="153px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="开始发送消息" />
            <br />
            <br />
            <br />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="返回" />
    </form>
</body>
</html>
