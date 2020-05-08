using System;
using System.Collections.Generic;
using System.Text;


namespace CsharpLab4_DI
{
    /// <summary>
    /// Interface <c></c> .
    /// </summary>
    public interface IWebServiceController
    {
        /// <summary>
        /// Method <c>Connect()</c> establishes connection with specified Web platform.
        /// </summary>
        bool Connect();
        /// <summary>
        /// Method <c>LogIntoMail()</c> provides access to Email service.
        /// </summary>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        bool LogIntoMail();

        /// <summary>
        /// Method <c>BuildRoute()</c>  provides access to Route Planning service..
        /// </summary>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        void BuildRoute();

        /// <summary>
        /// Method <c>DoImageSearch()</c> provides tool to search by image.
        /// </summary>

        void DoImageSearch();

        /// <summary>
        /// Method <c>DoSearch</c> provides access to text search engine. 
        /// </summary>
        /// <param name="query">Parameter <c>query</c> requires an string argument.</param>
        void DoSearch(string query);

        /// <summary>
        /// Method <c>ShowMap()</c> provides access to Web Map service.
        /// </summary>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        void ShowMap(string address);
        /// <summary>
        /// Method <c>ConnectToDrive()</c> establishes connection with 
        /// cloud storage service of certain platform.
        /// </summary>
        void ConnectToDrive();
        /// <summary>
        /// Method <c>OpenNewsFeed()</c> provides access to news feed.
        /// </summary>
        void OpenNewsFeed();
        ///<summary>
        ///Method <c>Translate()/c>  provides access to Translation service.
        ///</summary>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        /// <param name="">Parameter <c></c> requires an string argument.</param>
        void Translate();

        /// <summary>
        /// Method <c>ShowCalendar()</c> provides access to online calendar
        /// </summary>
        void ShowCalendar();
        /// <summary>
        /// Method <c>ListenToMusic()</c> provides access to music streaming service.
        /// </summary>
        void ListenToMusic();
    }
    
}
