using System;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Events;
using UnityEngine;
using UnityEngine.Events;

namespace ScriptableEvents.Responses
{
    [Serializable]
    public class GameObjectResponse : AbstractEventResponse<GameObject>
    {
        public GameObjectEvent Event;
        public UnityEvent Response;
        public ResponseWithGameObject ResponseWithData;
    
        public override AbstractEvent<GameObject> GetEvent()
        {
            return Event;
        }

        protected override UnityEvent GetResponse()
        {
            return Response;
        }

        protected override ResponseWithGeneric<GameObject> GetResponseWithData()
        {
            return ResponseWithData;
        }
    }
}