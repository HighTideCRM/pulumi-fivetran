// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetConnectorConfigTenantConfigInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reltio`: Your Reltio subdomain.
        /// </summary>
        [Input("subdomain", required: true)]
        public Input<string> Subdomain { get; set; } = null!;

        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `reltio`: Your Reltio tenant ID.
        /// </summary>
        [Input("tenantId", required: true)]
        public Input<string> TenantId { get; set; } = null!;

        public GetConnectorConfigTenantConfigInputArgs()
        {
        }
        public static new GetConnectorConfigTenantConfigInputArgs Empty => new GetConnectorConfigTenantConfigInputArgs();
    }
}
