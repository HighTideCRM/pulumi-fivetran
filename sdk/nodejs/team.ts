// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "./utilities";

/**
 * This resource allows you to create, update, and delete teams.
 *
 * ## Example Usage
 *
 * ```typescript
 * import * as pulumi from "@pulumi/pulumi";
 * import * as fivetran from "@hightidecrm/pulumi-fivetran";
 *
 * const testTeam = new fivetran.Team("testTeam", {
 *     description: "test_description",
 *     role: "Account Reviewer",
 * }, {
 *     provider: fivetran_provider,
 * });
 * ```
 *
 * ## Import
 *
 * 1. To import an existing `fivetran_team` resource into your Terraform state, you need to get `team_id`.
 *
 * You can retrieve all teams using the [fivetran_teams data source](/docs/data-sources/teams).
 *
 * 2. Define an empty resource in your `.tf` configuration:
 *
 * hcl
 *
 * resource "fivetran_team" "my_imported_fivetran_team" {
 *
 * }
 *
 * 3. Run the `pulumi import` command:
 *
 * ```sh
 * $ pulumi import fivetran:index/team:Team my_imported_fivetran_team {team_id}
 * ```
 *
 * 4. Use the `terraform state show` command to get the values from the state:
 *
 * terraform state show 'fivetran_team.my_imported_fivetran_team'
 *
 * 5. Copy the values and paste them to your `.tf` configuration.
 */
export class Team extends pulumi.CustomResource {
    /**
     * Get an existing Team resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TeamState, opts?: pulumi.CustomResourceOptions): Team {
        return new Team(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'fivetran:index/team:Team';

    /**
     * Returns true if the given object is an instance of Team.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Team {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Team.__pulumiType;
    }

    /**
     * The description of the team within your account.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * The name of the team within your account.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * The account role of the team.
     */
    public readonly role!: pulumi.Output<string>;

    /**
     * Create a Team resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TeamArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TeamArgs | TeamState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as TeamState | undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["role"] = state ? state.role : undefined;
        } else {
            const args = argsOrState as TeamArgs | undefined;
            if ((!args || args.role === undefined) && !opts.urn) {
                throw new Error("Missing required property 'role'");
            }
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["role"] = args ? args.role : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Team.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Team resources.
 */
export interface TeamState {
    /**
     * The description of the team within your account.
     */
    description?: pulumi.Input<string>;
    /**
     * The name of the team within your account.
     */
    name?: pulumi.Input<string>;
    /**
     * The account role of the team.
     */
    role?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Team resource.
 */
export interface TeamArgs {
    /**
     * The description of the team within your account.
     */
    description?: pulumi.Input<string>;
    /**
     * The name of the team within your account.
     */
    name?: pulumi.Input<string>;
    /**
     * The account role of the team.
     */
    role: pulumi.Input<string>;
}
