﻿namespace Architecture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Архитектура приложения описывает шаблоны и методы, используемые для проектирования и создания приложения.
            // Архитектура рисует для нас карту, с помощью которой наше приложение приобретает четкую структуру.

            // Архитектуры, основанные на взаимосвязях между сервисами:
            //1 многоуровневая архитектура;
            //2 микросервисы;
            //3 архитектура, управляемая событиями;
            //4 архитектура, ориентированная на службы.



            // МНОГОУРОВНЕВАЯ АРХИТЕКТУРА — это традиционная архитектура, которая часто используется для создания локальных и корпоративных приложений.



            // МИКРОСЕРВИСЫ — это одновременно и архитектура, и подход к написанию программного обеспечения.
            // С помощью микросервисов приложение разбивается на мельчайшие компоненты, независимые друг от друга.
            // Каждый из этих компонентов или процессов представляет собой микросервис.

            // Микросервисы распределены и слабо связаны, поэтому не влияют друг на друга.
            // Это даёт преимущества как для динамической масштабируемости, так и для отказоустойчивости: отдельные сервисы можно масштабировать по мере необходимости,
            // не требуя тяжелой инфраструктуры, или можно переключаться при отказе, не влияя на другие сервисы.

            // Цель использования архитектуры микросервисов — быстрее предоставлять качественное программное обеспечение.
            // Вы можете одновременно разрабатывать несколько микросервисов.
            // А поскольку службы развертываются независимо, вам не нужно перестраивать или повторно развертывать всё приложение при внесении изменений
            // https://github.com/SkillfactoryCoding/dotnetcore-microservices-poc



            // АРХИТЕКТУРА, УПРАВЛЯЕМАЯ СОБЫТИЯМИ (EVENT-DRIVEN ARCHITECTURE, EDA) - основной структурой решения являются захват, передача, обработка и сохранение событий.
            // Это отличается от традиционной модели, основанной на запросах.

            // Под событием здесь понимается любое существенное событие или изменение состояния аппаратного или программного обеспечения системы.
            // Источником события может быть внутренний или внешний вход.

            // EDA обеспечивает минимальную связь, что делает её хорошим вариантом для современных распределенных архитектур приложений.
            // Производитель событий обнаруживает или воспринимает событие, и представляет событие как сообщение.
            // После обнаружения события оно передается от производителя потребителям событий по каналам событий,
            // где платформа обработки событий обрабатывает событие асинхронно.

            // Модель pub/sub основана на подписках на поток событий.
            // После того как событие происходит или публикуется, оно отправляется подписчикам, которых необходимо проинформировать.



            // СЕРВИС-ОРИЕНТИРОВАННАЯ АРХИТЕКТУРА (SERVICE-ORIENTED ARCHITECTURE, SOA) - это устоявшийся стиль проектирования программного обеспечения,
            // который похож на стиль архитектуры микросервисов. SOA структурирует приложения в дискретные повторно используемые сервисы,
            // которые обмениваются данными через служебную шину предприятия (ESB).

            // В этой архитектуре отдельные службы, каждая из которых организована вокруг определенного бизнес-процесса,
            // придерживаются протокола связи (например, SOAP, ActiveMQ или Apache Thrift) и проявляют себя через платформу ESB.
            // В совокупности этот набор услуг, интегрированный через ESB, используется интерфейсным приложением для обеспечения ценности для бизнеса или клиента.
        }
    }
}
