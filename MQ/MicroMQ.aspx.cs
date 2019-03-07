using System;
using System.Collections.Generic;
using System.Linq;
using System.Messaging;//net 自带的程序集
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MQ
{
    public partial class MicroMQ : System.Web.UI.Page
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
            string message = this.TextBox1.Text;

         

            // 创建一个私有消息队列
            if (!MessageQueue.Exists(@".\Private$\testMsmq"))
            {
                try
                {

                    using (MessageQueue mq = MessageQueue.Create(@".\Private$\testMsmq"))
                    {
                        Message msg = new Message();
                        //内容
                       msg.Body = message;
                        //指定格式化程序
                      msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                        mq.Send(msg);

                        mq.Close();
                        mq.Dispose();
                    }

                    Response.Write("发送消息成功！");
                }
                catch (Exception ex)
                {
                    Response.Write("发送消息失败" + ex.Message);
                }


            }
            else
            {
                try
                {
                    using (MessageQueue mq = new MessageQueue(@".\Private$\testMsmq"))
                    {
                        Message msg = new Message();
                        //内容
                        msg.Body = message;
                        //指定格式化程序
                        msg.Formatter = new XmlMessageFormatter(new Type[] { typeof(string) });
                        mq.Send(msg);

                        //清空消息队列
                       // mq.Purge();
                        mq.Close();
                        mq.Dispose();
                    }
                    Response.Write("发送消息成功！");
                }
                catch (Exception ex)
                {
                    Response.Write("发送消息失败" + ex.Message);
                }

            }


        }
    }
}