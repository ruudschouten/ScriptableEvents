using System;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class BoolResponse : AbstractEventResponse<bool>
    {
        public BoolEvent Event;
        public UnityEvent Response;
        public ResponseWithBool ResponseWithData;
        
        public override AbstractEvent<bool> GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }

        protected override ResponseWithGeneric<bool> GetResponseWithData()
        {
            return ResponseWithData;
        }
    }
}