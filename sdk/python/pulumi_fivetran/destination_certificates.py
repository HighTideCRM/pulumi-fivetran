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

__all__ = ['DestinationCertificatesArgs', 'DestinationCertificates']

@pulumi.input_type
class DestinationCertificatesArgs:
    def __init__(__self__, *,
                 destination_id: pulumi.Input[str],
                 certificates: Optional[pulumi.Input[Sequence[pulumi.Input['DestinationCertificatesCertificateArgs']]]] = None):
        """
        The set of arguments for constructing a DestinationCertificates resource.
        :param pulumi.Input[str] destination_id: The unique identifier for the target destination within the Fivetran system.
        """
        pulumi.set(__self__, "destination_id", destination_id)
        if certificates is not None:
            pulumi.set(__self__, "certificates", certificates)

    @property
    @pulumi.getter(name="destinationId")
    def destination_id(self) -> pulumi.Input[str]:
        """
        The unique identifier for the target destination within the Fivetran system.
        """
        return pulumi.get(self, "destination_id")

    @destination_id.setter
    def destination_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "destination_id", value)

    @property
    @pulumi.getter
    def certificates(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DestinationCertificatesCertificateArgs']]]]:
        return pulumi.get(self, "certificates")

    @certificates.setter
    def certificates(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DestinationCertificatesCertificateArgs']]]]):
        pulumi.set(self, "certificates", value)


@pulumi.input_type
class _DestinationCertificatesState:
    def __init__(__self__, *,
                 certificates: Optional[pulumi.Input[Sequence[pulumi.Input['DestinationCertificatesCertificateArgs']]]] = None,
                 destination_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DestinationCertificates resources.
        :param pulumi.Input[str] destination_id: The unique identifier for the target destination within the Fivetran system.
        """
        if certificates is not None:
            pulumi.set(__self__, "certificates", certificates)
        if destination_id is not None:
            pulumi.set(__self__, "destination_id", destination_id)

    @property
    @pulumi.getter
    def certificates(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['DestinationCertificatesCertificateArgs']]]]:
        return pulumi.get(self, "certificates")

    @certificates.setter
    def certificates(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['DestinationCertificatesCertificateArgs']]]]):
        pulumi.set(self, "certificates", value)

    @property
    @pulumi.getter(name="destinationId")
    def destination_id(self) -> Optional[pulumi.Input[str]]:
        """
        The unique identifier for the target destination within the Fivetran system.
        """
        return pulumi.get(self, "destination_id")

    @destination_id.setter
    def destination_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "destination_id", value)


class DestinationCertificates(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificates: Optional[pulumi.Input[Sequence[pulumi.Input[Union['DestinationCertificatesCertificateArgs', 'DestinationCertificatesCertificateArgsDict']]]]] = None,
                 destination_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a DestinationCertificates resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] destination_id: The unique identifier for the target destination within the Fivetran system.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DestinationCertificatesArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DestinationCertificates resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DestinationCertificatesArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DestinationCertificatesArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 certificates: Optional[pulumi.Input[Sequence[pulumi.Input[Union['DestinationCertificatesCertificateArgs', 'DestinationCertificatesCertificateArgsDict']]]]] = None,
                 destination_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DestinationCertificatesArgs.__new__(DestinationCertificatesArgs)

            __props__.__dict__["certificates"] = certificates
            if destination_id is None and not opts.urn:
                raise TypeError("Missing required property 'destination_id'")
            __props__.__dict__["destination_id"] = destination_id
        super(DestinationCertificates, __self__).__init__(
            'fivetran:index/destinationCertificates:DestinationCertificates',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            certificates: Optional[pulumi.Input[Sequence[pulumi.Input[Union['DestinationCertificatesCertificateArgs', 'DestinationCertificatesCertificateArgsDict']]]]] = None,
            destination_id: Optional[pulumi.Input[str]] = None) -> 'DestinationCertificates':
        """
        Get an existing DestinationCertificates resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] destination_id: The unique identifier for the target destination within the Fivetran system.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DestinationCertificatesState.__new__(_DestinationCertificatesState)

        __props__.__dict__["certificates"] = certificates
        __props__.__dict__["destination_id"] = destination_id
        return DestinationCertificates(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def certificates(self) -> pulumi.Output[Optional[Sequence['outputs.DestinationCertificatesCertificate']]]:
        return pulumi.get(self, "certificates")

    @property
    @pulumi.getter(name="destinationId")
    def destination_id(self) -> pulumi.Output[str]:
        """
        The unique identifier for the target destination within the Fivetran system.
        """
        return pulumi.get(self, "destination_id")

