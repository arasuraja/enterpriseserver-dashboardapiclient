namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// User(s) added/removed from the group.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiGroupUsers
    {
        /// <summary>
        /// List of user IDs
        /// </summary>
        [DataMember]
        public List<int> Id { get; set; }
    }
}
