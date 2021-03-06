/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the signer-2017-08-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.Signer.Model;
using Amazon.Signer.Model.Internal.MarshallTransformations;
using Amazon.Signer.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.Signer
{
    /// <summary>
    /// Implementation for accessing Signer
    ///
    /// You can use Code Signing for Amazon FreeRTOS (AWS Signer) to sign code that you created
    /// for any of the IoT devices that Amazon Web Services supports. AWS Signer is integrated
    /// with Amazon FreeRTOS, AWS Certificate Manager, and AWS CloudTrail. Amazon FreeRTOS
    /// customers can use AWS Signer to sign code images before making them available for
    /// microcontrollers. You can use ACM to import third-party certificates to be used by
    /// AWS Signer. For general information about using AWS Signer, see the <a href="http://docs.aws.amazon.com/signer/latest/developerguide/Welcome.html">Code
    /// Signing for Amazon FreeRTOS Developer Guide</a>.
    /// </summary>
    public partial class AmazonSignerClient : AmazonServiceClient, IAmazonSigner
    {
        private static IServiceMetadata serviceMetadata = new AmazonSignerMetadata();
        
        #region Constructors

#if NETSTANDARD
    
        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonSignerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerConfig()) { }

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonSignerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonSignerClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(AmazonSignerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

#endif

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonSignerClient(AWSCredentials credentials)
            : this(credentials, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonSignerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Credentials and an
        /// AmazonSignerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(AWSCredentials credentials, AmazonSignerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonSignerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonSignerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonSignerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonSignerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonSignerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonSignerClient Configuration Object</param>
        public AmazonSignerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonSignerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  CancelSigningProfile

        internal virtual CancelSigningProfileResponse CancelSigningProfile(CancelSigningProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSigningProfileResponseUnmarshaller.Instance;

            return Invoke<CancelSigningProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSigningProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/CancelSigningProfile">REST API Reference for CancelSigningProfile Operation</seealso>
        public virtual Task<CancelSigningProfileResponse> CancelSigningProfileAsync(CancelSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSigningProfileResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSigningProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSigningJob

        internal virtual DescribeSigningJobResponse DescribeSigningJob(DescribeSigningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSigningJobResponseUnmarshaller.Instance;

            return Invoke<DescribeSigningJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSigningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/DescribeSigningJob">REST API Reference for DescribeSigningJob Operation</seealso>
        public virtual Task<DescribeSigningJobResponse> DescribeSigningJobAsync(DescribeSigningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSigningJobResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSigningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSigningPlatform

        internal virtual GetSigningPlatformResponse GetSigningPlatform(GetSigningPlatformRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningPlatformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningPlatformResponseUnmarshaller.Instance;

            return Invoke<GetSigningPlatformResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningPlatform operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningPlatform operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningPlatform">REST API Reference for GetSigningPlatform Operation</seealso>
        public virtual Task<GetSigningPlatformResponse> GetSigningPlatformAsync(GetSigningPlatformRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningPlatformRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningPlatformResponseUnmarshaller.Instance;

            return InvokeAsync<GetSigningPlatformResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSigningProfile

        internal virtual GetSigningProfileResponse GetSigningProfile(GetSigningProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningProfileResponseUnmarshaller.Instance;

            return Invoke<GetSigningProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSigningProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/GetSigningProfile">REST API Reference for GetSigningProfile Operation</seealso>
        public virtual Task<GetSigningProfileResponse> GetSigningProfileAsync(GetSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSigningProfileResponseUnmarshaller.Instance;

            return InvokeAsync<GetSigningProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSigningJobs

        internal virtual ListSigningJobsResponse ListSigningJobs(ListSigningJobsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningJobsResponseUnmarshaller.Instance;

            return Invoke<ListSigningJobsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningJobs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningJobs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningJobs">REST API Reference for ListSigningJobs Operation</seealso>
        public virtual Task<ListSigningJobsResponse> ListSigningJobsAsync(ListSigningJobsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningJobsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningJobsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSigningJobsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSigningPlatforms

        internal virtual ListSigningPlatformsResponse ListSigningPlatforms(ListSigningPlatformsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningPlatformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningPlatformsResponseUnmarshaller.Instance;

            return Invoke<ListSigningPlatformsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningPlatforms operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningPlatforms operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningPlatforms">REST API Reference for ListSigningPlatforms Operation</seealso>
        public virtual Task<ListSigningPlatformsResponse> ListSigningPlatformsAsync(ListSigningPlatformsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningPlatformsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningPlatformsResponseUnmarshaller.Instance;

            return InvokeAsync<ListSigningPlatformsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListSigningProfiles

        internal virtual ListSigningProfilesResponse ListSigningProfiles(ListSigningProfilesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningProfilesResponseUnmarshaller.Instance;

            return Invoke<ListSigningProfilesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ListSigningProfiles operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListSigningProfiles operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/ListSigningProfiles">REST API Reference for ListSigningProfiles Operation</seealso>
        public virtual Task<ListSigningProfilesResponse> ListSigningProfilesAsync(ListSigningProfilesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListSigningProfilesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListSigningProfilesResponseUnmarshaller.Instance;

            return InvokeAsync<ListSigningProfilesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutSigningProfile

        internal virtual PutSigningProfileResponse PutSigningProfile(PutSigningProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSigningProfileResponseUnmarshaller.Instance;

            return Invoke<PutSigningProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PutSigningProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutSigningProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/PutSigningProfile">REST API Reference for PutSigningProfile Operation</seealso>
        public virtual Task<PutSigningProfileResponse> PutSigningProfileAsync(PutSigningProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutSigningProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutSigningProfileResponseUnmarshaller.Instance;

            return InvokeAsync<PutSigningProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartSigningJob

        internal virtual StartSigningJobResponse StartSigningJob(StartSigningJobRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSigningJobResponseUnmarshaller.Instance;

            return Invoke<StartSigningJobResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartSigningJob operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSigningJob operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/signer-2017-08-25/StartSigningJob">REST API Reference for StartSigningJob Operation</seealso>
        public virtual Task<StartSigningJobResponse> StartSigningJobAsync(StartSigningJobRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartSigningJobRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartSigningJobResponseUnmarshaller.Instance;

            return InvokeAsync<StartSigningJobResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}