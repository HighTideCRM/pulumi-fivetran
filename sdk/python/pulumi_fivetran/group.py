# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['GroupArgs', 'Group']

@pulumi.input_type
class GroupArgs:
    def __init__(__self__, *,
                 name: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a Group resource.
        :param pulumi.Input[str] name: The name of the group within your account.
        """
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the group within your account.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class _GroupState:
    def __init__(__self__, *,
                 created_at: Optional[pulumi.Input[str]] = None,
                 last_updated: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Group resources.
        :param pulumi.Input[str] created_at: The timestamp of when the group was created in your account.
        :param pulumi.Input[str] last_updated: The timestamp of when the resource/datasource was updated last time.
        :param pulumi.Input[str] name: The name of the group within your account.
        """
        if created_at is not None:
            pulumi.set(__self__, "created_at", created_at)
        if last_updated is not None:
            pulumi.set(__self__, "last_updated", last_updated)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> Optional[pulumi.Input[str]]:
        """
        The timestamp of when the group was created in your account.
        """
        return pulumi.get(self, "created_at")

    @created_at.setter
    def created_at(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "created_at", value)

    @property
    @pulumi.getter(name="lastUpdated")
    def last_updated(self) -> Optional[pulumi.Input[str]]:
        """
        The timestamp of when the resource/datasource was updated last time.
        """
        return pulumi.get(self, "last_updated")

    @last_updated.setter
    def last_updated(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "last_updated", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the group within your account.
        """
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


class Group(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        This resource allows you to create, update, and delete groups.

        IMPORTANT: Groups and destinations are mapped 1:1 to each other. We do this mapping using the group's id value that we automatically generate when you create a group using our Terrafrom Provider, and the destination's group_id value that you specify when you create a destination using our Terrafrom Provider. This means that if you use our Terrafrom Provider to create a destination, you must create a group in your Fivetran account before you can create a destination in it.

        When you create a destination in your Fivetran dashboard, we automatically create a group and assign a value to its id and a destination with the same group_id value, which is unique in your Fivetran account. The group's name corresponds to the Destination name you specify in your Fivetran dashboard when creating the destination in your Fivetran dashboard.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_fivetran as fivetran

        group = fivetran.Group("group")
        ```

        ## Import

        1. To import an existing `fivetran_group` resource into your Terraform state, you need to get **Destination Group ID** on the destination page in your Fivetran dashboard.

        To retrieve existing groups, use the [fivetran_groups data source](/docs/data-sources/groups).

        2. Define an empty resource in your `.tf` configuration:

        hcl

        resource "fivetran_group" "my_imported_fivetran_group" {

        }

        3. Run the `pulumi import` command:

        ```sh
        $ pulumi import fivetran:index/group:Group my_imported_fivetran_group {your Destination Group ID}
        ```

        4. Use the `terraform state show` command to get the values from the state:

        terraform state show 'fivetran_group.my_imported_fivetran_group'

        5. Copy the values and paste them to your `.tf` configuration.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] name: The name of the group within your account.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: Optional[GroupArgs] = None,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        This resource allows you to create, update, and delete groups.

        IMPORTANT: Groups and destinations are mapped 1:1 to each other. We do this mapping using the group's id value that we automatically generate when you create a group using our Terrafrom Provider, and the destination's group_id value that you specify when you create a destination using our Terrafrom Provider. This means that if you use our Terrafrom Provider to create a destination, you must create a group in your Fivetran account before you can create a destination in it.

        When you create a destination in your Fivetran dashboard, we automatically create a group and assign a value to its id and a destination with the same group_id value, which is unique in your Fivetran account. The group's name corresponds to the Destination name you specify in your Fivetran dashboard when creating the destination in your Fivetran dashboard.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_fivetran as fivetran

        group = fivetran.Group("group")
        ```

        ## Import

        1. To import an existing `fivetran_group` resource into your Terraform state, you need to get **Destination Group ID** on the destination page in your Fivetran dashboard.

        To retrieve existing groups, use the [fivetran_groups data source](/docs/data-sources/groups).

        2. Define an empty resource in your `.tf` configuration:

        hcl

        resource "fivetran_group" "my_imported_fivetran_group" {

        }

        3. Run the `pulumi import` command:

        ```sh
        $ pulumi import fivetran:index/group:Group my_imported_fivetran_group {your Destination Group ID}
        ```

        4. Use the `terraform state show` command to get the values from the state:

        terraform state show 'fivetran_group.my_imported_fivetran_group'

        5. Copy the values and paste them to your `.tf` configuration.

        :param str resource_name: The name of the resource.
        :param GroupArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(GroupArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = GroupArgs.__new__(GroupArgs)

            __props__.__dict__["name"] = name
            __props__.__dict__["created_at"] = None
            __props__.__dict__["last_updated"] = None
        super(Group, __self__).__init__(
            'fivetran:index/group:Group',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            created_at: Optional[pulumi.Input[str]] = None,
            last_updated: Optional[pulumi.Input[str]] = None,
            name: Optional[pulumi.Input[str]] = None) -> 'Group':
        """
        Get an existing Group resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] created_at: The timestamp of when the group was created in your account.
        :param pulumi.Input[str] last_updated: The timestamp of when the resource/datasource was updated last time.
        :param pulumi.Input[str] name: The name of the group within your account.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _GroupState.__new__(_GroupState)

        __props__.__dict__["created_at"] = created_at
        __props__.__dict__["last_updated"] = last_updated
        __props__.__dict__["name"] = name
        return Group(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createdAt")
    def created_at(self) -> pulumi.Output[str]:
        """
        The timestamp of when the group was created in your account.
        """
        return pulumi.get(self, "created_at")

    @property
    @pulumi.getter(name="lastUpdated")
    def last_updated(self) -> pulumi.Output[str]:
        """
        The timestamp of when the resource/datasource was updated last time.
        """
        return pulumi.get(self, "last_updated")

    @property
    @pulumi.getter
    def name(self) -> pulumi.Output[str]:
        """
        The name of the group within your account.
        """
        return pulumi.get(self, "name")

