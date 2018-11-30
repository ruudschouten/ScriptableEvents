using System;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class GameResponse : AbstractEventResponse
    {
        public GameEvent Event;
        public UnityEvent Response;
        
        public override AbstractEvent GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }
    }
}