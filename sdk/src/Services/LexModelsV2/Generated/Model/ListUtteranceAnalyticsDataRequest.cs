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
 * Do not modify this file. This file is generated from the models.lex.v2-2020-08-07.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.LexModelsV2.Model
{
    /// <summary>
    /// Container for the parameters to the ListUtteranceAnalyticsData operation.
    /// Retrieves a list of metadata for individual user utterances to your bot. The <code>startDateTime</code>
    /// and <code>endDateTime</code> fields are required. These fields define a time range
    /// for which you want to retrieve results. Of the optional fields, you can organize the
    /// results in the following ways:
    /// 
    ///  <ul> <li> 
    /// <para>
    /// Use the <code>filters</code> field to filter the results and the <code>sortBy</code>
    /// field to specify the values by which to sort the results.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use the <code>maxResults</code> field to limit the number of results to return in
    /// a single response and the <code>nextToken</code> field to return the next batch of
    /// results if the response does not return the full set of results.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class ListUtteranceAnalyticsDataRequest : AmazonLexModelsV2Request
    {
        private string _botId;
        private DateTime? _endDateTime;
        private List<AnalyticsUtteranceFilter> _filters = new List<AnalyticsUtteranceFilter>();
        private int? _maxResults;
        private string _nextToken;
        private UtteranceDataSortBy _sortBy;
        private DateTime? _startDateTime;

        /// <summary>
        /// Gets and sets the property BotId. 
        /// <para>
        /// The identifier for the bot for which you want to retrieve utterance analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=10, Max=10)]
        public string BotId
        {
            get { return this._botId; }
            set { this._botId = value; }
        }

        // Check to see if BotId property is set
        internal bool IsSetBotId()
        {
            return this._botId != null;
        }

        /// <summary>
        /// Gets and sets the property EndDateTime. 
        /// <para>
        /// The date and time that marks the end of the range of time for which you want to see
        /// utterance analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime EndDateTime
        {
            get { return this._endDateTime.GetValueOrDefault(); }
            set { this._endDateTime = value; }
        }

        // Check to see if EndDateTime property is set
        internal bool IsSetEndDateTime()
        {
            return this._endDateTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// A list of objects, each of which describes a condition by which you want to filter
        /// the results.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=9)]
        public List<AnalyticsUtteranceFilter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property MaxResults. 
        /// <para>
        /// The maximum number of results to return in each page of results. If there are fewer
        /// results than the maximum page size, only the actual number of results are returned.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000)]
        public int MaxResults
        {
            get { return this._maxResults.GetValueOrDefault(); }
            set { this._maxResults = value; }
        }

        // Check to see if MaxResults property is set
        internal bool IsSetMaxResults()
        {
            return this._maxResults.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextToken. 
        /// <para>
        /// If the response from the ListUtteranceAnalyticsData operation contains more results
        /// than specified in the maxResults parameter, a token is returned in the response.
        /// </para>
        ///  
        /// <para>
        /// Use the returned token in the nextToken parameter of a ListUtteranceAnalyticsData
        /// request to return the next page of results. For a complete set of results, call the
        /// ListUtteranceAnalyticsData operation until the nextToken returned in the response
        /// is null.
        /// </para>
        /// </summary>
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

        /// <summary>
        /// Gets and sets the property SortBy. 
        /// <para>
        /// An object specifying the measure and method by which to sort the utterance analytics
        /// data.
        /// </para>
        /// </summary>
        public UtteranceDataSortBy SortBy
        {
            get { return this._sortBy; }
            set { this._sortBy = value; }
        }

        // Check to see if SortBy property is set
        internal bool IsSetSortBy()
        {
            return this._sortBy != null;
        }

        /// <summary>
        /// Gets and sets the property StartDateTime. 
        /// <para>
        /// The date and time that marks the beginning of the range of time for which you want
        /// to see utterance analytics.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime StartDateTime
        {
            get { return this._startDateTime.GetValueOrDefault(); }
            set { this._startDateTime = value; }
        }

        // Check to see if StartDateTime property is set
        internal bool IsSetStartDateTime()
        {
            return this._startDateTime.HasValue; 
        }

    }
}