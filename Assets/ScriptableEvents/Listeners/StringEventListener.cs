using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;

namespace ScriptableEvents.Listeners
{
    public class StringEventListener : AbstractEventListener<string>
    {
        public List<StringResponse> Responses = new List<StringResponse>();

        public override List<AbstractEventResponse<string>> GetResponse()
        {
            return new List<AbstractEventResponse<string>>(Responses);
        }
    }
}