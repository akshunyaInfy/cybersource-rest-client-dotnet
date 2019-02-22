/* 
 * CyberSource Flex API
 *
 * Simple PAN tokenization service
 *
 * OpenAPI spec version: 0.0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using CyberSource.Client;
using CyberSource.Model;

namespace CyberSource.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUserManagementApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>UmsV1UsersGet200Response</returns>
        UmsV1UsersGet200Response GetUsers (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);

        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        ApiResponse<UmsV1UsersGet200Response> GetUsersWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        System.Threading.Tasks.Task<UmsV1UsersGet200Response> GetUsersAsync (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);

        /// <summary>
        /// Get user based on organization Id, username, permission and role
        /// </summary>
        /// <remarks>
        /// This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </remarks>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        System.Threading.Tasks.Task<ApiResponse<UmsV1UsersGet200Response>> GetUsersAsyncWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UserManagementApi : IUserManagementApi
    {
        private CyberSource.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UserManagementApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManagementApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UserManagementApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = CyberSource.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public CyberSource.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get user based on organization Id, username, permission and role This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>UmsV1UsersGet200Response</returns>
        public UmsV1UsersGet200Response GetUsers (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {
             ApiResponse<UmsV1UsersGet200Response> localVarResponse = GetUsersWithHttpInfo(organizationId, userName, permissionId, roleId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get user based on organization Id, username, permission and role This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>ApiResponse of UmsV1UsersGet200Response</returns>
        public ApiResponse< UmsV1UsersGet200Response > GetUsersWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {

            var localVarPath = $"/ums/v1/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            if (userName != null) localVarQueryParams.Add("userName", Configuration.ApiClient.ParameterToString(userName)); // query parameter
            if (permissionId != null) localVarQueryParams.Add("permissionId", Configuration.ApiClient.ParameterToString(permissionId)); // query parameter
            if (roleId != null) localVarQueryParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UmsV1UsersGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UmsV1UsersGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UmsV1UsersGet200Response)));
        }

        /// <summary>
        /// Get user based on organization Id, username, permission and role This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of UmsV1UsersGet200Response</returns>
        public async System.Threading.Tasks.Task<UmsV1UsersGet200Response> GetUsersAsync (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {
             ApiResponse<UmsV1UsersGet200Response> localVarResponse = await GetUsersAsyncWithHttpInfo(organizationId, userName, permissionId, roleId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get user based on organization Id, username, permission and role This endpoint is to get all the user information depending on the filter criteria passed in the query.
        /// </summary>
        /// <exception cref="CyberSource.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="organizationId">This is the orgId of the organization which the user belongs to. (optional)</param>
        /// <param name="userName">User ID of the user you want to get details on. (optional)</param>
        /// <param name="permissionId">permission that you are trying to search user on. (optional)</param>
        /// <param name="roleId">role of the user you are trying to search on. (optional)</param>
        /// <returns>Task of ApiResponse (UmsV1UsersGet200Response)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<UmsV1UsersGet200Response>> GetUsersAsyncWithHttpInfo (string organizationId = null, string userName = null, string permissionId = null, string roleId = null)
        {

            var localVarPath = $"/ums/v1/users";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (organizationId != null) localVarQueryParams.Add("organizationId", Configuration.ApiClient.ParameterToString(organizationId)); // query parameter
            if (userName != null) localVarQueryParams.Add("userName", Configuration.ApiClient.ParameterToString(userName)); // query parameter
            if (permissionId != null) localVarQueryParams.Add("permissionId", Configuration.ApiClient.ParameterToString(permissionId)); // query parameter
            if (roleId != null) localVarQueryParams.Add("roleId", Configuration.ApiClient.ParameterToString(roleId)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetUsers", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<UmsV1UsersGet200Response>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (UmsV1UsersGet200Response) Configuration.ApiClient.Deserialize(localVarResponse, typeof(UmsV1UsersGet200Response)));
        }

    }
}
