using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace ClassLibrary5
{
    [Binding]
    public class Dodostep
    {
        FirefoxDriver driver;
        [Given(@"Я нахожусь на странице с анкетой")]
        public void ДопустимЯНахожусьНаСтраницеСАнкетой()
        {
            driver = new FirefoxDriver
            {
                Url = "http://rabotavdodo.ru/"
            };
            driver.FindElement(By.XPath("//button[@onclick=\"GoToForm();yaCounter36223035.reachGoal('ClickButtonWantToWork');return true;\"]")).Click();
        }

        [Given(@"я ввел нужный мне город")]
        public void ДопустимЯВвелНужныйМнеГород()
        {
            new SelectElement(driver.FindElement(By.Name("localityId"))).SelectByText("Москва");
            
        }

        [Given(@"ввел своё имя и фамилию")]
        public void ДопустимВвелСвоёИмяИФамилию()
        {
            driver.FindElement(By.Id("name_01")).SendKeys("Иванов");
            driver.FindElement(By.Id("name_02")).SendKeys("Иван");
        }

        [Given(@"ввел год рождения")]
        public void ДопустимВвелГодРождения()
        {
            new SelectElement(driver.FindElement(By.Id("birthday_day"))).SelectByText("19");
            new SelectElement(driver.FindElement(By.Id("birthday_month"))).SelectByText("Сентябрь");
            new SelectElement(driver.FindElement(By.Id("birthday_year"))).SelectByText("1991");
        }

        [Given(@"ввел адрес")]
        public void ДопустимВвелАдрес()
        {
            driver.FindElement(By.Id("address")).SendKeys("г.Москва, ул. Ленина, дом 123, кв.4.");
        }

        [Given(@"ввел телефон")]
        public void ДопустимВвелТелефон()
        {
            driver.FindElement(By.Id("phonenumber")).SendKeys("+7 (912) 345-67-89");
        }

        [Given(@"ввел где хочу работать")]
        public void ДопустимВвелГдеХочуРаботать()
        {
            driver.FindElement(By.Id("unit_293")).Click();
        }

        [Given(@"ввел кем хочу работать")]
        public void ДопустимВвелКемХочуРаботать()
        {
            driver.FindElement(By.Id("position_325")).Click();
        }

        [Given(@"ввел когда удобно выходить на смену")]
        public void ДопустимВвелКогдаУдобноВыходитьНаСмену()
        {
            driver.FindElement(By.Id("worktime_02")).Click();
        }

        [Given(@"ввел как узнал о вакансии")]
        public void ДопустимВвелКакУзналОВакансии()
        {
            new SelectElement(driver.FindElement(By.Id("applicantSource"))).SelectByText("Соцсети (vkontakte, facebook)");
        }

        [Given(@"поставил галочку на соглашении")]
        public void ДопустимПоставилГалочкуНаСоглашении()
        {
            driver.FindElement(By.Name("Oferta")).Click();
        }

        [Then(@"заявка будет отправленна")]
        public void ТоЗаявкаБудетОтправленна()
        {
            driver.FindElement(By.Id("send")).Click();
        }
    }
}
