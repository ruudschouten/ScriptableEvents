using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;

namespace ScriptableEvents.Listeners
{
    public class GameEventListener : AbstractEventListener
    {
        public List<GameResponse> Responses = new List<GameResponse>();

        public override List<AbstractEventResponse> GetResponse()
        {
            return new List<AbstractEventResponse>(Responses);
        }
    }
}