using System;

namespace Alkl.DeviceHub.Common
{
    public abstract class StateChangedEventArgs<T> : EventArgs
    {
        public T PreviousState { get; }

        public T CurrentState { get; }

        protected StateChangedEventArgs(T previousState, T currentState)
        {
            PreviousState = previousState;
            CurrentState = currentState;
        }
    }
}
