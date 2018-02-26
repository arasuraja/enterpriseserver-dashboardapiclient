namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [Serializable]
    [DataContract]
    public class ApiGroupListV2
    {
        [DataMember]
        public List<ApiGroupV2> GroupList
        {
            get;
            set;
        }
    }
}