namespace Patterns_3_BehavioralP.State.StateRealExample
{
    /// <summary>
    /// Объект Лифт, которому доступны три состояния
    /// </summary>
    class Elevator
    {
        /// Хранилище состояния
        public IElevatorState ElevatorState
        {
            get;
            set;
        }

        public Elevator(IElevatorState elevatorState)
        {
            ElevatorState = elevatorState;
        }

        // Подъем
        public void Up()
        {
            ElevatorState.Up(this);
        }

        // Спуск
        public void Down()
        {
            ElevatorState.Down(this);
        }
    }
}