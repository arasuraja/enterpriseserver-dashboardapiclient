namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the dashboard passed to get their shared data sources.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiSharedDataSourceRequest
    {
        /// <summary>
        /// Dashboard ID.
        /// </summary>
        [Required]
        [DataMember]
        public Guid DashboardId
        {
            get;
            set;
        }

        /// <summary>
        /// Dashboard location.
        /// </summary>
        [DataMember]
        public string DashboardPath
        {
            get;
            set;
        }
    }
}
