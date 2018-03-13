// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.KeyVault.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// A certificate operation is returned in case of asynchronous requests.
    /// </summary>
    public partial class CertificateOperation
    {
        /// <summary>
        /// Initializes a new instance of the CertificateOperation class.
        /// </summary>
        public CertificateOperation()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CertificateOperation class.
        /// </summary>
        /// <param name="id">The certificate id.</param>
        /// <param name="issuerParameters">Parameters for the issuer of the
        /// X509 component of a certificate.</param>
        /// <param name="csr">The certificate signing request (CSR) that is
        /// being used in the certificate operation.</param>
        /// <param name="cancellationRequested">Indicates if cancellation was
        /// requested on the certificate operation.</param>
        /// <param name="status">Status of the certificate operation.</param>
        /// <param name="statusDetails">The status details of the certificate
        /// operation.</param>
        /// <param name="error">Error encountered, if any, during the
        /// certificate operation.</param>
        /// <param name="target">Location which contains the result of the
        /// certificate operation.</param>
        /// <param name="requestId">Identifier for the certificate
        /// operation.</param>
        public CertificateOperation(string id = default(string), IssuerParameters issuerParameters = default(IssuerParameters), byte[] csr = default(byte[]), bool? cancellationRequested = default(bool?), string status = default(string), string statusDetails = default(string), Error error = default(Error), string target = default(string), string requestId = default(string))
        {
            Id = id;
            IssuerParameters = issuerParameters;
            Csr = csr;
            CancellationRequested = cancellationRequested;
            Status = status;
            StatusDetails = statusDetails;
            Error = error;
            Target = target;
            RequestId = requestId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the certificate id.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Gets or sets parameters for the issuer of the X509 component of a
        /// certificate.
        /// </summary>
        [JsonProperty(PropertyName = "issuer")]
        public IssuerParameters IssuerParameters { get; set; }

        /// <summary>
        /// Gets or sets the certificate signing request (CSR) that is being
        /// used in the certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "csr")]
        public byte[] Csr { get; set; }

        /// <summary>
        /// Gets or sets indicates if cancellation was requested on the
        /// certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "cancellation_requested")]
        public bool? CancellationRequested { get; set; }

        /// <summary>
        /// Gets or sets status of the certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets the status details of the certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "status_details")]
        public string StatusDetails { get; set; }

        /// <summary>
        /// Gets or sets error encountered, if any, during the certificate
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error Error { get; set; }

        /// <summary>
        /// Gets or sets location which contains the result of the certificate
        /// operation.
        /// </summary>
        [JsonProperty(PropertyName = "target")]
        public string Target { get; set; }

        /// <summary>
        /// Gets or sets identifier for the certificate operation.
        /// </summary>
        [JsonProperty(PropertyName = "request_id")]
        public string RequestId { get; set; }

    }
}
