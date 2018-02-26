namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// Permission details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUserPermissionAdd
    {
        /// <summary>
        /// Specify an access type for item.
        /// </summary>
        [DataMember]
        public string PermissionAccess
        {
            get;
            set;
        }

        /// <summary>
        /// User ID.
        /// </summary>
        [DataMember]
        public int UserId
        {
            get;
            set;
        }

        /// <summary>
        /// Specify an entity of item for permission.
        /// </summary>
        [DataMember]
        public string PermissionEntity
        {
            get;
            set;
        }

        /// <summary>
        /// Specify the item ID while assigning permission to particular item.
        /// </summary>
        [DataMember]
        public Guid? ItemId
        {
            get;
            set;
        }
    }
}
