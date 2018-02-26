namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the favorite item.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUpdateFavorite
    {
        /// <summary>
        /// Dashboard ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid DashboardId { get; set; }

        /// <summary>
        /// Specify true to set the item as a favorite item.
        /// </summary>
        [DataMember]
        [Required]
        public bool Favorite { get; set; }
    }
}
