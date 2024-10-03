// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetExternalLoggingConfigArgs : global::Pulumi.InvokeArgs
    {
        [Input("apiKey")]
        private string? _apiKey;

        /// <summary>
        /// API Key
        /// </summary>
        public string? ApiKey
        {
            get => _apiKey;
            set => _apiKey = value;
        }

        /// <summary>
        /// Channel
        /// </summary>
        [Input("channel")]
        public string? Channel { get; set; }

        /// <summary>
        /// Enable SSL
        /// </summary>
        [Input("enableSsl")]
        public bool? EnableSsl { get; set; }

        /// <summary>
        /// external_id
        /// </summary>
        [Input("externalId")]
        public string? ExternalId { get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [Input("host")]
        public string? Host { get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [Input("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Log Group Name
        /// </summary>
        [Input("logGroupName")]
        public string? LogGroupName { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [Input("port")]
        public int? Port { get; set; }

        [Input("primaryKey")]
        private string? _primaryKey;

        /// <summary>
        /// Primary Key
        /// </summary>
        public string? PrimaryKey
        {
            get => _primaryKey;
            set => _primaryKey = value;
        }

        /// <summary>
        /// Project Id for Google Cloud Logging
        /// </summary>
        [Input("projectId")]
        public string? ProjectId { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [Input("region")]
        public string? Region { get; set; }

        /// <summary>
        /// Role Arn
        /// </summary>
        [Input("roleArn")]
        public string? RoleArn { get; set; }

        /// <summary>
        /// Sub Domain
        /// </summary>
        [Input("subDomain")]
        public string? SubDomain { get; set; }

        [Input("token")]
        private string? _token;

        /// <summary>
        /// Token
        /// </summary>
        public string? Token
        {
            get => _token;
            set => _token = value;
        }

        /// <summary>
        /// Workspace ID
        /// </summary>
        [Input("workspaceId")]
        public string? WorkspaceId { get; set; }

        public GetExternalLoggingConfigArgs()
        {
        }
        public static new GetExternalLoggingConfigArgs Empty => new GetExternalLoggingConfigArgs();
    }
}
