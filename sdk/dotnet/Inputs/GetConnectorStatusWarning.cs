// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetConnectorStatusWarningArgs : global::Pulumi.InvokeArgs
    {
        /// <summary>
        /// Warning code.
        /// </summary>
        [Input("code", required: true)]
        public string Code { get; set; } = null!;

        /// <summary>
        /// Warning message.
        /// </summary>
        [Input("message", required: true)]
        public string Message { get; set; } = null!;

        public GetConnectorStatusWarningArgs()
        {
        }
        public static new GetConnectorStatusWarningArgs Empty => new GetConnectorStatusWarningArgs();
    }
}
