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
            public bool SignInToService(string login, string pwd) {
                //обработка с помощью try catch
                return _service.SignIn(login, pwd);
            }
            public void CheckMailBox() {
                _service.CheckMailBox();
            }
            public void SendMail(string msg, string email){
                _service.SendMail(msg, email);
            }
            public void DoSearch(string query) {
                _service.DoSearch(query);
            }
            public void ShowMap(string address) {
            _service.ShowMap(address);
        }
    }
}
