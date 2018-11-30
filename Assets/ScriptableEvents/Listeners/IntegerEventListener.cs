using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;

namespace ScriptableEvents.Listeners
{
    public class IntegerEventListener : AbstractEventListener<int>
    {
        public List<IntegerResponse> Responses = new List<IntegerResponse>();
        
        public override List<AbstractEventResponse<int>> GetResponse()
        {
            return new List<AbstractEventResponse<int>>(Responses);
        }
    }
}