// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetTeamConnectorMembershipsConnectorInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The connector unique identifier
        /// </summary>
        [Input("connectorId", required: true)]
        public Input<string> ConnectorId { get; set; } = null!;

        /// <summary>
        /// The date and time the membership was created
        /// </summary>
        [Input("createdAt", required: true)]
        public Input<string> CreatedAt { get; set; } = null!;

        /// <summary>
        /// The team's role that links the team and the connector
        /// </summary>
        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        public GetTeamConnectorMembershipsConnectorInputArgs()
        {
        }
        public static new GetTeamConnectorMembershipsConnectorInputArgs Empty => new GetTeamConnectorMembershipsConnectorInputArgs();
    }
}
