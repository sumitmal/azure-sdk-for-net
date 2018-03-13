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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The key update parameters.
    /// </summary>
    public partial class KeyUpdateParameters
    {
        /// <summary>
        /// Initializes a new instance of the KeyUpdateParameters class.
        /// </summary>
        public KeyUpdateParameters()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the KeyUpdateParameters class.
        /// </summary>
        /// <param name="keyOps">Json web key operations. For more information
        /// on possible key operations, see JsonWebKeyOperation.</param>
        /// <param name="tags">Application specific metadata in the form of
        /// key-value pairs.</param>
        public KeyUpdateParameters(IList<string> keyOps = default(IList<string>), KeyAttributes keyAttributes = default(KeyAttributes), IDictionary<string, string> tags = default(IDictionary<string, string>))
        {
            KeyOps = keyOps;
            KeyAttributes = keyAttributes;
            Tags = tags;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets json web key operations. For more information on
        /// possible key operations, see JsonWebKeyOperation.
        /// </summary>
        [JsonProperty(PropertyName = "key_ops")]
        public IList<string> KeyOps { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attributes")]
        public KeyAttributes KeyAttributes { get; set; }

        /// <summary>
        /// Gets or sets application specific metadata in the form of key-value
        /// pairs.
        /// </summary>
        [JsonProperty(PropertyName = "tags")]
        public IDictionary<string, string> Tags { get; set; }

    }
}
