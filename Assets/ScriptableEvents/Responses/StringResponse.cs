using System;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class StringResponse : AbstractEventResponse<string>
    {
        public StringEvent Event;
        public UnityEvent Response;
        public ResponseWithString ResponseWithData;

        public override AbstractEvent<string> GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }

        protected override ResponseWithGeneric<string> GetResponseWithData()
        {
            return ResponseWithData;
        }
    }
}