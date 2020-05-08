using System;
using System.Reflection;
using System.Collections.Generic;
using System.Text;

namespace CsharpLab4_DI
{
    /// <summary>
    /// Class <c>GoogleController</c> provides methods and properties 
    /// to interact with Google Services.
    /// </summary>
    public class GoogleController : IWebServiceController
    {
        bool signedin = false;
        /// <summary>
        /// Default constructor of class <c>GoogleController</c>.
        /// </summary>
        public GoogleController() { }
        /// <summary>
        /// Method <c>Connect()</c> establishes connection with Google Web Platform.
        /// </summary>
        /// <returns>true if connection was established, else returns false</returns>
        public bool Connect()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        /// <summary>
        /// Method <c>DoSearch</c> performs text search using Google search engine.
        /// </summary>
        /// <param name="query">text to find</param>
        public void DoSearch(string query)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ShowMap()</c> allows to view maps in Google Maps service.
        /// </summary>
        /// <param name="address">address to find</param>
        public void ShowMap(string address)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>LogIntoMail()</c> provides access to Gmail service.
        /// </summary>
        /// <returns>True if successfully logged in, else returns false</returns>
        public bool LogIntoMail()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        /// <summary>
        /// Method <c>BuildRoute()</c>  provides access to Google Route Planning service.
        /// </summary>
        public void BuildRoute()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>DoImageSearch()</c> provides tool to search 
        /// by image using Google Images.
        /// </summary>
        public void DoImageSearch()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ConnectToDrive()</c> establishes connection with GoogleDrive.
        /// </summary>
        public void ConnectToDrive()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>OpenNewsFeed()</c> provides access to Google News service
        /// </summary>
        public void OpenNewsFeed()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>Translate()/c>  provides access to Google.Translate.
        /// </summary>
        public void Translate()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ShowCalendar()</c> provides access to GoogleCalendar.
        /// </summary>
        public void ShowCalendar()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ListenToMusic()</c> provides access to Google Youtube Music.
        /// </summary>
        public void ListenToMusic()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
    }

    /// <summary>
    /// Class <c>YandexController</c> provides methods and properties 
    /// to interact with Google Services.
    /// </summary>
    public class YandexController : IWebServiceController
    {
        bool signedin = false;
        /// <summary>
        /// Default constructor of class <c>YandexController</c>.
        /// </summary>
        public YandexController() { }
        /// <summary>
        /// Method <c>Connect()</c> establishes connection with Yandex Web Platform.
        /// </summary>
        /// <returns>True if connection was established, else returns false</returns>
        public bool Connect()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        /// <summary>
        /// Method <c>DoSearch</c> performs text search using Yandex search engine.
        /// </summary>
        /// <param name="query">text to find</param>
        public void DoSearch(string query)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ShowMap()</c> allows to view maps in Yandex Maps service.
        /// </summary>
        /// <param name="address">address to find</param>
        public void ShowMap(string address)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>LogIntoMail()</c> provides access to Yandex.Mail.
        /// </summary>
        /// <returns>true if successfully logged in, else returns false</returns>
        public bool LogIntoMail()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        /// <summary>
        /// Method <c>BuildRoute()</c>  provides access to Yandex Route Planning service.
        /// </summary>
        public void BuildRoute()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        public void DoImageSearch()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ConnectToDrive()</c> establishes connection with YandexDisk.
        /// </summary>
        public void ConnectToDrive()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>OpenNewsFeed()</c> provides access to Yandex News.
        /// </summary>
        public void OpenNewsFeed()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>Translate()/c>  provides access to Yandex.Perevodchik.
        /// </summary>
        public void Translate()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ShowCalendar()</c> provides access to YandexCalendar.
        /// </summary>
        public void ShowCalendar()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ListenToMusic()</c> provides access to music YandexMusic.
        /// </summary>
        public void ListenToMusic()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
    }
    /// <summary>
    /// Class <c>BaiduController</c> provides methods and properties 
    /// to interact with Google Services.
    /// </summary>
    public class BaiduController : IWebServiceController
    {
        bool signedin = false;
        /// <summary>
        /// Default constructor of class <c>BaiduController</c>.
        /// </summary>
        public BaiduController() { }
        /// <summary>
        /// Method <c>Connect()</c> establishes connection with Baidu Web Platform.
        /// </summary>
        /// <returns>true if connection was established, else returns false</returns>
        public bool Connect()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        /// <summary>
        /// Method <c>DoSearch</c> performs text search using Baidu search engine.
        /// </summary>
        /// <param name="query">text to find</param>
        public void DoSearch(string query)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ShowMap()</c> allows to view maps in Baidu Maps service.
        /// </summary>
        /// <param name="address">address to find</param>
        public void ShowMap(string address)
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>LogIntoMail()</c> provides access to Baidu mail service.
        /// </summary>
        /// <returns>true if successfully logged in, else returns false</returns>
        public bool LogIntoMail()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
            return true;
        }
        /// <summary>
        /// Method <c>BuildRoute()</c>  provides access to Baidu Route Planning service.
        /// </summary>
        public void BuildRoute()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>DoImageSearch()</c> provides tool to search 
        /// by image using BaiduImages.
        /// </summary>
        public void DoImageSearch()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ConnectToDrive()</c> establishes connection with BaiduStorage.
        /// </summary>
        public void ConnectToDrive()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>OpenNewsFeed()</c> provides access to Baidu News.
        /// </summary>
        public void OpenNewsFeed()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>Translate()/c>  provides access to Baidu Translation service.
        /// </summary>
        public void Translate()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ShowCalendar()</c> provides access to BaiduCalendar.
        /// </summary>
        public void ShowCalendar()
        {
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
        /// <summary>
        /// Method <c>ListenToMusic()</c> provides access to BaiduMusic.
        /// </summary>
        public void ListenToMusic()
        {
            //if signedin
            Program.Log(this.GetType().Name, MethodBase.GetCurrentMethod().Name);
        }
    }
}
