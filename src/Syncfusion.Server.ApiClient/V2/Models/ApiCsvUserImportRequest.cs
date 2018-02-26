namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    /// <summary>
    /// Contains CSV user import request.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiCsvUserImportRequest
    {
        /// <summary>
        /// Provides the CSV file in an array of bytes.
        /// </summary>
        [DataMember]
        [Required]
        public byte[] CsvFileContent
        {
            get;
            set;
        }
    }
}
