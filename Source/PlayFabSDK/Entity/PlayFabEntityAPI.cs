#if ENABLE_PLAYFABENTITY_API
using System;
using System.Collections.Generic;
using PlayFab.EntityModels;
using PlayFab.Internal;
using PlayFab.Json;
using PlayFab.Public;

namespace PlayFab
{
    /// <summary>
    /// API methods to control entity profiles. API methods for getting and setting objects on entity profiles. API methods for
    /// getting and setting files on entity profiles. API methods that allow fo exchanging legacy authentication mechanisms for
    /// a new Entity Token. Entity Tokens are required when calling Entity based APIs such as Entity Profile and Entity Data
    /// APIs.
    /// </summary>
    public static class PlayFabEntityAPI
    {
        static PlayFabEntityAPI() {}

        /// <summary>
        /// Clear the Client SessionToken which allows this Client to call API calls requiring login.
        /// A new/fresh login will be required after calling this.
        /// </summary>
        public static void ForgetAllCredentials()
        {
            PlayFabHttp.ForgetAllCredentials();
        }

        /// <summary>
        /// Abort pending file uploads to an entity's profile.
        /// </summary>
        public static void AbortFileUploads(AbortFileUploadsRequest request, Action<AbortFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/File/AbortFileUploads", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Delete files on an entity's profile.
        /// </summary>
        public static void DeleteFiles(DeleteFilesRequest request, Action<DeleteFilesResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/File/DeleteFiles", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Finalize file uploads to an entity's profile.
        /// </summary>
        public static void FinalizeFileUploads(FinalizeFileUploadsRequest request, Action<FinalizeFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/File/FinalizeFileUploads", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Method to exchange a legacy AuthenticationTicket or title SecretKey for an Entity Token.
        /// </summary>
        public static void GetEntityToken(GetEntityTokenRequest request, Action<GetEntityTokenResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {
            AuthType authType = AuthType.None;
#if !DISABLE_PLAYFABCLIENT_API
            if (authType == AuthType.None && PlayFabClientAPI.IsClientLoggedIn())
                authType = AuthType.LoginSession;
#endif
            if (authType == AuthType.None && !string.IsNullOrEmpty(PlayFabSettings.DeveloperSecretKey))
                authType = AuthType.DevSecretKey;

            PlayFabHttp.MakeApiCall("/Authentication/GetEntityToken", request, authType, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Retrieves file metadata from an entity's profile.
        /// </summary>
        public static void GetFiles(GetFilesRequest request, Action<GetFilesResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/File/GetFiles", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Retrieves objects from an entity's profile.
        /// </summary>
        public static void GetObjects(GetObjectsRequest request, Action<GetObjectsResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/Object/GetObjects", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Retrieves the entity's profile.
        /// </summary>
        public static void GetProfile(GetEntityProfileRequest request, Action<GetEntityProfileResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/Profile/GetProfile", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Initiates file uploads to an entity's profile.
        /// </summary>
        public static void InitiateFileUploads(InitiateFileUploadsRequest request, Action<InitiateFileUploadsResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/File/InitiateFileUploads", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Sets objects on an entity's profile.
        /// </summary>
        public static void SetObjects(SetObjectsRequest request, Action<SetObjectsResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/Object/SetObjects", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }

        /// <summary>
        /// Sets the profiles access policy
        /// </summary>
        public static void SetProfilePolicy(SetEntityProfilePolicyRequest request, Action<SetEntityProfilePolicyResponse> resultCallback, Action<PlayFabError> errorCallback, object customData = null, Dictionary<string, string> extraHeaders = null)
        {

            PlayFabHttp.MakeApiCall("/Profile/SetProfilePolicy", request, AuthType.EntityToken, resultCallback, errorCallback, customData, extraHeaders);
        }


    }
}
#endif
