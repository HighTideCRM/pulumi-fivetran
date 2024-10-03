// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export function getConnectorCertificates(args: GetConnectorCertificatesArgs, opts?: pulumi.InvokeOptions): Promise<GetConnectorCertificatesResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("fivetran:index/getConnectorCertificates:getConnectorCertificates", {
        "certificates": args.certificates,
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getConnectorCertificates.
 */
export interface GetConnectorCertificatesArgs {
    certificates?: inputs.GetConnectorCertificatesCertificate[];
    /**
     * The unique identifier for the resource. Equal to target connection id.
     */
    id: string;
}

/**
 * A collection of values returned by getConnectorCertificates.
 */
export interface GetConnectorCertificatesResult {
    readonly certificates?: outputs.GetConnectorCertificatesCertificate[];
    /**
     * The unique identifier for the target connection within the Fivetran system.
     */
    readonly connectorId: string;
    /**
     * The unique identifier for the resource. Equal to target connection id.
     */
    readonly id: string;
}
export function getConnectorCertificatesOutput(args: GetConnectorCertificatesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetConnectorCertificatesResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("fivetran:index/getConnectorCertificates:getConnectorCertificates", {
        "certificates": args.certificates,
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getConnectorCertificates.
 */
export interface GetConnectorCertificatesOutputArgs {
    certificates?: pulumi.Input<pulumi.Input<inputs.GetConnectorCertificatesCertificateArgs>[]>;
    /**
     * The unique identifier for the resource. Equal to target connection id.
     */
    id: pulumi.Input<string>;
}
