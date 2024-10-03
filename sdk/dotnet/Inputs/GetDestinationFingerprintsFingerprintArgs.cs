// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Inputs
{

    public sealed class GetDestinationFingerprintsFingerprintInputArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Hash of the fingerprint.
        /// </summary>
        [Input("hash", required: true)]
        public Input<string> Hash { get; set; } = null!;

        /// <summary>
        /// The SSH public key.
        /// </summary>
        [Input("publicKey", required: true)]
        public Input<string> PublicKey { get; set; } = null!;

        /// <summary>
        /// User name who validated the fingerprint.
        /// </summary>
        [Input("validatedBy", required: true)]
        public Input<string> ValidatedBy { get; set; } = null!;

        /// <summary>
        /// The date when fingerprint was approved.
        /// </summary>
        [Input("validatedDate", required: true)]
        public Input<string> ValidatedDate { get; set; } = null!;

        public GetDestinationFingerprintsFingerprintInputArgs()
        {
        }
        public static new GetDestinationFingerprintsFingerprintInputArgs Empty => new GetDestinationFingerprintsFingerprintInputArgs();
    }
}
