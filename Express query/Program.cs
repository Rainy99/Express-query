using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Express_query
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======================  快递查询系统  ======================");
            string yto = "圆通速递";//定义变量，储存快递公司名称
            string sf = "顺丰速运";
            string yd = "韵达快运";
            string ems = "EMS快递";
            Console.WriteLine("1.{0}\t2.{1}\t3.{2}\t4.{3}",yto,sf,yd,ems);//列出所有快递公司名称供用户进行选择
            Console.WriteLine("=====================   输入查询信息  ======================");
            string rechoose = "0";//定义变量，初始化用户重新选择的值
            string rechoose2 = "0";//定义变量，初始化用户第二次选择的值
            do//使用do-while循环实现询问用户是否重新选择快递公司，如果用户选择y则执行循环，如选择n则跳出当前循环，进行下一步操作
            {
                Console.WriteLine("请选择快递公司（输入序号）：");
                int choose = int.Parse(Console.ReadLine());//定义变量储存用户输入的序号
                switch (choose)//使用switch循环判断用户输入的序号，根据不同的序号，显示出用户所选择的快递公司
                    {
                            case 1:
                                Console.WriteLine("您选择的快递公司是：{0}",yto);
                            break;

                            case 2:
                                Console.WriteLine("您选择的快递公司是：{0}",sf);
                            break;

                            case 3:
                                Console.WriteLine("您选择的快递公司是：{0}",yd);
                            break;

                            case 4:
                                Console.WriteLine("您选择的快递公司是：{0}",ems);
                            break;

							default:
								Console.WriteLine("您输入的快递公司不存在");
							break;
                    }
                Console.WriteLine("您是否要重新选择？(y/n)");
                rechoose = Console.ReadLine();//储存用户重新选择的值
            }while (rechoose == "y");

            do//使用do-while循环询问用户在输入快递单号错误的情况下是否重新输入，选y则继续执行循环，选n则跳出当前循环，执行下一步
            {
                Console.WriteLine("请输入您的快递单号：");
                long num = long.Parse(Console.ReadLine());//储存用户输入的快递单号
                if (num == 9313480076)//使用if条件语句判断用户输入的快递单号是否有误
				{
                    Thread.Sleep(1000);//线程休眠1秒
					Console.WriteLine("======================  快递单查询结果  ======================");
					string[] date = new string[7];//定义数组，用于储存日期
					date[0] = "2014-05-27";
					date[1] = "2014-05-27";
					date[2] = "2014-05-27";
					date[3] = "2014-05-27";
					date[4] = "2014-05-27";
					date[5] = "2014-05-27";
					date[6] = "2014-05-27";

					string[] time = new string[7];//定义数组，用于储存时间
					time[0] = "15:29:45";
					time[1] = "09:54:23";
					time[2] = "09:13:53";
					time[3] = "07:30:18";
					time[4] = "02:55:37";
					time[5] = "02:39:45";
					time[6] = "02:05:04";

					string[] place = new string[7];//定义数组，用于储存地点
					place[0] = "广东省佛山市顺德区杏坛公司";
					place[1] = "广东省佛山市顺德区杏坛公司";
					place[2] = "广东省佛山市顺德区杏坛公司";
					place[3] = "广东省 佛山市 顺德区  公司";
					place[4] = "广东省 佛山市 高明区  公司 ";
					place[5] = "广东省 佛山市 顺德区  公司";
					place[6] = "广东省 佛山市 高明区  公司";

					string[] state = new string[7];//定义数组，用于储存快递包裹状态
					state[0] = "已签收";
					state[1] = "派件中";
					state[2] = "已收入";
					state[3] = "已发出";
					state[4] = "已打包";
					state[5] = "已收入";
					state[6] = "已收件";

                    Console.WriteLine();
					for (int i = 0; i < date.Length && i < time.Length && i < place.Length && i < state.Length; i++)
					{
						Console.WriteLine("处理时间：{0}\t{1}\t{2}\t{3}",date[1],time[i],place[i],state[i]);
					}
					break;
				}
                else if (num == 1234567890)
                {
                    Thread.Sleep(1000);//线程休眠1秒
                    Console.WriteLine("======================  快递单查询结果  ======================");
                    string[] date1 = new string[7];//定义数组，用于储存日期
                    date1[0] = "2015-02-05 ";
                    date1[1] = "2015-02-05 ";
                    date1[2] = "2015-02-04";
                    date1[3] = "2015-02-02 ";
                    date1[4] = "2015-02-02";
                    date1[5] = "2015-02-02";
                    date1[6] = "2015-02-02";

                    string[] time1 = new string[7];//定义数组，用于储存时间
                    time1[0] = "17:39:33";
                    time1[1] = "18:07:38";
                    time1[2] = "23:01:14";
                    time1[3] = "23:06:19";
                    time1[4] = "20:48:50";
                    time1[5] = "09:31:10";
                    time1[6] = "13:00:03";

                    string[] place1 = new string[7];//定义数组，用于储存地点
                    place1[0] = "在湖北英山县公司进行签收扫描";
                    place1[1] = "到达目的地网点湖北英山县公司";
                    place1[2] = "快件到达湖北武汉分拨中心    ";
                    place1[3] = "在北京张家湾分拨点进行装车扫描";
                    place1[4] = "在河北唐山公司进行装车扫描";
                    place1[5] = "在河北唐山公司进行揽件扫描";
                    place1[6] = "在河北唐山公司唐百分部进行扫描";

                    string[] state1 = new string[7];//定义数组，用于储存快递包裹状态
                    state1[0] = "已签收";
                    state1[1] = "派件中";
                    state1[2] = "已收入";
                    state1[3] = "已发出";
                    state1[4] = "已打包";
                    state1[5] = "已收入";
                    state1[6] = "已收件";

                    Console.WriteLine();
                    for (int i = 0; i < date1.Length && i < time1.Length && i < place1.Length && i < state1.Length; i++)
                    {
                        Console.WriteLine("处理时间：{0}\t{1}\t{2}\t{3}", date1[1], time1[i], place1[i], state1[i]);
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("您输入的快递单号有误，系统查询不到此记录，是否重新输入？(y/n)");
                    rechoose2 = Console.ReadLine();//储存用户第二次选择的值
                }
				
            }while(rechoose2 == "y");
        }
    }
}
