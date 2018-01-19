#if ENABLE_PLAYFABENTITY_API
using PlayFab.EntityModels;

namespace PlayFab.Events
{
    public partial class PlayFabEvents
    {
        public event PlayFabRequestEvent<AbortFileUploadsRequest> OnEntityAbortFileUploadsRequestEvent;
        public event PlayFabResultEvent<AbortFileUploadsResponse> OnEntityAbortFileUploadsResultEvent;
        public event PlayFabRequestEvent<DeleteFilesRequest> OnEntityDeleteFilesRequestEvent;
        public event PlayFabResultEvent<DeleteFilesResponse> OnEntityDeleteFilesResultEvent;
        public event PlayFabRequestEvent<FinalizeFileUploadsRequest> OnEntityFinalizeFileUploadsRequestEvent;
        public event PlayFabResultEvent<FinalizeFileUploadsResponse> OnEntityFinalizeFileUploadsResultEvent;
        public event PlayFabRequestEvent<GetEntityTokenRequest> OnEntityGetEntityTokenRequestEvent;
        public event PlayFabResultEvent<GetEntityTokenResponse> OnEntityGetEntityTokenResultEvent;
        public event PlayFabRequestEvent<GetFilesRequest> OnEntityGetFilesRequestEvent;
        public event PlayFabResultEvent<GetFilesResponse> OnEntityGetFilesResultEvent;
        public event PlayFabRequestEvent<GetObjectsRequest> OnEntityGetObjectsRequestEvent;
        public event PlayFabResultEvent<GetObjectsResponse> OnEntityGetObjectsResultEvent;
        public event PlayFabRequestEvent<GetEntityProfileRequest> OnEntityGetProfileRequestEvent;
        public event PlayFabResultEvent<GetEntityProfileResponse> OnEntityGetProfileResultEvent;
        public event PlayFabRequestEvent<InitiateFileUploadsRequest> OnEntityInitiateFileUploadsRequestEvent;
        public event PlayFabResultEvent<InitiateFileUploadsResponse> OnEntityInitiateFileUploadsResultEvent;
        public event PlayFabRequestEvent<SetObjectsRequest> OnEntitySetObjectsRequestEvent;
        public event PlayFabResultEvent<SetObjectsResponse> OnEntitySetObjectsResultEvent;
        public event PlayFabRequestEvent<SetEntityProfilePolicyRequest> OnEntitySetProfilePolicyRequestEvent;
        public event PlayFabResultEvent<SetEntityProfilePolicyResponse> OnEntitySetProfilePolicyResultEvent;
    }
}
#endif
