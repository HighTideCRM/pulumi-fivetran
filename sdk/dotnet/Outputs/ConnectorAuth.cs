// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Fivetran.Outputs
{

    [OutputType]
    public sealed class ConnectorAuth
    {
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `autodesk_bim_360`: Your Autodesk BIM 360 Access Token.
        /// 	- Service `azure_sql_db`: The long-lived Access token carries the information necessary to access API resources.
        /// 	- Service `azure_sql_managed_db`: The long-lived Access token carries the information necessary to access API resources.
        /// 	- Service `billing_platform`: Your BillingPlatform access token.
        /// 	- Service `calendly`: Your Calendly access token.
        /// 	- Service `docebo`: Your Docebo Access Token.
        /// 	- Service `drift`: Your Drift access token.
        /// 	- Service `employment_hero`: Your Employment Hero access token.
        /// 	- Service `facebook_ads`: The long-lived `Access token` along with the `client_id` and `client_secret` parameters carry the information necessary to query the Facebook Ads API
        /// 	- Service `facebook_pages`: The `Access Token` carries the information necessary for API resources to fetch data
        /// 	- Service `freshbooks`: Your FreshBooks Access Token.
        /// 	- Service `gitlab`: Your GitLab access token.
        /// 	- Service `google_business_profile`: Your Google Business Profile Access token.
        /// 	- Service `google_calendar`: Your Google Calendar access token.
        /// 	- Service `google_classroom`: The `Access Token` that carries the information necessary for API resources to fetch data.
        /// 	- Service `google_tasks`: The access token that carries the information necessary for API resources to your Google Tasks fetch data.
        /// 	- Service `instagram_business`: The `Access Token` carries the information necessary for API resources to fetch data
        /// 	- Service `intercom`: The long-lived `Access Token` carries the information necessary for API resources to fetch data.
        /// 	- Service `medallia`: Your Medallia access token that contains all the information necessary for the API resources to fetch your data.
        /// 	- Service `pinterest_organic`: Your Pinterest access token.
        /// 	- Service `ramp`: Your Ramp access token.
        /// 	- Service `ringcentral`: The long-lived `Access token` carries the information necessary to access API resources.
        /// 	- Service `shopify`: The Shopify access token.
        /// 	- Service `slack`: Your Slack access token.
        /// 	- Service `stripe`: The Stripe API Restricted Key
        /// 	- Service `stripe_test`: The Stripe API Restricted Key
        /// 	- Service `survey_monkey`: The long-lived `Access token` carries the information necessary to access API resources.
        /// 	- Service `tiktok_ads`: The long-lived `Access token` carries the information necessary to access API resources.
        /// 	- Service `typeform`: The Typeform API access token.
        /// 	- Service `yahoo_search_ads_yahoo_japan`: Your Yahoo Search Ads Access Token.
        /// 	- Service `zendesk`: The long-lived `Access token` carries the information necessary to access API resources.
        /// 	- Service `zendesk_chat`: The long-lived `Access token` carries the information necessary to access API resources.
        /// 	- Service `zendesk_sell`: The long-lived `Access token` carries the information necessary to access API resources.
        /// 	- Service `zoom`: Your Zoom Access token.
        /// </summary>
        public readonly string? AccessToken;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `elastic_cloud`: The Elasticsearch API key. If omitted, then basic user and password authentication will apply.
        /// 	- Service `es_self_hosted`: The Elasticsearch API key. If omitted, then basic user and password authentication will apply.
        /// </summary>
        public readonly string? ApiKey;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amazon_selling_partner`: `AWS Access Key` of your AWS Account User.
        /// </summary>
        public readonly string? AwsAccessKey;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amazon_selling_partner`: `AWS Secret Key` of your AWS Account User.
        /// </summary>
        public readonly string? AwsSecretKey;
        public readonly Outputs.ConnectorAuthClientAccess? ClientAccess;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amazon_selling_partner`: `Client ID` of your Amazon Seller/Vendor Central client application.
        /// 	- Service `apple_search_ads`: Apple Search Ads REST API Client ID. Must be populated if `is_auth2_enabled` is set to `true`.
        /// 	- Service `workday`: Client ID
        /// 	- Service `workday_financial_management`: ID of your Workday Client App
        /// 	- Service `workday_hcm`: ID of your Workday Client App
        /// 	- Service `yahoo_dsp`: Your Yahoo DSP Client ID.
        /// </summary>
        public readonly string? ClientId;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amazon_selling_partner`: `Client Secret` of your Amazon Seller/Vendor Central client application.
        /// 	- Service `workday`: Client Secret
        /// 	- Service `workday_financial_management`: Secret of your Workday Client App
        /// 	- Service `workday_hcm`: Secret of your Workday Client App
        /// 	- Service `yahoo_dsp`: Your Yahoo DSP Client Secret.
        /// </summary>
        public readonly string? ClientSecret;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `twitter`: API Key of your app
        /// 	- Service `twitter_ads`: The Twitter App consumer key.
        /// </summary>
        public readonly string? ConsumerKey;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `twitter`: API Secret of your app
        /// 	- Service `twitter_ads`: The Twitter App consumer secret.
        /// </summary>
        public readonly string? ConsumerSecret;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `apple_search_ads`: Apple Search Ads REST API Key ID. Must be populated if `is_auth2_enabled` is set to `true`.
        /// </summary>
        public readonly string? KeyId;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `twitter`: The Twitter App access token.
        /// 	- Service `twitter_ads`: The Twitter App access token.
        /// </summary>
        public readonly string? OauthToken;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `twitter`: The Twitter App access token secret.
        /// 	- Service `twitter_ads`: The Twitter App access token secret.
        /// </summary>
        public readonly string? OauthTokenSecret;
        public readonly string? OcapiAccessToken;
        public readonly string? OcapiRefreshToken;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `dynamics_365`: Previous `Refresh token` of your application.
        /// </summary>
        public readonly string? PreviousRefreshToken;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `quickbooks`: `Realm ID` of your QuickBooks application.
        /// </summary>
        public readonly string? RealmId;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `adroll`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `airtable`: The long-lived refresh token along with the client ID and client secret carry the information necessary to get a new access token for API resources.
        /// 	- Service `amazon_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `amazon_selling_partner`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `asana`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `autodesk_bim_360`: Your Autodesk BIM 360 Refresh Token.
        /// 	- Service `azure_service_bus`: The refresh token. Required if the authentication type is `AzureActiveDirectory`
        /// 	- Service `azure_sql_db`: The long-lived Refresh token carries the information necessary to get a new access token for API resources.
        /// 	- Service `azure_sql_managed_db`: The long-lived Refresh token carries the information necessary to get a new access token for API resources.
        /// 	- Service `billing_platform`: Your BillingPlatform refresh token.
        /// 	- Service `bingads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `business_central`: The long-lived refresh token along with the client ID and client secret parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `calendly`: Your Calendly refresh token.
        /// 	- Service `docebo`: Your Docebo Refresh Token.
        /// 	- Service `double_click_campaign_manager`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `double_click_publishers`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `drift`: Your Drift refresh token.
        /// 	- Service `dropbox`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `dynamics_365`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `employment_hero`: Your Employment Hero refresh token.
        /// 	- Service `financial_force`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `freshbooks`: Your FreshBooks Refresh Token.
        /// 	- Service `front`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `gitlab`: Your GitLab refresh token.
        /// 	- Service `google_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_analytics`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_analytics_4`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_analytics_mcf`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_business_profile`: Your Google Business Profile Refresh token.
        /// 	- Service `google_calendar`: Your Google Calendar refresh token.
        /// 	- Service `google_classroom`: The long-lived `Refresh token` of your Google Calendar client application.
        /// 	- Service `google_display_and_video_360`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_play`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_search_ads_360`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_sheets`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `google_tasks`: The long-lived refresh token of your Google Tasks client application.
        /// 	- Service `helpscout`: The long-lived `refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `hubspot`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `linkedin_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `linkedin_company_pages`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `microsoft_lists`: The long-lived Refresh token carries the information necessary to get a new access token for API resources.
        /// 	- Service `one_drive`: The long-lived `Refresh token` carries the information necessary to get a new access token for API resources.
        /// 	- Service `optimizely`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `outreach`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `pinterest_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `pinterest_organic`: Your Pinterest refresh token.
        /// 	- Service `pipedrive`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `qualtrics`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `quickbooks`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `ramp`: Your Ramp refresh token.
        /// 	- Service `reddit_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `salesforce`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `salesforce_sandbox`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `salesloft`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `share_point`: The long-lived Refresh token carries the information necessary to get a new access token for API resources.
        /// 	- Service `slack`: Your Slack refresh token.
        /// 	- Service `snapchat_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `spotify_ads`: The long-lived `Refresh token` along with the `client_id` and `client_secret` parameters carry the information necessary to get a new access token for API resources.
        /// 	- Service `typeform`: The Typeform API refresh token.
        /// 	- Service `workday`: OAuth Refresh Token
        /// 	- Service `yahoo_search_ads_yahoo_japan`: Your Yahoo Search Ads Refresh Token.
        /// 	- Service `zoho_crm`: The long-lived `Refresh token`, along with the `client_id` and `client_secret` parameters, carries the information necessary to get a new access token for API resources.
        /// 	- Service `zoom`: Your Zoom Refresh token.
        /// </summary>
        public readonly string? RefreshToken;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `amazon_selling_partner`: `IAM Role ARN` of your AWS Account.
        /// </summary>
        public readonly string? RoleArn;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `apple_search_ads`: Apple Search Ads REST API Team ID. Must be populated if `is_auth2_enabled` is set to `true`.
        /// </summary>
        public readonly string? TeamId;
        /// <summary>
        /// Field usage depends on `service` value: 
        /// 	- Service `facebook_ads`: Access Token
        /// </summary>
        public readonly string? UserAccessToken;

        [OutputConstructor]
        private ConnectorAuth(
            string? accessToken,

            string? apiKey,

            string? awsAccessKey,

            string? awsSecretKey,

            Outputs.ConnectorAuthClientAccess? clientAccess,

            string? clientId,

            string? clientSecret,

            string? consumerKey,

            string? consumerSecret,

            string? keyId,

            string? oauthToken,

            string? oauthTokenSecret,

            string? ocapiAccessToken,

            string? ocapiRefreshToken,

            string? previousRefreshToken,

            string? realmId,

            string? refreshToken,

            string? roleArn,

            string? teamId,

            string? userAccessToken)
        {
            AccessToken = accessToken;
            ApiKey = apiKey;
            AwsAccessKey = awsAccessKey;
            AwsSecretKey = awsSecretKey;
            ClientAccess = clientAccess;
            ClientId = clientId;
            ClientSecret = clientSecret;
            ConsumerKey = consumerKey;
            ConsumerSecret = consumerSecret;
            KeyId = keyId;
            OauthToken = oauthToken;
            OauthTokenSecret = oauthTokenSecret;
            OcapiAccessToken = ocapiAccessToken;
            OcapiRefreshToken = ocapiRefreshToken;
            PreviousRefreshToken = previousRefreshToken;
            RealmId = realmId;
            RefreshToken = refreshToken;
            RoleArn = roleArn;
            TeamId = teamId;
            UserAccessToken = userAccessToken;
        }
    }
}
