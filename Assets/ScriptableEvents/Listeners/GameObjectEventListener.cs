using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;
using UnityEngine;

namespace ScriptableEvents.Listeners
{
    public class GameObjectEventListener : AbstractEventListener<GameObject>
    {
        public List<GameObjectResponse> Responses = new List<GameObjectResponse>();

        public override List<AbstractEventResponse<GameObject>> GetResponse()
        {
            return new List<AbstractEventResponse<GameObject>>(Responses);
        }
    }
}