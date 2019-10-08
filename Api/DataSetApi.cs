/* 
 * BlackFox
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp.Portable;
using BlackFoxCSharp.Client;

namespace BlackFoxCSharp.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IDataSetApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Download dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>System.IO.Stream</returns>
        System.IO.Stream Get (string id);

        /// <summary>
        /// Download dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        ApiResponse<System.IO.Stream> GetWithHttpInfo (string id);
        /// <summary>
        /// Check if dataset file exist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns></returns>
        void Head (string id);

        /// <summary>
        /// Check if dataset file exist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> HeadWithHttpInfo (string id);
        /// <summary>
        /// Upload dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>string</returns>
        string Post (System.IO.Stream file = null);

        /// <summary>
        /// Upload dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        ApiResponse<string> PostWithHttpInfo (System.IO.Stream file = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Download dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>Task of System.IO.Stream</returns>
        System.Threading.Tasks.Task<System.IO.Stream> GetAsync (string id);

        /// <summary>
        /// Download dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetAsyncWithHttpInfo (string id);
        /// <summary>
        /// Check if dataset file exist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task HeadAsync (string id);

        /// <summary>
        /// Check if dataset file exist
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> HeadAsyncWithHttpInfo (string id);
        /// <summary>
        /// Upload dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>Task of string</returns>
        System.Threading.Tasks.Task<string> PostAsync (System.IO.Stream file = null);

        /// <summary>
        /// Upload dataset file (*.csv)
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        System.Threading.Tasks.Task<ApiResponse<string>> PostAsyncWithHttpInfo (System.IO.Stream file = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class DataSetApi : IDataSetApi
    {
        private BlackFoxCSharp.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class.
        /// </summary>
        /// <returns></returns>
        public DataSetApi(String basePath)
        {
            this.Configuration = new BlackFoxCSharp.Client.Configuration { BasePath = basePath };

            ExceptionFactory = BlackFoxCSharp.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataSetApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public DataSetApi(BlackFoxCSharp.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = BlackFoxCSharp.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = BlackFoxCSharp.Client.Configuration.DefaultExceptionFactory;
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
        public BlackFoxCSharp.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public BlackFoxCSharp.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
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
        /// Download dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>System.IO.Stream</returns>
        public System.IO.Stream Get (string id)
        {
             ApiResponse<System.IO.Stream> localVarResponse = GetWithHttpInfo(id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Download dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>ApiResponse of System.IO.Stream</returns>
        public ApiResponse< System.IO.Stream > GetWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DataSetApi->Get");

            var localVarPath = "./api/dataset/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Download dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>Task of System.IO.Stream</returns>
        public async System.Threading.Tasks.Task<System.IO.Stream> GetAsync (string id)
        {
             ApiResponse<System.IO.Stream> localVarResponse = await GetAsyncWithHttpInfo(id);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Download dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id</param>
        /// <returns>Task of ApiResponse (System.IO.Stream)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<System.IO.Stream>> GetAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DataSetApi->Get");

            var localVarPath = "./api/dataset/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/octet-stream"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Get", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<System.IO.Stream>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (System.IO.Stream) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(System.IO.Stream)));
        }

        /// <summary>
        /// Check if dataset file exist 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns></returns>
        public void Head (string id)
        {
             HeadWithHttpInfo(id);
        }

        /// <summary>
        /// Check if dataset file exist 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> HeadWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DataSetApi->Head");

            var localVarPath = "./api/dataset/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.HEAD, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Head", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Check if dataset file exist 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task HeadAsync (string id)
        {
             await HeadAsyncWithHttpInfo(id);

        }

        /// <summary>
        /// Check if dataset file exist 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Dataset Id (sha1)</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> HeadAsyncWithHttpInfo (string id)
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new ApiException(400, "Missing required parameter 'id' when calling DataSetApi->Head");

            var localVarPath = "./api/dataset/{id}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (id != null) localVarPathParams.Add("id", this.Configuration.ApiClient.ParameterToString(id)); // path parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.HEAD, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Head", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Upload dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>string</returns>
        public string Post (System.IO.Stream file = null)
        {
             ApiResponse<string> localVarResponse = PostWithHttpInfo(file);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>ApiResponse of string</returns>
        public ApiResponse< string > PostWithHttpInfo (System.IO.Stream file = null)
        {

            var localVarPath = "./api/dataset";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (file != null) localVarFileParams.Add("file", this.Configuration.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Post", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

        /// <summary>
        /// Upload dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>Task of string</returns>
        public async System.Threading.Tasks.Task<string> PostAsync (System.IO.Stream file = null)
        {
             ApiResponse<string> localVarResponse = await PostAsyncWithHttpInfo(file);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Upload dataset file (*.csv) 
        /// </summary>
        /// <exception cref="BlackFoxCSharp.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file"> (optional)</param>
        /// <returns>Task of ApiResponse (string)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<string>> PostAsyncWithHttpInfo (System.IO.Stream file = null)
        {

            var localVarPath = "./api/dataset";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "multipart/form-data"
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (file != null) localVarFileParams.Add("file", this.Configuration.ApiClient.ParameterToFile("file", file));


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Post", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<string>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Key, x => x.Value.ToString()),
                (string) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(string)));
        }

    }
}