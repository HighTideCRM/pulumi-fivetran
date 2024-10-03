# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities

__all__ = ['ConnectorScheduleArgs', 'ConnectorSchedule']

@pulumi.input_type
class ConnectorScheduleArgs:
    def __init__(__self__, *,
                 connector_id: pulumi.Input[str],
                 daily_sync_time: Optional[pulumi.Input[str]] = None,
                 pause_after_trial: Optional[pulumi.Input[str]] = None,
                 paused: Optional[pulumi.Input[str]] = None,
                 schedule_type: Optional[pulumi.Input[str]] = None,
                 sync_frequency: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ConnectorSchedule resource.
        :param pulumi.Input[str] connector_id: The unique identifier for the connector within the Fivetran system.
        :param pulumi.Input[str] daily_sync_time: The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        :param pulumi.Input[str] pause_after_trial: Specifies whether the connector should be paused after the free trial period has ended.
        :param pulumi.Input[str] paused: Specifies whether the connector is paused.
        :param pulumi.Input[str] schedule_type: The connector schedule configuration type. Supported values: auto, manual.
        :param pulumi.Input[str] sync_frequency: The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        pulumi.set(__self__, "connector_id", connector_id)
        if daily_sync_time is not None:
            pulumi.set(__self__, "daily_sync_time", daily_sync_time)
        if pause_after_trial is not None:
            pulumi.set(__self__, "pause_after_trial", pause_after_trial)
        if paused is not None:
            pulumi.set(__self__, "paused", paused)
        if schedule_type is not None:
            pulumi.set(__self__, "schedule_type", schedule_type)
        if sync_frequency is not None:
            pulumi.set(__self__, "sync_frequency", sync_frequency)

    @property
    @pulumi.getter(name="connectorId")
    def connector_id(self) -> pulumi.Input[str]:
        """
        The unique identifier for the connector within the Fivetran system.
        """
        return pulumi.get(self, "connector_id")

    @connector_id.setter
    def connector_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "connector_id", value)

    @property
    @pulumi.getter(name="dailySyncTime")
    def daily_sync_time(self) -> Optional[pulumi.Input[str]]:
        """
        The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        """
        return pulumi.get(self, "daily_sync_time")

    @daily_sync_time.setter
    def daily_sync_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "daily_sync_time", value)

    @property
    @pulumi.getter(name="pauseAfterTrial")
    def pause_after_trial(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies whether the connector should be paused after the free trial period has ended.
        """
        return pulumi.get(self, "pause_after_trial")

    @pause_after_trial.setter
    def pause_after_trial(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pause_after_trial", value)

    @property
    @pulumi.getter
    def paused(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies whether the connector is paused.
        """
        return pulumi.get(self, "paused")

    @paused.setter
    def paused(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "paused", value)

    @property
    @pulumi.getter(name="scheduleType")
    def schedule_type(self) -> Optional[pulumi.Input[str]]:
        """
        The connector schedule configuration type. Supported values: auto, manual.
        """
        return pulumi.get(self, "schedule_type")

    @schedule_type.setter
    def schedule_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schedule_type", value)

    @property
    @pulumi.getter(name="syncFrequency")
    def sync_frequency(self) -> Optional[pulumi.Input[str]]:
        """
        The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        return pulumi.get(self, "sync_frequency")

    @sync_frequency.setter
    def sync_frequency(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sync_frequency", value)


@pulumi.input_type
class _ConnectorScheduleState:
    def __init__(__self__, *,
                 connector_id: Optional[pulumi.Input[str]] = None,
                 daily_sync_time: Optional[pulumi.Input[str]] = None,
                 pause_after_trial: Optional[pulumi.Input[str]] = None,
                 paused: Optional[pulumi.Input[str]] = None,
                 schedule_type: Optional[pulumi.Input[str]] = None,
                 sync_frequency: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ConnectorSchedule resources.
        :param pulumi.Input[str] connector_id: The unique identifier for the connector within the Fivetran system.
        :param pulumi.Input[str] daily_sync_time: The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        :param pulumi.Input[str] pause_after_trial: Specifies whether the connector should be paused after the free trial period has ended.
        :param pulumi.Input[str] paused: Specifies whether the connector is paused.
        :param pulumi.Input[str] schedule_type: The connector schedule configuration type. Supported values: auto, manual.
        :param pulumi.Input[str] sync_frequency: The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        if connector_id is not None:
            pulumi.set(__self__, "connector_id", connector_id)
        if daily_sync_time is not None:
            pulumi.set(__self__, "daily_sync_time", daily_sync_time)
        if pause_after_trial is not None:
            pulumi.set(__self__, "pause_after_trial", pause_after_trial)
        if paused is not None:
            pulumi.set(__self__, "paused", paused)
        if schedule_type is not None:
            pulumi.set(__self__, "schedule_type", schedule_type)
        if sync_frequency is not None:
            pulumi.set(__self__, "sync_frequency", sync_frequency)

    @property
    @pulumi.getter(name="connectorId")
    def connector_id(self) -> Optional[pulumi.Input[str]]:
        """
        The unique identifier for the connector within the Fivetran system.
        """
        return pulumi.get(self, "connector_id")

    @connector_id.setter
    def connector_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connector_id", value)

    @property
    @pulumi.getter(name="dailySyncTime")
    def daily_sync_time(self) -> Optional[pulumi.Input[str]]:
        """
        The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        """
        return pulumi.get(self, "daily_sync_time")

    @daily_sync_time.setter
    def daily_sync_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "daily_sync_time", value)

    @property
    @pulumi.getter(name="pauseAfterTrial")
    def pause_after_trial(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies whether the connector should be paused after the free trial period has ended.
        """
        return pulumi.get(self, "pause_after_trial")

    @pause_after_trial.setter
    def pause_after_trial(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "pause_after_trial", value)

    @property
    @pulumi.getter
    def paused(self) -> Optional[pulumi.Input[str]]:
        """
        Specifies whether the connector is paused.
        """
        return pulumi.get(self, "paused")

    @paused.setter
    def paused(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "paused", value)

    @property
    @pulumi.getter(name="scheduleType")
    def schedule_type(self) -> Optional[pulumi.Input[str]]:
        """
        The connector schedule configuration type. Supported values: auto, manual.
        """
        return pulumi.get(self, "schedule_type")

    @schedule_type.setter
    def schedule_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "schedule_type", value)

    @property
    @pulumi.getter(name="syncFrequency")
    def sync_frequency(self) -> Optional[pulumi.Input[str]]:
        """
        The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        return pulumi.get(self, "sync_frequency")

    @sync_frequency.setter
    def sync_frequency(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "sync_frequency", value)


class ConnectorSchedule(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 connector_id: Optional[pulumi.Input[str]] = None,
                 daily_sync_time: Optional[pulumi.Input[str]] = None,
                 pause_after_trial: Optional[pulumi.Input[str]] = None,
                 paused: Optional[pulumi.Input[str]] = None,
                 schedule_type: Optional[pulumi.Input[str]] = None,
                 sync_frequency: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        -This resource allows you to manage connectors schedule: pause/unpause connector, set daily_sync_time and sync_frequency.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_fivetran as fivetran

        my_connector_schedule = fivetran.ConnectorSchedule("myConnectorSchedule",
            connector_id=fivetran_connector["my_connector"]["id"],
            sync_frequency="1440",
            daily_sync_time="03:00",
            paused="false",
            pause_after_trial="true",
            schedule_type="auto")
        ```

        ## Import

        You don't need to import this resource as it is synthetic.

        To fetch schedule values from existing connector use `fivetran_connector` data source:

        hcl

        data "fivetran_connector" "my_connector" {

            id = "my_connector_id"

        }

        now you can use schedule values from this data_source:

          sync_frequency = data.fivetran_connector.my_connector.sync_frequency

          paused = data.fivetran_connector.my_connector.paused

        This resource manages settings for already existing connector instance and doesn't create a new one.

        If you already have an existing connector with id = `my_connector_id` just define `fivetran_connector_schedule` resource:

        hcl

        resource "fivetran_connector_schedule" "my_connector_schedule" {

            connector_id = "my_connector_id"
            
            sync_frequency     = "360"
            
            paused             = false
            
            pause_after_trial  = true
            
            schedule_type      = "auto"

        }

        -> NOTE: You can't have several resources managing the same `connector_id`. They will be in conflict ater each `apply`.

        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] connector_id: The unique identifier for the connector within the Fivetran system.
        :param pulumi.Input[str] daily_sync_time: The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        :param pulumi.Input[str] pause_after_trial: Specifies whether the connector should be paused after the free trial period has ended.
        :param pulumi.Input[str] paused: Specifies whether the connector is paused.
        :param pulumi.Input[str] schedule_type: The connector schedule configuration type. Supported values: auto, manual.
        :param pulumi.Input[str] sync_frequency: The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ConnectorScheduleArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        -This resource allows you to manage connectors schedule: pause/unpause connector, set daily_sync_time and sync_frequency.

        ## Example Usage

        ```python
        import pulumi
        import pulumi_fivetran as fivetran

        my_connector_schedule = fivetran.ConnectorSchedule("myConnectorSchedule",
            connector_id=fivetran_connector["my_connector"]["id"],
            sync_frequency="1440",
            daily_sync_time="03:00",
            paused="false",
            pause_after_trial="true",
            schedule_type="auto")
        ```

        ## Import

        You don't need to import this resource as it is synthetic.

        To fetch schedule values from existing connector use `fivetran_connector` data source:

        hcl

        data "fivetran_connector" "my_connector" {

            id = "my_connector_id"

        }

        now you can use schedule values from this data_source:

          sync_frequency = data.fivetran_connector.my_connector.sync_frequency

          paused = data.fivetran_connector.my_connector.paused

        This resource manages settings for already existing connector instance and doesn't create a new one.

        If you already have an existing connector with id = `my_connector_id` just define `fivetran_connector_schedule` resource:

        hcl

        resource "fivetran_connector_schedule" "my_connector_schedule" {

            connector_id = "my_connector_id"
            
            sync_frequency     = "360"
            
            paused             = false
            
            pause_after_trial  = true
            
            schedule_type      = "auto"

        }

        -> NOTE: You can't have several resources managing the same `connector_id`. They will be in conflict ater each `apply`.

        :param str resource_name: The name of the resource.
        :param ConnectorScheduleArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ConnectorScheduleArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 connector_id: Optional[pulumi.Input[str]] = None,
                 daily_sync_time: Optional[pulumi.Input[str]] = None,
                 pause_after_trial: Optional[pulumi.Input[str]] = None,
                 paused: Optional[pulumi.Input[str]] = None,
                 schedule_type: Optional[pulumi.Input[str]] = None,
                 sync_frequency: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ConnectorScheduleArgs.__new__(ConnectorScheduleArgs)

            if connector_id is None and not opts.urn:
                raise TypeError("Missing required property 'connector_id'")
            __props__.__dict__["connector_id"] = connector_id
            __props__.__dict__["daily_sync_time"] = daily_sync_time
            __props__.__dict__["pause_after_trial"] = pause_after_trial
            __props__.__dict__["paused"] = paused
            __props__.__dict__["schedule_type"] = schedule_type
            __props__.__dict__["sync_frequency"] = sync_frequency
        super(ConnectorSchedule, __self__).__init__(
            'fivetran:index/connectorSchedule:ConnectorSchedule',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            connector_id: Optional[pulumi.Input[str]] = None,
            daily_sync_time: Optional[pulumi.Input[str]] = None,
            pause_after_trial: Optional[pulumi.Input[str]] = None,
            paused: Optional[pulumi.Input[str]] = None,
            schedule_type: Optional[pulumi.Input[str]] = None,
            sync_frequency: Optional[pulumi.Input[str]] = None) -> 'ConnectorSchedule':
        """
        Get an existing ConnectorSchedule resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] connector_id: The unique identifier for the connector within the Fivetran system.
        :param pulumi.Input[str] daily_sync_time: The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        :param pulumi.Input[str] pause_after_trial: Specifies whether the connector should be paused after the free trial period has ended.
        :param pulumi.Input[str] paused: Specifies whether the connector is paused.
        :param pulumi.Input[str] schedule_type: The connector schedule configuration type. Supported values: auto, manual.
        :param pulumi.Input[str] sync_frequency: The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ConnectorScheduleState.__new__(_ConnectorScheduleState)

        __props__.__dict__["connector_id"] = connector_id
        __props__.__dict__["daily_sync_time"] = daily_sync_time
        __props__.__dict__["pause_after_trial"] = pause_after_trial
        __props__.__dict__["paused"] = paused
        __props__.__dict__["schedule_type"] = schedule_type
        __props__.__dict__["sync_frequency"] = sync_frequency
        return ConnectorSchedule(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="connectorId")
    def connector_id(self) -> pulumi.Output[str]:
        """
        The unique identifier for the connector within the Fivetran system.
        """
        return pulumi.get(self, "connector_id")

    @property
    @pulumi.getter(name="dailySyncTime")
    def daily_sync_time(self) -> pulumi.Output[str]:
        """
        The optional parameter that defines the sync start time when the sync frequency is already set or being set by the current request to 1440. It can be specified in one hour increments starting from 00:00 to 23:00. If not specified, we will use [the baseline sync start time](https://fivetran.com/docs/getting-started/syncoverview#syncfrequencyandscheduling). This parameter has no effect on the [0 to 60 minutes offset](https://fivetran.com/docs/getting-started/syncoverview#syncstarttimesandoffsets) used to determine the actual sync start time.
        """
        return pulumi.get(self, "daily_sync_time")

    @property
    @pulumi.getter(name="pauseAfterTrial")
    def pause_after_trial(self) -> pulumi.Output[str]:
        """
        Specifies whether the connector should be paused after the free trial period has ended.
        """
        return pulumi.get(self, "pause_after_trial")

    @property
    @pulumi.getter
    def paused(self) -> pulumi.Output[str]:
        """
        Specifies whether the connector is paused.
        """
        return pulumi.get(self, "paused")

    @property
    @pulumi.getter(name="scheduleType")
    def schedule_type(self) -> pulumi.Output[str]:
        """
        The connector schedule configuration type. Supported values: auto, manual.
        """
        return pulumi.get(self, "schedule_type")

    @property
    @pulumi.getter(name="syncFrequency")
    def sync_frequency(self) -> pulumi.Output[str]:
        """
        The connector sync frequency in minutes. Supported values: 1, 5, 15, 30, 60, 120, 180, 360, 480, 720, 1440.
        """
        return pulumi.get(self, "sync_frequency")

