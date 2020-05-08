using System;
using System.Collections.Generic;
using System.Text;


namespace CsharpLab4_DI
{/// <summary>
/// Class <c>WebService</c> provides methods and properties 
/// to interact with specified services.
/// </summary>
    public class WebService
    {
        private readonly IWebServiceController _service;
        /// <summary>
        /// Constructor of class <c>WebService</c>, 
        /// establishes connection with specified service.
        /// </summary>
        /// <param name="service">certain service controller IWebServiceController</param>
        public WebService(IWebServiceController service)
        {
                //проверка на Null try catch
                _service = service;
                _service.Connect();
        }
        /*
         WebService
	        - _service : IWebServiceController (readonly)

            ConnectToService()			->Connect

	        OpenMail()					->LogIntoMail
            SearchText				->DoSearch(string)
            SearchImage		-> DoImageSearch
            SearchAddress(string) FindPlace		->FindPlace
            FindRouteTo()			-> BuildRoute()
            OpenStorage		-> ConnectToDrive
            ReadNews		-> OpenNewsFeed
            TranslateText  		-> Translate
            OpenCalendar			-> ShowCalendar
            OpenPlaylist	-> ListenToMusic

                
                    
                
             */
        /// <summary>
        /// Method <c>OpenMail()</c> loads items from user's mailbox.
        /// </summary>
        /// <param name="login">user name or email</param>
        /// <param name="pwd">user password</param>
        /// <returns></returns>
        public bool OpenMail(string login, string pwd) {
            //обработка с помощью try catch
            return _service.LogIntoMail();
        }
        /// <summary>
        /// Method <c>SearchImage()</c> runs an image search.
        /// </summary>
        public void SearchImage(){
            _service.DoImageSearch();
        }
        /// <summary>
        /// Method <c>SearchText()</c> performs text search query.
        /// </summary>
        /// <param name="query">text to find</param>
        public void SearchText(string query) {
            _service.DoSearch(query);
        }
        /// <summary>
        /// Method <c>FindPlace()</c> searches specified place on the map.
        /// </summary>
        /// <param name="address">place to find</param>
        public void FindPlace(string address) {
            _service.ShowMap(address);
        }
        /// <summary>
        /// Method <c>FindRouteTo()</c> builds route between two addresses.
        /// </summary>
        public void FindRouteTo(){
            _service.BuildRoute();
        }
        /// <summary>
        /// Method <c>OpenStorage()</c> provides access to cloud storage.
        /// </summary>
        public void OpenStorage()
        {
            _service.ConnectToDrive();
        }
        /// <summary>
        /// Method <c>ReadNews()</c> retrieves news from service's news feed.
        /// </summary>
        public void ReadNews()
        {
            _service.OpenNewsFeed();
        }
        /// <summary>
        /// Method <c>TranslateText()</c> translates given text to the desired language.
        /// </summary>
        public void TranslateText()
        {
            _service.Translate();
        }
        /// <summary>
        /// Method <c>OpenCalendar()</c> opens online calendar.
        /// </summary>
        public void OpenCalendar()
        {
            _service.ShowCalendar();
        }
        /// <summary>
        /// Method <c>OpenPlaylist()</c> opens random playlist.
        /// </summary>
        public void OpenPlaylist ()
        {
            _service.ListenToMusic();
        }
    }
}
