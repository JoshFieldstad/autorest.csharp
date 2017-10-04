// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Fixtures.Azure.Fluent.AcceptanceTestsAzureSpecials.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class OdataFilterInner
    {
        /// <summary>
        /// Initializes a new instance of the OdataFilterInner class.
        /// </summary>
        public OdataFilterInner()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OdataFilterInner class.
        /// </summary>
        public OdataFilterInner(int? id = default(int?), string name = default(string))
        {
            Id = id;
            Name = name;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public int? Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

    }
}
