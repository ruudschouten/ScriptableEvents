using System;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class IntegerResponse : AbstractEventResponse<int>
    {
        public IntegerEvent Event;
        public UnityEvent Response;
        public ResponseWithInteger ResponseWithData;
        
        public override AbstractEvent<int> GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }

        protected override ResponseWithGeneric<int> GetResponseWithData()
        {
            return ResponseWithData;
        }
    }
}