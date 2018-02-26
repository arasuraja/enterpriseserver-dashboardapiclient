using Syncfusion.Server.ApiClient.V1.EndPoints;

namespace Syncfusion.Server.ApiClient.V1
{
    public sealed class ServerClientV1 : ServerApiClient
    {
        public ServerClientV1()
        {
            BaseUrl = BaseUrl + "/api/v1.0";
        }

        public UsersEndPoint UsersEndPoint()
        {
            return new UsersEndPoint(this);
        }

        public GroupsEndPoint GroupsEndPoint()
        {
            return new GroupsEndPoint(this);
        }
    }
}
