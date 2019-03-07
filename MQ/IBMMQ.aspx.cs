using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using IBM.WMQ;
using System.Configuration;
using System.Collections;

namespace MQ
{
    //IBMmq中已经创建了两个队列管理器此处使用Imbmq1作为发送方端口1414
    //需要引入的dll是amqmdnet.dll
    public partial class IBMMQ : System.Web.UI.Page
    {
        //定义消息字段
        public string message = "default";

        protected void Page_Load(object sender, EventArgs e)
        {
         
        }

        //返回
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Default.aspx");
        }

        //开始发送消息
        protected void Button2_Click(object sender, EventArgs e)
        {
            message = TextBox1.Text.Trim();

            MQMessage mMsg;
            MQPutMessageOptions mqPutMsgOpts;
           
            
            //主机
            string hostname = ConfigurationManager.AppSettings["HostName"];
            //端口
            int port = Convert.ToInt32(ConfigurationManager.AppSettings["Port"]);
            //队列管理器名
            string qmName = ConfigurationManager.AppSettings["QueueManager"];
            //Response.Write(qmName);
            //队列名
            string queueName = ConfigurationManager.AppSettings["Queue"];
            //远程通道
            string Channel = ConfigurationManager.AppSettings["Channel"];

            string CCSID = "1381"; // 表示是简体中文，
                                   // CCSID的值在AIX上一般设为1383，如果要支持GBK则设为1386，在WIN上设为1381。       

            try
            {
                MQEnvironment.Hostname = hostname;
                MQEnvironment.Port = port;
               // MQEnvironment.Channel = Channel;
                MQEnvironment.Channel = "SYSTEM.DEF.SVRCONN";


                Environment.SetEnvironmentVariable("MQCCSID", CCSID);
                if (MQEnvironment.properties.Count <= 0)
                {
                    MQEnvironment.properties.Add(MQC.CCSID_PROPERTY, 1381);
                }
             

                //创建队列管理器对象                                                    
              MQQueueManager qMgr = new MQQueueManager(qmName);


                // 设置希望打开的选项
               // int openOptions = MQC.MQOO_OUTPUT | MQC.MQOO_INPUT_SHARED | MQC.MQOO_INQUIRE;
                int openOptions = MQC.MQOO_OUTPUT + MQC.MQOO_FAIL_IF_QUIESCING;

              //创建队列对象
                MQQueue qQueue = qMgr.AccessQueue(queueName, openOptions, null,null,null);



                Response.Write("连接队列管理器成功！");

                /*
                    //发送消息
                    MQMessage messages = new MQMessage();
                    messages.WriteString(message);
                    qQueue.Put(messages);
              */
                //最终关闭队列和管理器
              //  qQueue.Close();
                qMgr.Disconnect();



            }

            catch (MQException ex)
            {
                Response.Write("连接队列管理器失败CompletionCode和ReasonCode为：" + ex.CompletionCode + " : " + ex.ReasonCode);
            }

            catch (Exception ex)
            {
                Response.Write("连接队列管理器失败2：" + ex.Message);

            }


        }




    }


}

