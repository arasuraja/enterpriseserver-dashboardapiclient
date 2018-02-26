namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System.Runtime.Serialization;

    public class ApiStatusMessage
    {
        /// <summary>
        /// Returns the status message from the API.
        /// </summary>
        [DataMember]
        public string Message
        {
            get;
            set;
        }

        /// <summary>
        /// Returns the Link from  API.
        /// </summary>
        [DataMember]
        public string Link
        {
            get;
            set;
        }
    }
}
