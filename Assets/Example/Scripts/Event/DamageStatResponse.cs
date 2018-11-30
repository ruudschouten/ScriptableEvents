using System;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class DamageStatResponse : AbstractEventResponse<DamageStat>
    {
        public DamageStatEvent Event;
        public UnityEvent Response;
        public ResponseWithDamageStat ResponseWithData;

        public override AbstractEvent<DamageStat> GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }

        protected override ResponseWithGeneric<DamageStat> GetResponseWithData()
        {
            return ResponseWithData;
        }
    }
}