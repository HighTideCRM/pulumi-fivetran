// Code generated by the Pulumi Terraform Bridge (tfgen) Tool DO NOT EDIT.
// *** WARNING: Do not edit by hand unless you're certain you know what you are doing! ***

package config

import (
	"github.com/HighTideCRM/pulumi-fivetran/sdk/go/fivetran/internal"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi"
	"github.com/pulumi/pulumi/sdk/v3/go/pulumi/config"
)

var _ = internal.GetEnvOrDefault

func GetApiKey(ctx *pulumi.Context) string {
	return config.Get(ctx, "fivetran:apiKey")
}
func GetApiSecret(ctx *pulumi.Context) string {
	return config.Get(ctx, "fivetran:apiSecret")
}
func GetApiUrl(ctx *pulumi.Context) string {
	return config.Get(ctx, "fivetran:apiUrl")
}
