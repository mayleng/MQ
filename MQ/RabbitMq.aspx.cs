using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MQ
{
    public partial class RabbitMq : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        
        //返回
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        //发送消息
        protected void Button2_Click(object sender, EventArgs e)
        {
            string message = this.TextBox1.Text.Trim();

            //send

            ConnectionFactory factory = new ConnectionFactory();
            factory.HostName = "localhost";
            factory.Port = AmqpTcpEndpoint.UseDefaultPort;       
            factory.UserName = "guest";
            factory.Password = "guest";
            factory.Protocol = Protocols.DefaultProtocol;         
             //factory.RequestedHeartbeat = 60;

            try
            {

                using (var connection = factory.CreateConnection())
                {
                    using (IModel channel = connection.CreateModel())
                    {
                        //创建一个名称为good的消息队列
                        channel.QueueDeclare(queue: "good",
                                             durable: false,
                                             exclusive: false,
                                             autoDelete: false,
                                             arguments: null);

                        
                        var body = Encoding.UTF8.GetBytes(message);               
                        channel.BasicPublish(exchange: "",
                                             routingKey: "good",
                                             basicProperties: null,
                                             body: body);                     
                    }
                }

                Response.Write("发送消息成功！");
            }
            catch (Exception ex)
            {
                Response.Write("发送消息失败："+ex.Message);
            }
        }
    }
}