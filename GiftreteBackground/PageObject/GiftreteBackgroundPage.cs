using GiftreteBackground.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace GiftreteBackground.PageObject
{
    class GiftreteBackgroundPage
    {
       
        public GiftreteBackgroundPage()
        {
            driver = Hooks1.driver;
            // Implicit Wait
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        IWebDriver driver;

        IWebElement enterEmail => driver.FindElement(By.XPath("//*[@id='user_email']"));
        IWebElement enterPassword => driver.FindElement(By.XPath("//*[@id='user_password']"));
        IWebElement rememberMeBox => driver.FindElement(By.XPath("//*[@id='store_session']"));
        IWebElement clickOnSignIn => driver.FindElement(By.XPath("//*[@id='btn_signin']"));
        IWebElement clickOnPostItem => driver.FindElement(By.XPath("//li[@class='mr--5']"));
        IWebElement enterItemName => driver.FindElement(By.XPath("//input[@name='title']"));
        IWebElement itemDescription => driver.FindElement(By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr']"));
        IWebElement clickOnItemCategory => driver.FindElement(By.XPath("//select[@name='categoryone']"));
        IWebElement selectGame => driver.FindElement(By.XPath("(//select[@class='form__input form__input--3 slt'])[1]"));
        IWebElement clickOnItemType => driver.FindElement(By.XPath("//*[@id='type']"));
        IWebElement selectItemType => driver.FindElement(By.XPath("//select[@id='type']"));
        IWebElement enterWeight => driver.FindElement(By.XPath("//*[@id='weight']"));
        IWebElement enterLocation => driver.FindElement(By.XPath("//*[@id='autocomplete']"));
        IWebElement chooseFile => driver.FindElement(By.XPath("//input[@type='file']"));
        IWebElement itemImages => driver.FindElement(By.XPath("//*[@id='uploadProduct']/div[7]/label"));
        IWebElement addItem => driver.FindElement(By.XPath("//*[@id='btn_create']"));
        IWebElement isNameDisplayed => driver.FindElement(By.XPath("//span[contains(text(),'doug ian')]"));
        IWebElement clickOnPostedItems => driver.FindElement(By.XPath("//a[@class='nav-link font-weight-400 font-size-15']"));
        IWebElement myPostedItems => driver.FindElement(By.XPath("//a[text()='My Posted Item']"));







        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void EnterEmail(string yogi)
        {
            enterEmail.SendKeys(yogi);
        }

        public void EnterPassword(string woo)
        {
            enterPassword.SendKeys(woo);
        }

        public void RememberMeBox()
        {
            rememberMeBox.Click();
        }

        public void ClickOnAddItem()
        {
            addItem.Click();
        }

        public void ClickOnSignIn()
        {
            clickOnSignIn.Click();
        }

        public void ClickOnPostItem()
        {
            Thread.Sleep(5000);
            clickOnPostItem.Click();
        }

        public void EnterItemName(string dog)
        {
            enterItemName.SendKeys(dog);
        }

        public void EnterItemDescription(string dog)
        {
           
            Thread.Sleep(5000);
            driver.SwitchTo().Frame(driver.FindElement(By.XPath("//*[@id='cke_1_contents']/iframe")));
            IWebElement itemDescription = driver.FindElement(By.XPath("//body[@class='cke_editable cke_editable_themed cke_contents_ltr']"));
            Thread.Sleep(5000);
            itemDescription.SendKeys(dog);
            driver.SwitchTo().DefaultContent();
        }

        public void ItemImages()
        {
            itemImages.Click();
        }

        public void uploadFile()
        {
            Thread.Sleep(5000);
            driver.FindElement(By.XPath("//*[@id='files']")).SendKeys(@"C:\Users\terry&spike\Desktop\download.jpg");  
        }

        public void ClickOnItemCategory()
        {
            clickOnItemCategory.Click();
        }

        public void ClickOnItemType()
        {
            clickOnItemType.Click();
        }

        public void SelectGame()
        {
            SelectElement select = new SelectElement(selectGame);
            select.SelectByValue("1");
        }

        public void SelectItemType()
        {
            Thread.Sleep(5000);
            SelectElement select = new SelectElement(selectItemType);
            select.SelectByValue("Wanted");
        }

        public void EnterWeight()
        {
            enterWeight.SendKeys("30");
        }

        public void IEnterMyLocation(string boo)
        {
            enterLocation.SendKeys(boo);
        }

        public bool IsPageDisplayed()
        {
            return isNameDisplayed.Displayed;
        }

        public void PostedItems()
        {
            Thread.Sleep(4000);
            clickOnPostedItems.Click();
        }

        public void ClickMyPostedItems()
        {
            Thread.Sleep(4000);
            myPostedItems.Click();
        }

        public bool IsMyPostedItemsDisplayed()
        {
            return myPostedItems.Displayed;
        }
















    }
}
