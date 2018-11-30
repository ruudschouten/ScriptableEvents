using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using UnityEngine;

namespace ScriptableEvents.Abstracts
{
    public abstract class AbstractEventListener<T> : MonoBehaviour
    {
        public abstract List<AbstractEventResponse<T>> GetResponse();
    
        public void OnEventRaised(AbstractEvent<T> passedEvent)
        {
            for (var i = GetResponse().Count - 1; i >= 0; i--)
            {
                if (passedEvent == GetResponse()[i].GetEvent())
                {
                    GetResponse()[i].EventRaised();
                }
            }
        }

        private void OnEnable()
        {
            if (GetResponse().Count < 1) return;
            foreach (var response in GetResponse())
            {
                response.GetEvent().Register(this);
            }
        }

        private void OnDisable()
        {
            if (GetResponse().Count < 1) return;
            foreach (var response in GetResponse())
            {
                response.GetEvent().DeRegister(this);
            }
        }
    }

    public abstract class AbstractEventListener : MonoBehaviour
    {
        public abstract List<AbstractEventResponse> GetResponse();

        public void OnEventRaised(AbstractEvent passedEvent)
        {
            for (var i = GetResponse().Count - 1; i >= 0; i--)
            {
                if (passedEvent == GetResponse()[i].GetEvent())
                {
                    GetResponse()[i].EventRaised();
                }
            }
        }
        
        private void OnEnable()
        {
            if (GetResponse().Count < 1) return;
            foreach (var response in GetResponse())
            {
                response.GetEvent().Register(this);
            }
        }

        private void OnDisable()
        {
            if (GetResponse().Count < 1) return;
            foreach (var response in GetResponse())
            {
                response.GetEvent().DeRegister(this);
            }
        }
    }
}