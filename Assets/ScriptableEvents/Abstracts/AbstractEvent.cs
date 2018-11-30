using System.Collections.Generic;

namespace ScriptableEvents.Abstracts
{
    public abstract class AbstractEvent<T> : GenericEvent
    {
        public T Sent;

        private List<AbstractEventListener<T>> _listeners = new List<AbstractEventListener<T>>();

        public override void Raise()
        {
            for (var i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised(this);
            }
        }
    
        public void Register(AbstractEventListener<T> passedEvent)
        {
            if (!_listeners.Contains(passedEvent))
            {
                _listeners.Add(passedEvent);
            }
        }

        public void DeRegister(AbstractEventListener<T> passedEvent)
        {
            if (_listeners.Contains(passedEvent))
            {
                _listeners.Remove(passedEvent);
            }
        }
    }

    public abstract class AbstractEvent : GenericEvent
    {
        private List<AbstractEventListener> _listeners = new List<AbstractEventListener>();
        
        public override void Raise()
        {
            for (var i = _listeners.Count - 1; i >= 0; i--)
            {
                _listeners[i].OnEventRaised(this);
            }
        }
    
        public void Register(AbstractEventListener passedEvent)
        {
            if (!_listeners.Contains(passedEvent))
            {
                _listeners.Add(passedEvent);
            }
        }

        public void DeRegister(AbstractEventListener passedEvent)
        {
            if (_listeners.Contains(passedEvent))
            {
                _listeners.Remove(passedEvent);
            }
        }
    }
}