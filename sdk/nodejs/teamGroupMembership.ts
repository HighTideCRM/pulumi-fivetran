// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "./types/input";
import * as outputs from "./types/output";
import * as utilities from "./utilities";

/**
 * This resource allows you to create, update, and delete group membership for teams
 *
 * ## Import
 *
 * 1. To import an existing `fivetran_team_group_membership` resource into your Terraform state, you need to get `team_id` and `group_id`
 *
 * You can retrieve all teams using the [fivetran_teams data source](/docs/data-sources/teams).
 *
 * 2. Define an empty resource in your `.tf` configuration:
 *
 * hcl
 *
 * resource "fivetran_team_group_membership" "my_imported_fivetran_team_group_membership" {
 *
 * }
 *
 * 3. Run the `pulumi import` command:
 *
 * ```sh
 * $ pulumi import fivetran:index/teamGroupMembership:TeamGroupMembership my_imported_fivetran_team_group_membership {team_id}
 * ```
 *
 * 4. Use the `terraform state show` command to get the values from the state:
 *
 * terraform state show 'fivetran_team_group_membership.my_imported_fivetran_team_group_membership'
 *
 * 5. Copy the values and paste them to your `.tf` configuration.
 */
export class TeamGroupMembership extends pulumi.CustomResource {
    /**
     * Get an existing TeamGroupMembership resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TeamGroupMembershipState, opts?: pulumi.CustomResourceOptions): TeamGroupMembership {
        return new TeamGroupMembership(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fivetran:index/teamGroupMembership:TeamGroupMembership';

    /**
     * Returns true if the given object is an instance of TeamGroupMembership.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TeamGroupMembership {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TeamGroupMembership.__pulumiType;
    }

    public readonly groups!: pulumi.Output<outputs.TeamGroupMembershipGroup[] | undefined>;
    /**
     * The unique identifier for the team within your account.
     */
    public readonly teamId!: pulumi.Output<string>;

    /**
     * Create a TeamGroupMembership resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TeamGroupMembershipArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TeamGroupMembershipArgs | TeamGroupMembershipState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as TeamGroupMembershipState | undefined;
            resourceInputs["groups"] = state ? state.groups : undefined;
            resourceInputs["teamId"] = state ? state.teamId : undefined;
        } else {
            const args = argsOrState as TeamGroupMembershipArgs | undefined;
            if ((!args || args.teamId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'teamId'");
            }
            resourceInputs["groups"] = args ? args.groups : undefined;
            resourceInputs["teamId"] = args ? args.teamId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(TeamGroupMembership.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TeamGroupMembership resources.
 */
export interface TeamGroupMembershipState {
    groups?: pulumi.Input<pulumi.Input<inputs.TeamGroupMembershipGroup>[]>;
    /**
     * The unique identifier for the team within your account.
     */
    teamId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a TeamGroupMembership resource.
 */
export interface TeamGroupMembershipArgs {
    groups?: pulumi.Input<pulumi.Input<inputs.TeamGroupMembershipGroup>[]>;
    /**
     * The unique identifier for the team within your account.
     */
    teamId: pulumi.Input<string>;
}
