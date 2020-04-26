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
        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        /// <param name="n">
        /// Parameter n requires an integer argument.
        /// </param>
        /// <returns>
        /// The method returns an integer.
        /// </returns>
        bool SignIn(string login, string pwd);

        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        void CheckMailBox();

        /// <summary>
        /// Documentation that describes the method goes here.
        /// </summary>
        /// <param name="n">
        /// Parameter n requires an integer argument.
        /// </param>
        void SendMail(string msg, string email);

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

        bool Connect();
    }
    
}
