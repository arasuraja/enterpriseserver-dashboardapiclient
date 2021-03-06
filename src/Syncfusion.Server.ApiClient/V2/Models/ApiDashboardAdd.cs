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
    /// Dashboard details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiDashboardAdd
    {
        /// <summary>
        /// Dashboard name.
        /// </summary>
        [DataMember]
        [Required]
        public string Name
        {
            get;
            set;
        }

        /// <summary>
        /// Dashboard description.
        /// </summary>
        [DataMember]
        public string Description
        {
            get;
            set;
        }

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
        /// Specify true to set the item as a public.
        /// </summary>
        [DataMember]
        public bool IsPublic
        {
            get;
            set;
        }

        /// <summary>
        /// Provide items in an array of bytes.
        /// </summary>
        [DataMember]
        [Required]
        public byte[] ItemContent
        {
            get;
            set;
        }
    }
}
