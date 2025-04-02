using Entities.Communication.Common;

namespace Entities.Communication.ServerToCharger
{
    public class GetTokensRequest : SocketRequest
    {
        public List<string>? TokensIds { get; set; }

    }


}