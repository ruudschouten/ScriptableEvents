using System.Collections.Generic;
using ScriptableEvents.Abstracts;
using ScriptableEvents.Responses;
using ScriptableEvents.Responses;

namespace ScriptableEvents.Listeners
{
    public class FloatEventListener : AbstractEventListener<float>
    {
        public List<FloatResponse> Responses = new List<FloatResponse>();
        
        public override List<AbstractEventResponse<float>> GetResponse()
        {
            return new List<AbstractEventResponse<float>>(Responses);
        }
    }
}