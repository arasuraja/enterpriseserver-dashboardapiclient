namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.Serialization;
    using System.ComponentModel.DataAnnotations;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Category details.
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiCategoryAdd
    {
        /// <summary>
        /// Category name.
        /// </summary>
        [DataMember]
        [Required]
        public string Name { get; set; }

        /// <summary>
        /// Category description.
        /// </summary>
        [DataMember]
        public string Description { get; set; }
    }
}
