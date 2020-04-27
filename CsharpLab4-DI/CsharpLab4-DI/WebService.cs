using System;
using System.Collections.Generic;
using System.Text;


namespace CsharpLab4_DI
{
    public class WebService
    {
        private readonly IWebServiceController _service;
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
        public bool OpenMail(string login, string pwd) {
            //обработка с помощью try catch
            return _service.LogIntoMail();
        }
        public void SearchImage(){
            _service.DoImageSearch();
        }
        public void SearchText(string query) {
            _service.DoSearch(query);
        }
        public void FindPlace(string address) {
            _service.ShowMap(address);
        }
        public void FindRouteTo(){
            _service.BuildRoute();
        }
        public void OpenStorage()
        {
            _service.ConnectToDrive();
        }
        public void ReadNews()
        {
            _service.OpenNewsFeed();
        }
        public void TranslateText()
        {
            _service.Translate();
        }
        public void OpenCalendar()
        {
            _service.ShowCalendar();
        }
        public void OpenPlaylist ()
        {
            _service.ListenToMusic();
        }
    }
}
