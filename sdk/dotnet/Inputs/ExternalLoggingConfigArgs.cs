// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class ExternalLoggingConfigArgs : global::Pulumi.ResourceArgs
    {
        [Input("apiKey")]
        private Input<string>? _apiKey;

        /// <summary>
        /// API Key
        /// </summary>
        public Input<string>? ApiKey
        {
            get => _apiKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _apiKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Channel
        /// </summary>
        [Input("channel")]
        public Input<string>? Channel { get; set; }

        /// <summary>
        /// Enable SSL
        /// </summary>
        [Input("enableSsl")]
        public Input<bool>? EnableSsl { get; set; }

        /// <summary>
        /// external_id
        /// </summary>
        [Input("externalId")]
        public Input<string>? ExternalId { get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [Input("host")]
        public Input<string>? Host { get; set; }

        /// <summary>
        /// Server name
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// Log Group Name
        /// </summary>
        [Input("logGroupName")]
        public Input<string>? LogGroupName { get; set; }

        /// <summary>
        /// Port
        /// </summary>
        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("primaryKey")]
        private Input<string>? _primaryKey;

        /// <summary>
        /// Primary Key
        /// </summary>
        public Input<string>? PrimaryKey
        {
            get => _primaryKey;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _primaryKey = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Project Id for Google Cloud Logging
        /// </summary>
        [Input("projectId")]
        public Input<string>? ProjectId { get; set; }

        /// <summary>
        /// Region
        /// </summary>
        [Input("region")]
        public Input<string>? Region { get; set; }

        /// <summary>
        /// Role Arn
        /// </summary>
        [Input("roleArn")]
        public Input<string>? RoleArn { get; set; }

        /// <summary>
        /// Sub Domain
        /// </summary>
        [Input("subDomain")]
        public Input<string>? SubDomain { get; set; }

        [Input("token")]
        private Input<string>? _token;

        /// <summary>
        /// Token
        /// </summary>
        public Input<string>? Token
        {
            get => _token;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _token = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// Workspace ID
        /// </summary>
        [Input("workspaceId")]
        public Input<string>? WorkspaceId { get; set; }

        public ExternalLoggingConfigArgs()
        {
        }
        public static new ExternalLoggingConfigArgs Empty => new ExternalLoggingConfigArgs();
    }
}
