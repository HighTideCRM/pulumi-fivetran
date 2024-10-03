// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetConnectorsMetadataSourceInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The description characterizing the purpose of the connector.
        /// </summary>
        [Input("description", required: true)]
        public Input<string> Description { get; set; } = null!;

        /// <summary>
        /// The icon resource URL.
        /// </summary>
        [Input("iconUrl", required: true)]
        public Input<string> IconUrl { get; set; } = null!;

        /// <summary>
        /// The unique identifier for the connector within the Fivetran system
        /// </summary>
        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        /// <summary>
        /// The link to the connector documentation.
        /// </summary>
        [Input("linkToDocs", required: true)]
        public Input<string> LinkToDocs { get; set; } = null!;

        /// <summary>
        /// The link to the connector ERD (entity–relationship diagram).
        /// </summary>
        [Input("linkToErd", required: true)]
        public Input<string> LinkToErd { get; set; } = null!;

        /// <summary>
        /// The connector service name within the Fivetran system.
        /// </summary>
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        /// <summary>
        /// The connector service type within the Fivetran system.
        /// </summary>
        [Input("type", required: true)]
        public Input<string> Type { get; set; } = null!;

        public GetConnectorsMetadataSourceInputArgs()
        {
        }
        public static new GetConnectorsMetadataSourceInputArgs Empty => new GetConnectorsMetadataSourceInputArgs();
    }
}
