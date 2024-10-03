# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from . import _utilities
from . import outputs
from ._inputs import *

__all__ = [
    'GetExternalLoggingResult',
    'AwaitableGetExternalLoggingResult',
    'get_external_logging',
    'get_external_logging_output',
]

@pulumi.output_type
class GetExternalLoggingResult:
    """
    A collection of values returned by getExternalLogging.
    """
    def __init__(__self__, config=None, enabled=None, group_id=None, id=None, run_setup_tests=None, service=None):
        if config and not isinstance(config, dict):
            raise TypeError("Expected argument 'config' to be a dict")
        pulumi.set(__self__, "config", config)
        if enabled and not isinstance(enabled, bool):
            raise TypeError("Expected argument 'enabled' to be a bool")
        pulumi.set(__self__, "enabled", enabled)
        if group_id and not isinstance(group_id, str):
            raise TypeError("Expected argument 'group_id' to be a str")
        pulumi.set(__self__, "group_id", group_id)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if run_setup_tests and not isinstance(run_setup_tests, bool):
            raise TypeError("Expected argument 'run_setup_tests' to be a bool")
        pulumi.set(__self__, "run_setup_tests", run_setup_tests)
        if service and not isinstance(service, str):
            raise TypeError("Expected argument 'service' to be a str")
        pulumi.set(__self__, "service", service)

    @property
    @pulumi.getter
    def config(self) -> Optional['outputs.GetExternalLoggingConfigResult']:
        return pulumi.get(self, "config")

    @property
    @pulumi.getter
    def enabled(self) -> bool:
        """
        The boolean value specifying whether the log service is enabled.
        """
        return pulumi.get(self, "enabled")

    @property
    @pulumi.getter(name="groupId")
    def group_id(self) -> str:
        """
        The unique identifier for the log service within the Fivetran system.
        """
        return pulumi.get(self, "group_id")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The unique identifier for the log service within the Fivetran system.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="runSetupTests")
    def run_setup_tests(self) -> Optional[bool]:
        """
        Specifies whether the setup tests should be run automatically. The default value is TRUE.
        """
        return pulumi.get(self, "run_setup_tests")

    @property
    @pulumi.getter
    def service(self) -> str:
        """
        The name for the log service type within the Fivetran system. We support the following log services: azure*monitor*log, cloudwatch, datadog*log, new*relic_log, splunkLog, stackdriver.
        """
        return pulumi.get(self, "service")


class AwaitableGetExternalLoggingResult(GetExternalLoggingResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetExternalLoggingResult(
            config=self.config,
            enabled=self.enabled,
            group_id=self.group_id,
            id=self.id,
            run_setup_tests=self.run_setup_tests,
            service=self.service)


def get_external_logging(config: Optional[Union['GetExternalLoggingConfigArgs', 'GetExternalLoggingConfigArgsDict']] = None,
                         id: Optional[str] = None,
                         run_setup_tests: Optional[bool] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetExternalLoggingResult:
    """
    This data source returns a logging service object.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_fivetran as fivetran

    extlog = fivetran.get_external_logging(id="anonymous_mystery")
    ```


    :param str id: The unique identifier for the log service within the Fivetran system.
    :param bool run_setup_tests: Specifies whether the setup tests should be run automatically. The default value is TRUE.
    """
    __args__ = dict()
    __args__['config'] = config
    __args__['id'] = id
    __args__['runSetupTests'] = run_setup_tests
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('fivetran:index/getExternalLogging:getExternalLogging', __args__, opts=opts, typ=GetExternalLoggingResult).value

    return AwaitableGetExternalLoggingResult(
        config=pulumi.get(__ret__, 'config'),
        enabled=pulumi.get(__ret__, 'enabled'),
        group_id=pulumi.get(__ret__, 'group_id'),
        id=pulumi.get(__ret__, 'id'),
        run_setup_tests=pulumi.get(__ret__, 'run_setup_tests'),
        service=pulumi.get(__ret__, 'service'))


@_utilities.lift_output_func(get_external_logging)
def get_external_logging_output(config: Optional[pulumi.Input[Optional[Union['GetExternalLoggingConfigArgs', 'GetExternalLoggingConfigArgsDict']]]] = None,
                                id: Optional[pulumi.Input[str]] = None,
                                run_setup_tests: Optional[pulumi.Input[Optional[bool]]] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetExternalLoggingResult]:
    """
    This data source returns a logging service object.

    ## Example Usage

    ```python
    import pulumi
    import pulumi_fivetran as fivetran

    extlog = fivetran.get_external_logging(id="anonymous_mystery")
    ```


    :param str id: The unique identifier for the log service within the Fivetran system.
    :param bool run_setup_tests: Specifies whether the setup tests should be run automatically. The default value is TRUE.
    """
    ...
