// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetGroupConnectorsConnectorArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// The unique identifier of the user who has created the connector in your account
        /// </summary>
        [Input("connectedBy", required: true)]
        public string ConnectedBy { get; set; } = null!;

        /// <summary>
        /// The timestamp of the time the connector was created in your account
        /// </summary>
        [Input("createdAt", required: true)]
        public string CreatedAt { get; set; } = null!;

        /// <summary>
        /// The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time
        /// </summary>
        [Input("dailySyncTime", required: true)]
        public string DailySyncTime { get; set; } = null!;

        /// <summary>
        /// The timestamp of the time the connector sync failed last time
        /// </summary>
        [Input("failedAt", required: true)]
        public string FailedAt { get; set; } = null!;

        /// <summary>
        /// The unique identifier for the Group within the Fivetran system.
        /// </summary>
        [Input("groupId", required: true)]
        public string GroupId { get; set; } = null!;

        /// <summary>
        /// The unique identifier for the Connector within the Fivetran system.
        /// </summary>
        [Input("id", required: true)]
        public string Id { get; set; } = null!;

        /// <summary>
        /// The connector schedule configuration type. Supported values: auto, manual
        /// </summary>
        [Input("scheduleType", required: true)]
        public string ScheduleType { get; set; } = null!;

        /// <summary>
        /// The name used both as the connector's name within the Fivetran system and as the source schema's name within your destination
        /// </summary>
        [Input("schema", required: true)]
        public string Schema { get; set; } = null!;

        /// <summary>
        /// The connector type name within the Fivetran system
        /// </summary>
        [Input("service", required: true)]
        public string Service { get; set; } = null!;

        /// <summary>
        /// The connector type version within the Fivetran system
        /// </summary>
        [Input("serviceVersion", required: true)]
        public int ServiceVersion { get; set; }

        [Input("status")]
        public Inputs.GetGroupConnectorsConnectorStatusArgs? Status { get; set; }

        /// <summary>
        /// The timestamp of the time the connector sync succeeded last time
        /// </summary>
        [Input("succeededAt", required: true)]
        public string SucceededAt { get; set; } = null!;

        /// <summary>
        /// The connector sync frequency in minutes
        /// </summary>
        [Input("syncFrequency", required: true)]
        public int SyncFrequency { get; set; }

        public GetGroupConnectorsConnectorArgs()
        {
        }
        public static new GetGroupConnectorsConnectorArgs Empty => new GetGroupConnectorsConnectorArgs();
    }
}
