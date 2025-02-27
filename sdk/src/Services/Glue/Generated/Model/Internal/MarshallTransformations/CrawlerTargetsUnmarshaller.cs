/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the glue-2017-03-31.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Xml.Serialization;

using Amazon.Glue.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Glue.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// Response Unmarshaller for CrawlerTargets Object
    /// </summary>  
    public class CrawlerTargetsUnmarshaller : IUnmarshaller<CrawlerTargets, XmlUnmarshallerContext>, IUnmarshaller<CrawlerTargets, JsonUnmarshallerContext>
    {
        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        CrawlerTargets IUnmarshaller<CrawlerTargets, XmlUnmarshallerContext>.Unmarshall(XmlUnmarshallerContext context)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Unmarshaller the response from the service to the response class.
        /// </summary>  
        /// <param name="context"></param>
        /// <returns></returns>
        public CrawlerTargets Unmarshall(JsonUnmarshallerContext context)
        {
            context.Read();
            if (context.CurrentTokenType == JsonToken.Null) 
                return null;

            CrawlerTargets unmarshalledObject = new CrawlerTargets();
        
            int targetDepth = context.CurrentDepth;
            while (context.ReadAtDepth(targetDepth))
            {
                if (context.TestExpression("CatalogTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<CatalogTarget, CatalogTargetUnmarshaller>(CatalogTargetUnmarshaller.Instance);
                    unmarshalledObject.CatalogTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DeltaTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DeltaTarget, DeltaTargetUnmarshaller>(DeltaTargetUnmarshaller.Instance);
                    unmarshalledObject.DeltaTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("DynamoDBTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<DynamoDBTarget, DynamoDBTargetUnmarshaller>(DynamoDBTargetUnmarshaller.Instance);
                    unmarshalledObject.DynamoDBTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("IcebergTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<IcebergTarget, IcebergTargetUnmarshaller>(IcebergTargetUnmarshaller.Instance);
                    unmarshalledObject.IcebergTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("JdbcTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<JdbcTarget, JdbcTargetUnmarshaller>(JdbcTargetUnmarshaller.Instance);
                    unmarshalledObject.JdbcTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("MongoDBTargets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<MongoDBTarget, MongoDBTargetUnmarshaller>(MongoDBTargetUnmarshaller.Instance);
                    unmarshalledObject.MongoDBTargets = unmarshaller.Unmarshall(context);
                    continue;
                }
                if (context.TestExpression("S3Targets", targetDepth))
                {
                    var unmarshaller = new ListUnmarshaller<S3Target, S3TargetUnmarshaller>(S3TargetUnmarshaller.Instance);
                    unmarshalledObject.S3Targets = unmarshaller.Unmarshall(context);
                    continue;
                }
            }
          
            return unmarshalledObject;
        }


        private static CrawlerTargetsUnmarshaller _instance = new CrawlerTargetsUnmarshaller();        

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static CrawlerTargetsUnmarshaller Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}