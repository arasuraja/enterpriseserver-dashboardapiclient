namespace Syncfusion.Server.ApiClient.V2.Models
{
    using System;
    using System.Runtime.Serialization;

    /// <summary>
    /// User activation or deactivation request
    /// </summary>
    [Serializable]
    [DataContract]
    public class ApiUserActivationRequest
    {
        /// <summary>
        /// Status update for the user.
        /// </summary>
        [DataMember]
        public bool Activate { get; set; }
    }
}
