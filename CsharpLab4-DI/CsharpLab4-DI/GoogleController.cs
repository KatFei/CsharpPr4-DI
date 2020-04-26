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
        public bool SignIn(string login, string pwd)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void CheckMailBox()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void SendMail(string msg, string email)
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
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
        public bool SignIn(string login, string pwd)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void CheckMailBox()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void SendMail(string msg, string email)
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
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
        public bool SignIn(string login, string pwd)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        public void CheckMailBox()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void SendMail(string msg, string email)
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
    }
}
