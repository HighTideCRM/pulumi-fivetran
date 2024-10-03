// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran
{
    public static class GetDestination
    {
        /// <summary>
        /// This data source returns a destination object.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Fivetran = Pulumi.Fivetran;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var dest = Fivetran.GetDestination.Invoke(new()
        ///     {
        ///         Id = "anonymous_mystery",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Task<GetDestinationResult> InvokeAsync(GetDestinationArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDestinationResult>("fivetran:index/getDestination:getDestination", args ?? new GetDestinationArgs(), options.WithDefaults());

        /// <summary>
        /// This data source returns a destination object.
        /// 
        /// ## Example Usage
        /// 
        /// ```csharp
        /// using System.Collections.Generic;
        /// using System.Linq;
        /// using Pulumi;
        /// using Fivetran = Pulumi.Fivetran;
        /// 
        /// return await Deployment.RunAsync(() =&gt; 
        /// {
        ///     var dest = Fivetran.GetDestination.Invoke(new()
        ///     {
        ///         Id = "anonymous_mystery",
        ///     });
        /// 
        /// });
        /// ```
        /// </summary>
        public static Output<GetDestinationResult> Invoke(GetDestinationInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDestinationResult>("fivetran:index/getDestination:getDestination", args ?? new GetDestinationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDestinationArgs : global::Pulumi.InvokeArgs
    {
        [Input("config")]
        public Inputs.GetDestinationConfigArgs? Config { get; set; }

        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        public GetDestinationArgs()
        {
        }
        public static new GetDestinationArgs Empty => new GetDestinationArgs();
    }

    public sealed class GetDestinationInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("config")]
        public Input<Inputs.GetDestinationConfigInputArgs>? Config { get; set; }

        [Input("id", required: true)]
        public Input<string> Id { get; set; } = null!;

        public GetDestinationInvokeArgs()
        {
        }
        public static new GetDestinationInvokeArgs Empty => new GetDestinationInvokeArgs();
    }


    [OutputType]
    public sealed class GetDestinationResult
    {
        public readonly Outputs.GetDestinationConfigResult? Config;
        public readonly bool DaylightSavingTimeEnabled;
        public readonly string GroupId;
        public readonly string Id;
        public readonly string LocalProcessingAgentId;
        public readonly string NetworkingMethod;
        public readonly string Region;
        public readonly string Service;
        public readonly string SetupStatus;
        public readonly string TimeZoneOffset;

        [OutputConstructor]
        private GetDestinationResult(
            Outputs.GetDestinationConfigResult? config,

            bool daylightSavingTimeEnabled,

            string groupId,

            string id,

            string localProcessingAgentId,

            string networkingMethod,

            string region,

            string service,

            string setupStatus,

            string timeZoneOffset)
        {
            Config = config;
            DaylightSavingTimeEnabled = daylightSavingTimeEnabled;
            GroupId = groupId;
            Id = id;
            LocalProcessingAgentId = localProcessingAgentId;
            NetworkingMethod = networkingMethod;
            Region = region;
            Service = service;
            SetupStatus = setupStatus;
            TimeZoneOffset = timeZoneOffset;
        }
    }
}
