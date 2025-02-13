using Patterns_3_BehavioralP.ChainOfResposibility.ChainOfResposibilityRealExample;
using Patterns_3_BehavioralP.Observer.ObserverRealExample.Observers;
using Patterns_3_BehavioralP.Observer.ObserverRealExample;
using Patterns_3_BehavioralP.State.StateRealExample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns_3_BehavioralP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ПОВЕДЕНЧЕСКИЕ ПАТТЕРНЫ - обеспечивают эффективное и безопасное взаимодействие между объектами программы. В них, как правило, определяются алгоритмы взаимодействия.

            /*------------------------------------------------------------------------------------------------------------------------------*/
            // ЦЕПОЧКА ОБЯЗАННОСТЕЙ (CHAIN OF RESPOSIBILITY) - позволяет избежать жесткой привязки отправителя запроса к получателю

            Receiver receiver = new Receiver(false, true, true); // получатель выставил варианты уведомления

            NotificationHandler emailNotificationHandler = new EmailNotificationHandler();
            NotificationHandler voiceNotificationHandler = new VoiceNotificationHandler();
            NotificationHandler smsNotificationHandler = new SmsNotificationHandler();

            emailNotificationHandler.Successor = smsNotificationHandler;
            smsNotificationHandler.Successor = voiceNotificationHandler;

            emailNotificationHandler.Handle(receiver);

            /*------------------------------------------------------------------------------------------------------------------------------*/
            // СОСТОЯНИЕ (STATE) - наши объекты получают возможность менять своё поведение в зависимости от внутреннего состояния.

            // инициализируем лифт (находится на земле)
            Elevator elevator = new Elevator(new GroundElevatorState());

            elevator.Up(); // подъем наверх
            elevator.Down(); // спуск на землю
            elevator.Down(); // спуск в подвал

            // Мы вынесли поведение, зависящее от текущего состояния объекта, в отдельные классы (соответствующие нужному состоянию).
            // Если бы мы этого не делали, наши основные методы были бы перегружены условиями, if-else и так далее.
            // В систему можно легко вводить новые состояния при необходимости, также как и использовать уже имеющиеся в других объектах. 

            /*------------------------------------------------------------------------------------------------------------------------------*/
            // НАБЛЮДАТЕЛЬ (OBSERVER) - множество объектов могут быть потребителями информации из одного источника (наблюдателями).
            // При изменении наблюдаемого объекта автоматически происходит оповещение всех наблюдателей.
            
            Stock stock = new Stock();

            var bank = new Bank(stock);
            var broker = new Broker(stock);

            // имитация торгов
            stock.Market();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            stock.Market();

            // Stock реализует интерфейс IObservable (наблюдаемый объект) — валютная биржа, за которой все следят.
            // В Stock реализован метод Market() — он представляет сессию торгов, и внутри него вся информация о курсах заключена в объекте StockData.
            // После торговой сессии происходит уведомление наблюдателей.
            // Наблюдатели(Broker, Bank) реализуют интерфейс IObserver, метод Update() которого принимает некоторый объект(в данном случае StockData) в виде параметра.
            // В Broker также есть дополнительный метод StopTrade(), который позволяет отписаться от уведомлений и перестать быть наблюдателем.

            // Push-модель - когда существует некий канал для публикации событий (или шина событий), к которой подключены (или подписаны) потребители информации. (это вариант)
            // Pull-модель - наблюдатели сами опрашивают источник получения информации. В нашей ситуации эта система представляется менее эффективной

            /*------------------------------------------------------------------------------------------------------------------------------*/
        }
    }
}
