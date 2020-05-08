using System;
using System.Reflection;
/*
Напишите часть программы, которая позволяет работать 
с веб-сервисами компании,выбираемой пользователем. 
Программа должна состоять из трёх классов-контроллеров 
для веб-сервисов компаний (Google, Yandex и Baidu) и 
класса, в который данные сервисы встраиваются. 
    Класс ServiceController
    Класс WebService
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
                строка с названием компании google{g} | yandex{y} | baidu{b}
                список команд (работа с веб-сервисами). 
            Возможные команды:
                email {e}       drive {d}
                search {s}      news {n}
                image {i}       translator {t}
                map {m}         calendar {c}
                route {r}       playmusic {p}
             */
            
            string[] argsChoices = { "email", "search", "image", "map", "route", "drive", 
                "news", "translator", "calendar", "playmusic" };
            WebService service = null;
            try
            {
                if (args[0].ToString().ToLower().StartsWith("g"))
                {
                    service = new WebService(new GoogleController());
                }
                else if (args[0].ToString().ToLower().StartsWith("y"))
                {
                    service = new WebService(new YandexController());
                }
                else if (args[0].ToString().ToLower().StartsWith("b"))
                {
                    service = new WebService(new BaiduController());
                }
                else
                    Console.WriteLine("Wrong service name");
            }
            catch
            {
                Console.WriteLine("Fail to read parameters from console");
                //для тестирования
                service = new WebService(new GoogleController());
                args = new string[] { "google", "search", "image", "route", "music" };
            }
            if (service != null) {
                foreach (string arg in args) {
                    Console.WriteLine(arg[0].ToString().ToLower());
                    switch (arg[0].ToString().ToLower()) {
                        case "e":
                            service.OpenMail("login", "pwd");
                            break;
                        case "s": 
                            service.SearchText("Text to search");
                            break;
                        case "i":
                            service.SearchImage();
                            break;
                        case "m":
                            service.FindPlace("Some address");
                            break;
                        case "r":
                            service.FindRouteTo();
                            break;
                        case "d":
                            service.OpenStorage();
                            break;
                        case "n": 
                            service.ReadNews();
                            break;
                        case "t":
                            service.TranslateText();
                            break;
                        case "c":
                            service.OpenCalendar();
                            break;
                        case "p":
                            service.OpenPlaylist();
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        public static void Log(string className, string methodName)
        {
            Console.WriteLine(className + "." + methodName 
                + "()   was  called");
            /*
            Console.WriteLine("Method  " + methodName 
                + "()  of  class  " + className + "  was  called");
             */
        }
    }
}
