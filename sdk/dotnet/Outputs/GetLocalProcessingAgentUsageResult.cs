// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Outputs
{

    [OutputType]
    public sealed class GetLocalProcessingAgentUsageResult
    {
        /// <summary>
        /// The unique identifier of the connection associated with the agent.
        /// </summary>
        public readonly string ConnectionId;
        /// <summary>
        /// The connection schema name.
        /// </summary>
        public readonly string Schema;
        /// <summary>
        /// The connection type.
        /// </summary>
        public readonly string Service;

        [OutputConstructor]
        private GetLocalProcessingAgentUsageResult(
            string connectionId,

            string schema,

            string service)
        {
            ConnectionId = connectionId;
            Schema = schema;
            Service = service;
        }
    }
}
