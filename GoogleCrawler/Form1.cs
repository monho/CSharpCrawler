using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Web;
using System.Threading;
using System.Threading.Tasks;

namespace GoogleCrawler
{
    public partial class Form1 : Form
    {
        IWebDriver driver;
        ChromeDriverService service;
        ChromeOptions option;
        ArrayList searchArray = new ArrayList();
        ArrayList videoArray = new ArrayList();
        ArrayList searchArray2 = new ArrayList();
        ArrayList videoArray2 = new ArrayList();
        //Thread Search1 = null;
        public Form1()
        {
            InitializeComponent();
            service = ChromeDriverService.CreateDefaultService();
            service.HideCommandPromptWindow = true;
            option = new ChromeOptions();
            option.AddArguments("headless");

            Search_Btn.Click += Search_Btn_Click;
            Search_Tbx.KeyDown += Search_Tbx_KeyDown;
        }

        private void Search_Btn_Click(object sender, EventArgs e)
        {

            Search_Lbx.Items.Clear();
            Video_Lbx.Items.Clear();

            searchArray.Clear();
            videoArray.Clear();
            searchArray2.Clear();
            videoArray2.Clear();

            Thread Search_1 = new Thread(Search1);
            Thread Search_2 = new Thread(Search2);



            Search_1.Start();
            Search_2.Start();


        }

        private void Search1()
        {
            if (Search_Tbx.Text == "") return;
            using (driver = new ChromeDriver(service, option))
            {
                this.Invoke(new Action(delegate ()
                {

                    string encode = HttpUtility.UrlEncode(Search_Tbx.Text);
                    string googleEncode = "";
                    if (Option1_Rbn.Checked) googleEncode = HttpUtility.UrlEncode(Search_Tbx.Text);
                    else if (Option2_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("intitle:" + Search_Tbx.Text);
                    else if (Option3_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("intext:" + Search_Tbx.Text);
                    else if (Option4_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("filetype:" + Search_Tbx.Text);
                    else if (Option5_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("\"" + Search_Tbx.Text + "\"");

                    // 구글 통합
                    try
                    {
                        int index = 0;
                        driver.Url = "https://www.google.co.kr/search?q=" + googleEncode;
                        List<IWebElement> elements = driver.FindElement(By.Id("search")).FindElements(By.ClassName("g")).ToList();
                        foreach (IWebElement x in elements)
                        {
                            Search_Lbx.Items.Add(x.Text);
                            searchArray.Add(x.FindElement(By.ClassName("r")).FindElement(By.TagName("a")).GetAttribute("href"));
                            index++;
                        }
                        driver.FindElement(By.XPath("//*[@id=\"xjs\"]/div/table/tbody/tr/td[3]/a")).Click();
                        elements = driver.FindElement(By.Id("search")).FindElements(By.ClassName("g")).ToList();
                        foreach (IWebElement x in elements)
                        {
                            Search_Lbx.Items.Add(x.Text);
                            searchArray.Add(x.FindElement(By.ClassName("r")).FindElement(By.TagName("a")).GetAttribute("href"));
                            index++;
                        }
                    }
                    catch { }

                    // 구글 동영상
                    try
                    {
                        int index = 0;
                        driver.Url = "https://www.google.co.kr/search?q=" + googleEncode + "&hl=ko&tbm=vid";
                        List<IWebElement> elements1 = driver.FindElement(By.Id("search")).FindElements(By.ClassName("g")).ToList();
                        foreach (IWebElement x in elements1)
                        {
                            Video_Lbx.Items.Add(x.Text);
                            videoArray.Add(x.FindElement(By.ClassName("r")).FindElement(By.TagName("a")).GetAttribute("href"));
                            index++;
                        }
                    }
                    catch { }

                }));

              

            }
        }


        private void Search2()
        {
            if (Search_Tbx.Text == "") return;
            using (driver = new ChromeDriver(service, option))
            {
                this.Invoke(new Action(delegate ()
                {

                    string encode = HttpUtility.UrlEncode(Search_Tbx.Text);
                    string googleEncode = "";
                    if (Option1_Rbn.Checked) googleEncode = HttpUtility.UrlEncode(Search_Tbx.Text);
                    else if (Option2_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("intitle:" + Search_Tbx.Text);
                    else if (Option3_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("intext:" + Search_Tbx.Text);
                    else if (Option4_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("filetype:" + Search_Tbx.Text);
                    else if (Option5_Rbn.Checked) googleEncode = HttpUtility.UrlEncode("\"" + Search_Tbx.Text + "\"");

                   

                    // 구글 동영상
                    try
                    {
                        int index = 0;
                        driver.Url = "https://www.google.co.kr/search?q=" + googleEncode + "&hl=ko&tbm=vid";
                        List<IWebElement> elements1 = driver.FindElement(By.Id("search")).FindElements(By.ClassName("g")).ToList();
                        foreach (IWebElement x in elements1)
                        {
                            Video_Lbx.Items.Add(x.Text);
                            videoArray.Add(x.FindElement(By.ClassName("r")).FindElement(By.TagName("a")).GetAttribute("href"));
                            index++;
                        }
                    }
                    catch { }

                }));

            }
    
        }

        private void Search_Lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { BrowserStart(Search_Lbx.SelectedIndex, 1); }
            catch { }
        }
        private void Video_Lbx_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { BrowserStart(Video_Lbx.SelectedIndex, 2); }
            catch { }
        }


        private async void BrowserStart(int index, int mode)
        {
            try
            {
                using (driver = new ChromeDriver(service))
                {
                    if (mode == 1) driver.Url = searchArray[index].ToString();
                    else if (mode == 2) driver.Url = videoArray[index].ToString();
                    else if (mode == 3) driver.Url = searchArray2[index].ToString();
                    else if (mode == 4) driver.Url = videoArray2[index].ToString();
                    await Task.Delay(60000);
                }
            }
            catch { }
        }

        private void Search_Tbx_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                Search_Btn_Click(sender, e);
            }
        }
    }
}
