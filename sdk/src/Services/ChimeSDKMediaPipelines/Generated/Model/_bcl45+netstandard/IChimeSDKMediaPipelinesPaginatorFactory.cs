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
 * Do not modify this file. This file is generated from the chime-sdk-media-pipelines-2021-07-15.normal.json service model.
 */

namespace Amazon.ChimeSDKMediaPipelines.Model
{
    /// <summary>
    /// Paginators for the ChimeSDKMediaPipelines service
    ///</summary>
    public interface IChimeSDKMediaPipelinesPaginatorFactory
    {

        /// <summary>
        /// Paginator for ListMediaCapturePipelines operation
        ///</summary>
        IListMediaCapturePipelinesPaginator ListMediaCapturePipelines(ListMediaCapturePipelinesRequest request);

        /// <summary>
        /// Paginator for ListMediaInsightsPipelineConfigurations operation
        ///</summary>
        IListMediaInsightsPipelineConfigurationsPaginator ListMediaInsightsPipelineConfigurations(ListMediaInsightsPipelineConfigurationsRequest request);

        /// <summary>
        /// Paginator for ListMediaPipelines operation
        ///</summary>
        IListMediaPipelinesPaginator ListMediaPipelines(ListMediaPipelinesRequest request);
    }
}