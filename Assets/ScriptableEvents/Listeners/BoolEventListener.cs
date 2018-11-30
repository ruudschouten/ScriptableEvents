using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;

namespace ScriptableEvents.Listeners
{
    public class BoolEventListener : AbstractEventListener<bool>
    {
        public List<BoolResponse> Responses;
        
        public override List<AbstractEventResponse<bool>> GetResponse()
        {
            return new List<AbstractEventResponse<bool>>(Responses);
        }
    }
}