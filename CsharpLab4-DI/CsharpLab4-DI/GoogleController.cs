using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace CsharpLab4_DI
{
    public class GoogleController : IWebServiceController
    {
        bool signedin = false;
        public bool Connect() {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void DoSearch(string query) {
            //check string
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void ShowMap(string address) {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public bool LogIntoMail()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void BuildRoute()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void DoImageSearch()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        public void ConnectToDrive()
        {
            throw new NotImplementedException();
        }

        public void OpenNewsFeed()
        {
            throw new NotImplementedException();
        }

        public void Translate()
        {
            throw new NotImplementedException();
        }

        public void ShowCalendar()
        {
            throw new NotImplementedException();
        }

        public void ListenToMusic()
        {
            throw new NotImplementedException();
        }
    }

    /// <summary>
    /// YandexController
    /// </summary>
    public class YandexController : IWebServiceController
    {
        bool signedin = false;
        public bool Connect()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void DoSearch(string query)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void ShowMap(string address)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public bool LogIntoMail()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void BuildRoute()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void DoImageSearch()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        public void ConnectToDrive()
        {
            throw new NotImplementedException();
        }

        public void OpenNewsFeed()
        {
            throw new NotImplementedException();
        }

        public void Translate()
        {
            throw new NotImplementedException();
        }

        public void ShowCalendar()
        {
            throw new NotImplementedException();
        }

        public void ListenToMusic()
        {
            throw new NotImplementedException();
        }
    }
    /// <summary>
    /// Class BaiduController 
    /// </summary>
    public class BaiduController : IWebServiceController
    {
        bool signedin = false;
        //нужен ли конструктор по умолчанию?
        public BaiduController() { }
        public bool Connect()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void DoSearch(string query)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void ShowMap(string address)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public bool LogIntoMail()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void BuildRoute()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void DoImageSearch()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }

        public void ConnectToDrive()
        {
            throw new NotImplementedException();
        }

        public void OpenNewsFeed()
        {
            throw new NotImplementedException();
        }

        public void Translate()
        {
            throw new NotImplementedException();
        }

        public void ShowCalendar()
        {
            throw new NotImplementedException();
        }

        public void ListenToMusic()
        {
            throw new NotImplementedException();
        }
    }
}
