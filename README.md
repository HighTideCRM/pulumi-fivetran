# Fivetran Resource Provider

The Foo Resource Provider lets you manage [Fivetran](https://fivetran.com) resources.

## Installing

This package is available for several languages/platforms:

### Node.js (JavaScript/TypeScript)

To use from JavaScript or TypeScript in Node.js, install using either `npm`:

```bash
npm install @hightidecrm/pulumi-fivetran
```

or `yarn`:

```bash
yarn add @hightidecrm/pulumi-fivetran
```

<!-- ### Python

To use from Python, install using `pip`:

```bash
pip install pulumi_foo
``` -->

### Go

To use from Go, use `go get` to grab the latest version of the library:

```bash
go get github.com/HighTideCRM/pulumi-fivetran/sdk/go/...
```

<!-- ### .NET

To use from .NET, install using `dotnet add package`:

```bash
dotnet add package Pulumi.Foo
``` -->

## Configuration

The following configuration points are available for the `fivetran` provider:

- `fivetran:apiKey` (environment: `FIVETRAN_API_KEY`) - the API key for `fivetran`
- `fivetran:apiSecret` (environment: `FIVETRAN_API_SECRET`) - the API secret key for fivetran
- `fivetran:apiUrl` - The API url to use to connect to Fivetran

## Reference

For detailed reference documentation, please visit [the Pulumi registry](https://www.pulumi.com/registry/packages/fivetran/api-docs/).
