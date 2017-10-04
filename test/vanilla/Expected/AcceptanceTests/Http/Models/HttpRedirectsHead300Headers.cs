// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.AcceptanceTestsHttp.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Defines headers for head300 operation.
    /// </summary>
    public partial class HttpRedirectsHead300Headers
    {
        /// <summary>
        /// Initializes a new instance of the HttpRedirectsHead300Headers
        /// class.
        /// </summary>
        public HttpRedirectsHead300Headers()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the HttpRedirectsHead300Headers
        /// class.
        /// </summary>
        /// <param name="location">The redirect location for this request.
        /// Possible values include: '/http/success/head/200'</param>
        public HttpRedirectsHead300Headers(string location = default(string))
        {
            Location = location;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the redirect location for this request. Possible
        /// values include: '/http/success/head/200'
        /// </summary>
        [JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
