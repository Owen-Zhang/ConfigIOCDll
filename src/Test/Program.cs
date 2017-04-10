using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Test
{
    public enum TestEnum { 
        First = 'f',
        Sencond = 'd',
        Third = 't'
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region 
            /*
            XElement root =  new XElement("Query");
            root.Add(new XElement("test2", 1), new XElement("test3", 2));
            root.AddFirst(ToXElement("TestRoot", "test", new List<string> { "1", "2" }));
            //Console.WriteLine(ToChildXml("Pare", new List<string> { "1", "2"}));
            Console.WriteLine(root.ToString());
            Console.WriteLine(DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss.fffZ"));


            var url = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "1\\1.txt");
            Console.WriteLine(url);
             */
            #endregion

            #region google api
            /*
            // add new 
            var path = System.IO.Path.Combine(System.AppDomain.CurrentDomain.BaseDirectory, "Certificate\\Google Merchant Account-100888315.p12");
            var certificate = new X509Certificate2(path, "notasecret", X509KeyStorageFlags.Exportable);
            ServiceAccountCredential credential = new ServiceAccountCredential(
               new ServiceAccountCredential.Initializer("11930790790-umbre00h1g85da5q4u7839pfsivutd84@developer.gserviceaccount.com")
               {
                   Scopes = new[] { ContentService.Scope.Content }
               }.FromCertificate(certificate));
            ContentService _serviceForUsa = new ContentService(new BaseClientService.Initializer
            {
                ApplicationName = "Google Merchant Account",
                HttpClientInitializer = credential
            });

            var account = new Account {
                 AdultContent = false,
                 Name = "fayetest-in0917",
                 ReviewsUrl = "http://www.newegg.com/fayetest-in0917",
                 SellerId = "D07J",
                 WebsiteUrl = "http://www.newegg.com"
            };
            try
            {
                var createdAccount = _serviceForUsa.Accounts.Insert(account, 100888315).Execute();
            }
            catch (GoogleApiException ex)
            {
                var message = ex.Message;
            }
             * */
            #endregion

            #region 日志处理
            /*
            Newegg.FrameworkAPI.SDK.Log.LogHelper.WriteLog(new Newegg.Framework.Tools.Log.LogEntry
            {
                GlobalName = "MKTPLS",
                LocalName = "RestAPI",
                CategoryName = "Item",
                Content = "test one"
            });
            List<string> OrderNumberList = new List<string>{"01245"};
            var result = string.Format("SONumber:('{0}')", string.Join("' OR '", OrderNumberList));
            Console.WriteLine(result);
             * */
            #endregion

            #region 集合的比较操作
            /*
            var listAll = new List<Country> { 
                new Country {
                    CountryName = "A1-A",
                    CountryCharCode = "A1",
                    CountryCode = "A1",
                    ContientName = "A1-Name",
                    FlagImageCode = "A1-Code"
                },
                new Country {
                    CountryName = "A2-A",
                    CountryCharCode = "A2",
                    CountryCode = "A2",
                    ContientName = "A2-Name",
                    FlagImageCode = "A2-Code"
                },
                new Country {
                    CountryName = "A3-A",
                    CountryCharCode = "A3",
                    CountryCode = "A3",
                    ContientName = "A3-Name",
                    FlagImageCode = "A3-Code"
                },
                new Country {
                    CountryName = "A4-A",
                    CountryCharCode = "A4",
                    CountryCode = "A4",
                    ContientName = "A4-Name",
                    FlagImageCode = "A4-Code"
                }
            };

            var listPar = new List<Country> { 
                new Country {
                    CountryCharCode = "A4",
                    CountryCode = "A4"
                },
                new Country {
                    CountryCharCode = "A2"
                }
            };

            var result2 = listAll.Intersect(listPar, new CountryComparer()).ToList();

            Console.WriteLine(result2.Count());*/
            #endregion

            #region 获取IP和机器名
            /*
            NE.MPS.Framework.Logging.Logger.PortalLog(new NE.MPS.Framework.Logging.PortalLogEntry { 
                 
            });*/


            /*
            Console.WriteLine(System.Environment.MachineName);
            Console.WriteLine(System.Net.Dns.GetHostName());
            var result =  System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList[1].ToString();
            var test = System.Net.Dns.GetHostEntry("sdfasd");
            //Console.WriteLine(System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName()).AddressList.First());
            Console.WriteLine(System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName()).First());
            Console.WriteLine(System.Net.Dns.Resolve(System.Net.Dns.GetHostName()).AddressList.First());
            */

            #endregion

            TestEnum? en = TestEnum.Third;
            var result = en ?? TestEnum.First;

            for (var i = 0; i < 20; i++ )
            {
                System.Threading.Thread.Sleep(1000);
                new TestChild.Class1().PortalConosle("Test");
            }

            Console.ReadLine();
        }

        private static string ToChildXml(string child, IEnumerable<string> data)
        {
            string result = string.Empty;
            if (data != null)
            {
                var temp = new StringBuilder();
                foreach (var item in data)
                    temp.Append(new XElement(child, item.Trim()).ToString());

                result = temp.ToString();
            }

            return result;
        }

        private static string ToXml(string root, string child, IEnumerable<string> data)
        {
            XElement rootX = new XElement(root);
            if (data != null)
            {
                foreach (var item in data)
                {
                    rootX.Add(new XElement(child, item));
                }
            }

            return rootX.ToString();
        }

        private static XElement ToXElement(string root, string child, IEnumerable<string> data)
        {
            XElement rootX = new XElement(root);
            if (data != null)
            {
                foreach (var item in data)
                {
                    rootX.Add(new XElement(child, item));
                }
            }

            return rootX;
        }

        private static string SplitWithChar(decimal total)
        {
            //ToString("#,##0.00") 这样也可以达到那样的效果

            var result = string.Empty;

            if (total == 0) return "0";
            result = total.ToString().Trim();
            int subIndex = result.IndexOf('-');
            string prefix = string.Empty;
            if (subIndex == 0)
            {
                result = result.Substring(1);
                prefix = "-";
            }

            int pointIndex = result.IndexOf('.');
            string pointData = string.Empty;
            if (pointIndex > 0)
            {
                var temp = result;
                result = temp.Substring(0, pointIndex);
                pointData = temp.Substring(pointIndex);
            }

            int splitCount = (result.Length - 1) / 3;
            int splitLeft = result.Length % 3;
            int splitStart = splitLeft == 0 ? 3 : splitLeft;

            StringBuilder positiveStr = new StringBuilder(result);
            for (int i = 1; i <= splitCount; i++)
            {
                positiveStr.Insert(splitStart + 3 * (splitCount - i), ",");
            }

            if (!string.IsNullOrEmpty(pointData))
                positiveStr.Append(pointData);

            if (!string.IsNullOrEmpty(prefix))
                positiveStr.Insert(0, prefix);

            return positiveStr.ToString();
        }
    }
}
