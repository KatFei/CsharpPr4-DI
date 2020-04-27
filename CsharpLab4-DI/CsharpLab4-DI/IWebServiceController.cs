using System;
using System.Collections.Generic;
using System.Text;


namespace CsharpLab4_DI
{
    /// <summary>
    /// Documentation that describes the interface goes here.
    /// </summary>
    public interface IWebServiceController
    {
        bool Connect();
        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        bool LogIntoMail();

        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        void BuildRoute();

        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        /// <param name="n">
        /// Parameter n requires an integer argument.
        /// </param>
        void DoImageSearch();

        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        /// <param name="n">
        /// Parameter n requires an integer argument.
        /// </param>
        void DoSearch(string query);

        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        /// <param name="n">
        /// Parameter n requires an integer argument.
        /// </param>
        void ShowMap(string address);
        void ConnectToDrive();
        void OpenNewsFeed();
        void Translate();
        void ShowCalendar();
        void ListenToMusic();
    }
    
}
