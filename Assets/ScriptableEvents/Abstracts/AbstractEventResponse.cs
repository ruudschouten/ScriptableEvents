using System;
using ScriptableEvents.Abstracts;
using UnityEngine.Events;

namespace ScriptableEvents.Abstracts
{
    [Serializable]
    public abstract class AbstractEventResponse<T>
    {
        public string name;

        public abstract AbstractEvent<T> GetEvent();

        protected abstract UnityEvent GetResponse();
        protected abstract ResponseWithGeneric<T> GetResponseWithData();

        public void EventRaised()
        {
            if (GetResponse().GetPersistentEventCount() >= 0)
            {
                GetResponse().Invoke();
            }

            if (GetResponseWithData().GetPersistentEventCount() >= 0)
            {
                GetResponseWithData().Invoke(GetEvent().Sent);
            }
        }
    }

    public abstract class AbstractEventResponse
    {
        public string name;
        public abstract AbstractEvent GetEvent();
        protected abstract UnityEvent GetResponse();

        public void EventRaised()
        {
            if (GetResponse().GetPersistentEventCount() >= 0)
            {
                GetResponse().Invoke();
            }
        }
    }
}