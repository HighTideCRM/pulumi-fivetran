// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

export class DestinationCertificates extends pulumi.CustomResource {
    /**
     * Get an existing DestinationCertificates resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: DestinationCertificatesState, opts?: pulumi.CustomResourceOptions): DestinationCertificates {
        return new DestinationCertificates(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fivetran:index/destinationCertificates:DestinationCertificates';

    /**
     * Returns true if the given object is an instance of DestinationCertificates.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is DestinationCertificates {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === DestinationCertificates.__pulumiType;
    }

    public readonly certificates!: pulumi.Output<outputs.DestinationCertificatesCertificate[] | undefined>;
    /**
     * The unique identifier for the target destination within the Fivetran system.
     */
    public readonly destinationId!: pulumi.Output<string>;

    /**
     * Create a DestinationCertificates resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: DestinationCertificatesArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: DestinationCertificatesArgs | DestinationCertificatesState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as DestinationCertificatesState | undefined;
            resourceInputs["certificates"] = state ? state.certificates : undefined;
            resourceInputs["destinationId"] = state ? state.destinationId : undefined;
        } else {
            const args = argsOrState as DestinationCertificatesArgs | undefined;
            if ((!args || args.destinationId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'destinationId'");
            }
            resourceInputs["certificates"] = args ? args.certificates : undefined;
            resourceInputs["destinationId"] = args ? args.destinationId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(DestinationCertificates.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering DestinationCertificates resources.
 */
export interface DestinationCertificatesState {
    certificates?: pulumi.Input<pulumi.Input<inputs.DestinationCertificatesCertificate>[]>;
    /**
     * The unique identifier for the target destination within the Fivetran system.
     */
    destinationId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a DestinationCertificates resource.
 */
export interface DestinationCertificatesArgs {
    certificates?: pulumi.Input<pulumi.Input<inputs.DestinationCertificatesCertificate>[]>;
    /**
     * The unique identifier for the target destination within the Fivetran system.
     */
    destinationId: pulumi.Input<string>;
}
