﻿namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Details about the dashboard to be exported.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiExportDashboard
    {
        /// <summary>
        /// Dashboard ID.
        /// </summary>
        [DataMember]
        public Guid DashboardId
        {
            get;
            set;
        }

        /// <summary>
        /// Specifies the relative URL of the dashboard.
        /// </summary>
        [DataMember]
        public string ServerPath
        {
            get;
            set;
        }

        /// <summary>
        /// Export type.
        /// </summary>
        [DataMember]
        [Required]
        public string ExportType
        {
            get;
            set;
        }
    }
}