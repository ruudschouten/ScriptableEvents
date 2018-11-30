using System;
using ScriptableEvents;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class FloatResponse : AbstractEventResponse<float>
    {
        public FloatEvent Event;
        public UnityEvent Response;
        public ResponseWithFloat ResponseWithData;
        
        public override AbstractEvent<float> GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }

        protected override ResponseWithGeneric<float> GetResponseWithData()
        {
            return ResponseWithData;
        }
    }
}