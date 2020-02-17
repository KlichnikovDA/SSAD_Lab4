using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            SmartThingsGroup SmartHouse = new SmartThingsGroup("Умный дом", "Предоставить единый механизм управления инфраструктурой здания");
            SmartThingsGroup SmartLight = new SmartThingsGroup("Умное освещение", "Автоматизировать освещение здания");
            SmartThingsGroup SmartClimat = new SmartThingsGroup("Умное отопление", "Автоматизировать управление системами отопления здания");
            SmartThingsGroup SmartVideo = new SmartThingsGroup("Система видеонаблюдения", "Осуществлять видеонаблюдение и распознавание");
            SmartThingsGroup SmartCurtains = new SmartThingsGroup("Управление ставнями", "Управлять ставнями в доме в зависимости от освещенности");
            SmartCurtains.Add(new SmartThing("Механизм управления ставнями", "Открывать и закрывать ставни"));
            SmartLight.Add(SmartCurtains);
            SmartLight.Add(new SmartThing("Датчики освещенности", "Получать данные об уровне освещенности на улице"));
            SmartLight.Add(new SmartThing("Механизм управления осветительными приборами", "Включение и выключение осветительных приборов"));
            SmartLight.Add(new SmartThing("Контроллер", "Посылать команды на включение/выключение света и закрытие/открытие ставень в зависимости от показаний датчиков"));
            SmartHouse.Add(SmartLight);
            SmartClimat.Add(new SmartThing("Датчики температуры", "Получать данные о температуре в доме"));
            SmartClimat.Add(new SmartThing("Механизм управления батареями", "Открывать/Перекрывать батареи в доме"));
            SmartClimat.Add(new SmartThing("Контроллер", "Посылать команды на открытие/закрытие батарей в зависимости от показаний датчиков"));
            SmartHouse.Add(SmartClimat);
            SmartVideo.Add(new SmartThing("Видеокамеры", "Осуществлять видеонаблюдение за домом и территорией"));
            SmartVideo.Add(new SmartThing("Модуль распознавания", "Распознавать полученное с видеокамер изображение"));
            SmartHouse.Add(SmartVideo);

            Client SampleClient = new Client(SmartHouse);

            SampleClient.GetHouseInfo();

            Console.ReadLine();
        }
    }
}
