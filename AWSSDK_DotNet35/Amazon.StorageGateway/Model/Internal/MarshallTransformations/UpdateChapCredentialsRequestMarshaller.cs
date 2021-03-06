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
 * Do not modify this file. This file is generated from the storagegateway-2013-06-30.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.StorageGateway.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.StorageGateway.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// UpdateChapCredentials Request Marshaller
    /// </summary>       
    public class UpdateChapCredentialsRequestMarshaller : IMarshaller<IRequest, UpdateChapCredentialsRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((UpdateChapCredentialsRequest)input);
        }

        public IRequest Marshall(UpdateChapCredentialsRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.StorageGateway");
            string target = "StorageGateway_20130630.UpdateChapCredentials";
            request.Headers["X-Amz-Target"] = target;
            request.Headers["Content-Type"] = "application/x-amz-json-1.1";
            request.HttpMethod = "POST";

            string uriResourcePath = "/";
            request.ResourcePath = uriResourcePath;
            using (StringWriter stringWriter = new StringWriter(CultureInfo.InvariantCulture))
            {
                JsonWriter writer = new JsonWriter(stringWriter);
                writer.WriteObjectStart();
                var context = new JsonMarshallerContext(request, writer);
                if(publicRequest.IsSetInitiatorName())
                {
                    context.Writer.WritePropertyName("InitiatorName");
                    context.Writer.Write(publicRequest.InitiatorName);
                }

                if(publicRequest.IsSetSecretToAuthenticateInitiator())
                {
                    context.Writer.WritePropertyName("SecretToAuthenticateInitiator");
                    context.Writer.Write(publicRequest.SecretToAuthenticateInitiator);
                }

                if(publicRequest.IsSetSecretToAuthenticateTarget())
                {
                    context.Writer.WritePropertyName("SecretToAuthenticateTarget");
                    context.Writer.Write(publicRequest.SecretToAuthenticateTarget);
                }

                if(publicRequest.IsSetTargetARN())
                {
                    context.Writer.WritePropertyName("TargetARN");
                    context.Writer.Write(publicRequest.TargetARN);
                }

        
                writer.WriteObjectEnd();
                string snippet = stringWriter.ToString();
                request.Content = System.Text.Encoding.UTF8.GetBytes(snippet);
            }


            return request;
        }


    }
}