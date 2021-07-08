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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Container for the parameters to the PutProtocolsList operation.
    /// Creates an Firewall Manager protocols list.
    /// </summary>
    public partial class PutProtocolsListRequest : AmazonFMSRequest
    {
        private ProtocolsListData _protocolsList;
        private List<Tag> _tagList = new List<Tag>();

        /// <summary>
        /// Gets and sets the property ProtocolsList. 
        /// <para>
        /// The details of the Firewall Manager protocols list to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ProtocolsListData ProtocolsList
        {
            get { return this._protocolsList; }
            set { this._protocolsList = value; }
        }

        // Check to see if ProtocolsList property is set
        internal bool IsSetProtocolsList()
        {
            return this._protocolsList != null;
        }

        /// <summary>
        /// Gets and sets the property TagList. 
        /// <para>
        /// The tags associated with the resource.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> TagList
        {
            get { return this._tagList; }
            set { this._tagList = value; }
        }

        // Check to see if TagList property is set
        internal bool IsSetTagList()
        {
            return this._tagList != null && this._tagList.Count > 0; 
        }

    }
}