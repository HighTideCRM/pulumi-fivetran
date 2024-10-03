// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * This data source returns a team object.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fivetran from "@pulumi/fivetran";
 *
 * const team = fivetran.getTeam({
 *     id: "team_id",
 * });
 * ```
 */
export function getTeam(args: GetTeamArgs, opts?: pulumi.InvokeOptions): Promise<GetTeamResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("fivetran:index/getTeam:getTeam", {
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getTeam.
 */
export interface GetTeamArgs {
    /**
     * The unique identifier for the team within your account.
     */
    id: string;
}

/**
 * A collection of values returned by getTeam.
 */
export interface GetTeamResult {
    /**
     * The description of the team within your account.
     */
    readonly description: string;
    /**
     * The unique identifier for the team within your account.
     */
    readonly id: string;
    /**
     * The name of the team within your account.
     */
    readonly name: string;
    /**
     * The account role of the team.
     */
    readonly role: string;
}
/**
 * This data source returns a team object.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fivetran from "@pulumi/fivetran";
 *
 * const team = fivetran.getTeam({
 *     id: "team_id",
 * });
 * ```
 */
export function getTeamOutput(args: GetTeamOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTeamResult> {
    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invokeOutput("fivetran:index/getTeam:getTeam", {
        "id": args.id,
    }, opts);
}

/**
 * A collection of arguments for invoking getTeam.
 */
export interface GetTeamOutputArgs {
    /**
     * The unique identifier for the team within your account.
     */
    id: pulumi.Input<string>;
}
