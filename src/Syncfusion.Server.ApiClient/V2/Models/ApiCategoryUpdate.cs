﻿namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Category details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiCategoryUpdate
    {
        /// <summary>
        /// Category ID.
        /// </summary>
        [DataMember]
        [Required]
        public Guid CategoryId
        {
            get;
            set;
        }

        /// <summary>
        /// Category name.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Category description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
