using System;
using System.Reflection;
/*
Напишите часть программы, которая позволяет работать 
с веб-сервисами компании,выбираемой пользователем. 
Программа должна состоять из трёх классов-контроллеров 
для веб-сервисов компаний (Google, Yandex и Baidu) и 
класса, в который данные сервисы встраиваются. 
    Класс ServiceController

    Класс Client
    На вход конструктору подается ServiceController с параметрами
    Методы для работы со следующими службами:
    карты, поисковая система, почта 

     */


namespace CsharpLab4_DI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             На вход программе подаётся 
                строка с названием компании 
                список команд (работа с веб-сервисами). 
            Возможные команды:
                search
                map
                mail
             */
            WebService service = null;
            //проверка c помощью исключений?
            if (args.Length > 0)
            {
                if (args[0].ToString().ToLower() == "google")
                {
                    service = new WebService(new GoogleController());
                }
                else if (args[0].ToString() == "yandex")
                {
                    service = new WebService(new YandexController());
                }
                else if (args[0].ToString() == "baidu")
                {
                    service = new WebService(new BaiduController());
                }
                else
                    Console.WriteLine("Wrong service name");
            }
            if (service != null) { }
            
            //tESTING CODE
            IWebServiceController service0 = new GoogleController();
            service0.Connect();
            //service0.SignIn(null, null);
            service0.CheckMailBox();
            Console.WriteLine("\n");

            service = new WebService(new GoogleController());
            service.DoSearch("Text to search");
            service.ShowMap("Some address");
            service.SignInToService("login", "pwd");
            service.CheckMailBox();
            service.SendMail("Some text", "email");
        }
        public static void Log(string className, string methodName)
        {
            Console.WriteLine("Method  " + methodName 
                + "()  of  class  " + className + "  was  called");
        }
    }
}
