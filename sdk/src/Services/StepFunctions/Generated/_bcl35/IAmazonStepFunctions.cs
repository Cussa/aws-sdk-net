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
 * Do not modify this file. This file is generated from the states-2016-11-23.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.StepFunctions.Model;

namespace Amazon.StepFunctions
{
    /// <summary>
    /// Interface for accessing StepFunctions
    ///
    /// Step Functions 
    /// <para>
    /// Step Functions is a service that lets you coordinate the components of distributed
    /// applications and microservices using visual workflows.
    /// </para>
    ///  
    /// <para>
    /// You can use Step Functions to build applications from individual components, each
    /// of which performs a discrete function, or <i>task</i>, allowing you to scale and change
    /// applications quickly. Step Functions provides a console that helps visualize the components
    /// of your application as a series of steps. Step Functions automatically triggers and
    /// tracks each step, and retries steps when there are errors, so your application executes
    /// predictably and in the right order every time. Step Functions logs the state of each
    /// step, so you can quickly diagnose and debug any issues.
    /// </para>
    ///  
    /// <para>
    /// Step Functions manages operations and underlying infrastructure to ensure your application
    /// is available at any scale. You can run tasks on Amazon Web Services, your own servers,
    /// or any system that has access to Amazon Web Services. You can access and use Step
    /// Functions using the console, the Amazon Web Services SDKs, or an HTTP API. For more
    /// information about Step Functions, see the <i> <a href="https://docs.aws.amazon.com/step-functions/latest/dg/welcome.html">Step
    /// Functions Developer Guide</a> </i>.
    /// </para>
    /// </summary>
    public partial interface IAmazonStepFunctions : IAmazonService, IDisposable
    {


#if BCL45 || AWS_ASYNC_ENUMERABLES_API
        /// <summary>
        /// Paginators for the service
        /// </summary>
        IStepFunctionsPaginatorFactory Paginators { get; }
#endif


        
        #region  CreateActivity


        /// <summary>
        /// Creates an activity. An activity is a task that you write in any programming language
        /// and host on any machine that has access to Step Functions. Activities must poll Step
        /// Functions using the <code>GetActivityTask</code> API action and respond using <code>SendTask*</code>
        /// API actions. This function lets Step Functions know the existence of your activity
        /// and returns an identifier for use in a state machine and when polling from the activity.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <code>CreateActivity</code> is an idempotent API. Subsequent requests won’t create
        /// a duplicate resource if it was already created. <code>CreateActivity</code>'s idempotency
        /// check is based on the activity <code>name</code>. If a following request has different
        /// <code>tags</code> values, Step Functions will ignore these differences and treat it
        /// as an idempotent request of the previous. In this case, <code>tags</code> will not
        /// be updated, even if they are different.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateActivity service method.</param>
        /// 
        /// <returns>The response from the CreateActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityLimitExceededException">
        /// The maximum number of activities has been reached. Existing activities must be deleted
        /// before a new activity can be created.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        CreateActivityResponse CreateActivity(CreateActivityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateActivity operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        IAsyncResult BeginCreateActivity(CreateActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateActivity.</param>
        /// 
        /// <returns>Returns a  CreateActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateActivity">REST API Reference for CreateActivity Operation</seealso>
        CreateActivityResponse EndCreateActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStateMachine


        /// <summary>
        /// Creates a state machine. A state machine consists of a collection of states that can
        /// do work (<code>Task</code> states), determine to which states to transition next (<code>Choice</code>
        /// states), stop an execution with an error (<code>Fail</code> states), and so on. State
        /// machines are specified using a JSON-based, structured language. For more information,
        /// see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-amazon-states-language.html">Amazon
        /// States Language</a> in the Step Functions User Guide.
        /// 
        ///  
        /// <para>
        /// If you set the <code>publish</code> parameter of this API action to <code>true</code>,
        /// it publishes version <code>1</code> as the first revision of the state machine.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> <note> 
        /// <para>
        ///  <code>CreateStateMachine</code> is an idempotent API. Subsequent requests won’t create
        /// a duplicate resource if it was already created. <code>CreateStateMachine</code>'s
        /// idempotency check is based on the state machine <code>name</code>, <code>definition</code>,
        /// <code>type</code>, <code>LoggingConfiguration</code>, and <code>TracingConfiguration</code>.
        /// The check is also based on the <code>publish</code> and <code>versionDescription</code>
        /// parameters. If a following request has a different <code>roleArn</code> or <code>tags</code>,
        /// Step Functions will ignore these differences and treat it as an idempotent request
        /// of the previous. In this case, <code>roleArn</code> and <code>tags</code> will not
        /// be updated, even if they are different.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachine service method.</param>
        /// 
        /// <returns>The response from the CreateStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTracingConfigurationException">
        /// Your <code>tracingConfiguration</code> key does not match, or <code>enabled</code>
        /// has not been set to <code>true</code> or <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineAlreadyExistsException">
        /// A state machine with the same name but a different definition or role ARN already
        /// exists.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineLimitExceededException">
        /// The maximum number of state machines has been reached. Existing state machines must
        /// be deleted before a new state machine can be created.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        CreateStateMachineResponse CreateStateMachine(CreateStateMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        IAsyncResult BeginCreateStateMachine(CreateStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStateMachine.</param>
        /// 
        /// <returns>Returns a  CreateStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachine">REST API Reference for CreateStateMachine Operation</seealso>
        CreateStateMachineResponse EndCreateStateMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateStateMachineAlias


        /// <summary>
        /// Creates an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// for a state machine that points to one or two <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
        /// of the same state machine. You can set your application to call <a>StartExecution</a>
        /// with an alias and update the version the alias uses without changing the client's
        /// code.
        /// 
        ///  
        /// <para>
        /// You can also map an alias to split <a>StartExecution</a> requests between two versions
        /// of a state machine. To do this, add a second <code>RoutingConfig</code> object in
        /// the <code>routingConfiguration</code> parameter. You must also specify the percentage
        /// of execution run requests each version should receive in both <code>RoutingConfig</code>
        /// objects. Step Functions randomly chooses which version runs a given execution based
        /// on the percentage you specify.
        /// </para>
        ///  
        /// <para>
        /// To create an alias that points to a single version, specify a single <code>RoutingConfig</code>
        /// object with a <code>weight</code> set to 100.
        /// </para>
        ///  
        /// <para>
        /// You can create up to 100 aliases for each state machine. You must delete unused aliases
        /// using the <a>DeleteStateMachineAlias</a> API action.
        /// </para>
        ///  
        /// <para>
        ///  <code>CreateStateMachineAlias</code> is an idempotent API. Step Functions bases the
        /// idempotency check on the <code>stateMachineArn</code>, <code>description</code>, <code>name</code>,
        /// and <code>routingConfiguration</code> parameters. Requests that contain the same values
        /// for these parameters return a successful idempotent response without creating a duplicate
        /// resource.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachineAlias service method.</param>
        /// 
        /// <returns>The response from the CreateStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachineAlias">REST API Reference for CreateStateMachineAlias Operation</seealso>
        CreateStateMachineAliasResponse CreateStateMachineAlias(CreateStateMachineAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateStateMachineAlias operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateStateMachineAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachineAlias">REST API Reference for CreateStateMachineAlias Operation</seealso>
        IAsyncResult BeginCreateStateMachineAlias(CreateStateMachineAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateStateMachineAlias.</param>
        /// 
        /// <returns>Returns a  CreateStateMachineAliasResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/CreateStateMachineAlias">REST API Reference for CreateStateMachineAlias Operation</seealso>
        CreateStateMachineAliasResponse EndCreateStateMachineAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteActivity


        /// <summary>
        /// Deletes an activity.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity service method.</param>
        /// 
        /// <returns>The response from the DeleteActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        DeleteActivityResponse DeleteActivity(DeleteActivityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteActivity operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        IAsyncResult BeginDeleteActivity(DeleteActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteActivity.</param>
        /// 
        /// <returns>Returns a  DeleteActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteActivity">REST API Reference for DeleteActivity Operation</seealso>
        DeleteActivityResponse EndDeleteActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStateMachine


        /// <summary>
        /// Deletes a state machine. This is an asynchronous operation: It sets the state machine's
        /// status to <code>DELETING</code> and begins the deletion process. 
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <code>mapStateLabel</code> in a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <code>ValidationException</code>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine</code> 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This API action also deletes all <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
        /// and <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">aliases</a>
        /// associated with a state machine.
        /// </para>
        ///  <note> 
        /// <para>
        /// For <code>EXPRESS</code> state machines, the deletion happens eventually (usually
        /// in less than a minute). Running executions may emit logs after <code>DeleteStateMachine</code>
        /// API is called.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine service method.</param>
        /// 
        /// <returns>The response from the DeleteStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        DeleteStateMachineResponse DeleteStateMachine(DeleteStateMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        IAsyncResult BeginDeleteStateMachine(DeleteStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStateMachine.</param>
        /// 
        /// <returns>Returns a  DeleteStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachine">REST API Reference for DeleteStateMachine Operation</seealso>
        DeleteStateMachineResponse EndDeleteStateMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStateMachineAlias


        /// <summary>
        /// Deletes a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
        /// 
        ///  
        /// <para>
        /// After you delete a state machine alias, you can't use it to start executions. When
        /// you delete a state machine alias, Step Functions doesn't delete the state machine
        /// versions that alias references.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachineAlias service method.</param>
        /// 
        /// <returns>The response from the DeleteStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineAlias">REST API Reference for DeleteStateMachineAlias Operation</seealso>
        DeleteStateMachineAliasResponse DeleteStateMachineAlias(DeleteStateMachineAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachineAlias operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStateMachineAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineAlias">REST API Reference for DeleteStateMachineAlias Operation</seealso>
        IAsyncResult BeginDeleteStateMachineAlias(DeleteStateMachineAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStateMachineAlias.</param>
        /// 
        /// <returns>Returns a  DeleteStateMachineAliasResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineAlias">REST API Reference for DeleteStateMachineAlias Operation</seealso>
        DeleteStateMachineAliasResponse EndDeleteStateMachineAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteStateMachineVersion


        /// <summary>
        /// Deletes a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>.
        /// After you delete a version, you can't call <a>StartExecution</a> using that version's
        /// ARN or use the version with a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
        /// 
        ///  <note> 
        /// <para>
        /// Deleting a state machine version won't terminate its in-progress executions.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// You can't delete a state machine version currently referenced by one or more aliases.
        /// Before you delete a version, you must either delete the aliases or update them to
        /// point to another state machine version.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PublishStateMachineVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineVersions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachineVersion service method.</param>
        /// 
        /// <returns>The response from the DeleteStateMachineVersion service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineVersion">REST API Reference for DeleteStateMachineVersion Operation</seealso>
        DeleteStateMachineVersionResponse DeleteStateMachineVersion(DeleteStateMachineVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteStateMachineVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteStateMachineVersion operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteStateMachineVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineVersion">REST API Reference for DeleteStateMachineVersion Operation</seealso>
        IAsyncResult BeginDeleteStateMachineVersion(DeleteStateMachineVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteStateMachineVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteStateMachineVersion.</param>
        /// 
        /// <returns>Returns a  DeleteStateMachineVersionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DeleteStateMachineVersion">REST API Reference for DeleteStateMachineVersion Operation</seealso>
        DeleteStateMachineVersionResponse EndDeleteStateMachineVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeActivity


        /// <summary>
        /// Describes an activity.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivity service method.</param>
        /// 
        /// <returns>The response from the DescribeActivity service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityDoesNotExistException">
        /// The specified activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        DescribeActivityResponse DescribeActivity(DescribeActivityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeActivity operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeActivity operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeActivity
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        IAsyncResult BeginDescribeActivity(DescribeActivityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeActivity operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeActivity.</param>
        /// 
        /// <returns>Returns a  DescribeActivityResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeActivity">REST API Reference for DescribeActivity Operation</seealso>
        DescribeActivityResponse EndDescribeActivity(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExecution


        /// <summary>
        /// Provides information about a state machine execution, such as the state machine associated
        /// with the execution, the execution input and output, and relevant execution metadata.
        /// Use this API action to return the Map Run Amazon Resource Name (ARN) if the execution
        /// was dispatched by a Map Run.
        /// 
        ///  
        /// <para>
        /// If you specify a version or alias ARN when you call the <a>StartExecution</a> API
        /// action, <code>DescribeExecution</code> returns that ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// Executions of an <code>EXPRESS</code> state machinearen't supported by <code>DescribeExecution</code>
        /// unless a Map Run dispatched them.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        DescribeExecutionResponse DescribeExecution(DescribeExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        IAsyncResult BeginDescribeExecution(DescribeExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExecution.</param>
        /// 
        /// <returns>Returns a  DescribeExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeExecution">REST API Reference for DescribeExecution Operation</seealso>
        DescribeExecutionResponse EndDescribeExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMapRun


        /// <summary>
        /// Provides information about a Map Run's configuration, progress, and results. For more
        /// information, see <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-examine-map-run.html">Examining
        /// Map Run</a> in the <i>Step Functions Developer Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMapRun service method.</param>
        /// 
        /// <returns>The response from the DescribeMapRun service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        DescribeMapRunResponse DescribeMapRun(DescribeMapRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMapRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMapRun operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMapRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        IAsyncResult BeginDescribeMapRun(DescribeMapRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMapRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMapRun.</param>
        /// 
        /// <returns>Returns a  DescribeMapRunResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeMapRun">REST API Reference for DescribeMapRun Operation</seealso>
        DescribeMapRunResponse EndDescribeMapRun(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStateMachine


        /// <summary>
        /// Provides information about a state machine's definition, its IAM role Amazon Resource
        /// Name (ARN), and configuration.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <code>mapStateLabel</code> in a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <code>ValidationException</code>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to an alias named <code>PROD</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
        /// ARN, the request starts execution for that version or alias.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// This API action returns the details for a state machine version if the <code>stateMachineArn</code>
        /// you specify is a state machine version ARN.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachine service method.</param>
        /// 
        /// <returns>The response from the DescribeStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        DescribeStateMachineResponse DescribeStateMachine(DescribeStateMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        IAsyncResult BeginDescribeStateMachine(DescribeStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachine.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachine">REST API Reference for DescribeStateMachine Operation</seealso>
        DescribeStateMachineResponse EndDescribeStateMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStateMachineAlias


        /// <summary>
        /// Returns details about a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>.
        /// 
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineAlias service method.</param>
        /// 
        /// <returns>The response from the DescribeStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineAlias">REST API Reference for DescribeStateMachineAlias Operation</seealso>
        DescribeStateMachineAliasResponse DescribeStateMachineAlias(DescribeStateMachineAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineAlias operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStateMachineAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineAlias">REST API Reference for DescribeStateMachineAlias Operation</seealso>
        IAsyncResult BeginDescribeStateMachineAlias(DescribeStateMachineAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachineAlias.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineAliasResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineAlias">REST API Reference for DescribeStateMachineAlias Operation</seealso>
        DescribeStateMachineAliasResponse EndDescribeStateMachineAlias(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStateMachineForExecution


        /// <summary>
        /// Provides information about a state machine's definition, its execution role ARN, and
        /// configuration. If a Map Run dispatched the execution, this action returns the Map
        /// Run Amazon Resource Name (ARN) in the response. The state machine returned is the
        /// state machine associated with the Map Run.
        /// 
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineForExecution service method.</param>
        /// 
        /// <returns>The response from the DescribeStateMachineForExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        DescribeStateMachineForExecutionResponse DescribeStateMachineForExecution(DescribeStateMachineForExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStateMachineForExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStateMachineForExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStateMachineForExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        IAsyncResult BeginDescribeStateMachineForExecution(DescribeStateMachineForExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStateMachineForExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStateMachineForExecution.</param>
        /// 
        /// <returns>Returns a  DescribeStateMachineForExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/DescribeStateMachineForExecution">REST API Reference for DescribeStateMachineForExecution Operation</seealso>
        DescribeStateMachineForExecutionResponse EndDescribeStateMachineForExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  GetActivityTask


        /// <summary>
        /// Used by workers to retrieve a task (with the specified activity ARN) which has been
        /// scheduled for execution by a running state machine. This initiates a long poll, where
        /// the service holds the HTTP connection open and responds as soon as a task becomes
        /// available (i.e. an execution of a task of this type is needed.) The maximum time the
        /// service holds on to the request before responding is 60 seconds. If no task is available
        /// within 60 seconds, the poll returns a <code>taskToken</code> with a null string.
        /// 
        ///  <note> 
        /// <para>
        /// This API action isn't logged in CloudTrail.
        /// </para>
        ///  </note> <important> 
        /// <para>
        /// Workers should set their client side socket timeout to at least 65 seconds (5 seconds
        /// higher than the maximum time the service may hold the poll request).
        /// </para>
        ///  
        /// <para>
        /// Polling with <code>GetActivityTask</code> can cause latency in some implementations.
        /// See <a href="https://docs.aws.amazon.com/step-functions/latest/dg/bp-activity-pollers.html">Avoid
        /// Latency When Polling for Activity Tasks</a> in the Step Functions Developer Guide.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetActivityTask service method.</param>
        /// 
        /// <returns>The response from the GetActivityTask service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityDoesNotExistException">
        /// The specified activity does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ActivityWorkerLimitExceededException">
        /// The maximum number of workers concurrently polling for activity tasks has been reached.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        GetActivityTaskResponse GetActivityTask(GetActivityTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetActivityTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetActivityTask operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetActivityTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        IAsyncResult BeginGetActivityTask(GetActivityTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetActivityTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetActivityTask.</param>
        /// 
        /// <returns>Returns a  GetActivityTaskResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetActivityTask">REST API Reference for GetActivityTask Operation</seealso>
        GetActivityTaskResponse EndGetActivityTask(IAsyncResult asyncResult);

        #endregion
        
        #region  GetExecutionHistory


        /// <summary>
        /// Returns the history of the specified execution as a list of events. By default, the
        /// results are returned in ascending order of the <code>timeStamp</code> of the events.
        /// Use the <code>reverseOrder</code> parameter to get the latest events first.
        /// 
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetExecutionHistory service method.</param>
        /// 
        /// <returns>The response from the GetExecutionHistory service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        GetExecutionHistoryResponse GetExecutionHistory(GetExecutionHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetExecutionHistory operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetExecutionHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        IAsyncResult BeginGetExecutionHistory(GetExecutionHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetExecutionHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetExecutionHistory.</param>
        /// 
        /// <returns>Returns a  GetExecutionHistoryResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/GetExecutionHistory">REST API Reference for GetExecutionHistory Operation</seealso>
        GetExecutionHistoryResponse EndGetExecutionHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  ListActivities


        /// <summary>
        /// Lists the existing activities.
        /// 
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListActivities service method.</param>
        /// 
        /// <returns>The response from the ListActivities service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        ListActivitiesResponse ListActivities(ListActivitiesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListActivities operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListActivities operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListActivities
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        IAsyncResult BeginListActivities(ListActivitiesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListActivities operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListActivities.</param>
        /// 
        /// <returns>Returns a  ListActivitiesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListActivities">REST API Reference for ListActivities Operation</seealso>
        ListActivitiesResponse EndListActivities(IAsyncResult asyncResult);

        #endregion
        
        #region  ListExecutions


        /// <summary>
        /// Lists all executions of a state machine or a Map Run. You can list all executions
        /// related to a state machine by specifying a state machine Amazon Resource Name (ARN),
        /// or those related to a Map Run by specifying a Map Run ARN.
        /// 
        ///  
        /// <para>
        /// You can also provide a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// ARN or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>
        /// ARN to list the executions associated with a specific alias or version.
        /// </para>
        ///  
        /// <para>
        /// Results are sorted by time, with the most recent execution first.
        /// </para>
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note> 
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions service method.</param>
        /// 
        /// <returns>The response from the ListExecutions service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse ListExecutions(ListExecutionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListExecutions operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListExecutions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        IAsyncResult BeginListExecutions(ListExecutionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListExecutions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListExecutions.</param>
        /// 
        /// <returns>Returns a  ListExecutionsResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListExecutions">REST API Reference for ListExecutions Operation</seealso>
        ListExecutionsResponse EndListExecutions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListMapRuns


        /// <summary>
        /// Lists all Map Runs that were started by a given state machine execution. Use this
        /// API action to obtain Map Run ARNs, and then call <code>DescribeMapRun</code> to obtain
        /// more information, if needed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMapRuns service method.</param>
        /// 
        /// <returns>The response from the ListMapRuns service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListMapRuns">REST API Reference for ListMapRuns Operation</seealso>
        ListMapRunsResponse ListMapRuns(ListMapRunsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListMapRuns operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMapRuns operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListMapRuns
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListMapRuns">REST API Reference for ListMapRuns Operation</seealso>
        IAsyncResult BeginListMapRuns(ListMapRunsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListMapRuns operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListMapRuns.</param>
        /// 
        /// <returns>Returns a  ListMapRunsResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListMapRuns">REST API Reference for ListMapRuns Operation</seealso>
        ListMapRunsResponse EndListMapRuns(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStateMachineAliases


        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">aliases</a>
        /// for a specified state machine ARN. Results are sorted by time, with the most recently
        /// created aliases listed first. 
        /// 
        ///  
        /// <para>
        /// To list aliases that reference a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>,
        /// you can specify the version ARN in the <code>stateMachineArn</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>UpdateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachineAliases service method.</param>
        /// 
        /// <returns>The response from the ListStateMachineAliases service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineAliases">REST API Reference for ListStateMachineAliases Operation</seealso>
        ListStateMachineAliasesResponse ListStateMachineAliases(ListStateMachineAliasesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStateMachineAliases operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachineAliases operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStateMachineAliases
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineAliases">REST API Reference for ListStateMachineAliases Operation</seealso>
        IAsyncResult BeginListStateMachineAliases(ListStateMachineAliasesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStateMachineAliases operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStateMachineAliases.</param>
        /// 
        /// <returns>Returns a  ListStateMachineAliasesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineAliases">REST API Reference for ListStateMachineAliases Operation</seealso>
        ListStateMachineAliasesResponse EndListStateMachineAliases(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStateMachines


        /// <summary>
        /// Lists the existing state machines.
        /// 
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This operation is eventually consistent. The results are best effort and may not reflect
        /// very recent updates and changes.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachines service method.</param>
        /// 
        /// <returns>The response from the ListStateMachines service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        ListStateMachinesResponse ListStateMachines(ListStateMachinesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStateMachines operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachines operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStateMachines
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        IAsyncResult BeginListStateMachines(ListStateMachinesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStateMachines operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStateMachines.</param>
        /// 
        /// <returns>Returns a  ListStateMachinesResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachines">REST API Reference for ListStateMachines Operation</seealso>
        ListStateMachinesResponse EndListStateMachines(IAsyncResult asyncResult);

        #endregion
        
        #region  ListStateMachineVersions


        /// <summary>
        /// Lists <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">versions</a>
        /// for the specified state machine Amazon Resource Name (ARN).
        /// 
        ///  
        /// <para>
        /// The results are sorted in descending order of the version creation time.
        /// </para>
        ///  
        /// <para>
        /// If <code>nextToken</code> is returned, there are more results available. The value
        /// of <code>nextToken</code> is a unique pagination token for each page. Make the call
        /// again using the returned token to retrieve the next page. Keep all other arguments
        /// unchanged. Each pagination token expires after 24 hours. Using an expired pagination
        /// token will return an <i>HTTP 400 InvalidToken</i> error.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>PublishStateMachineVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineVersion</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachineVersions service method.</param>
        /// 
        /// <returns>The response from the ListStateMachineVersions service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineVersions">REST API Reference for ListStateMachineVersions Operation</seealso>
        ListStateMachineVersionsResponse ListStateMachineVersions(ListStateMachineVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListStateMachineVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListStateMachineVersions operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListStateMachineVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineVersions">REST API Reference for ListStateMachineVersions Operation</seealso>
        IAsyncResult BeginListStateMachineVersions(ListStateMachineVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListStateMachineVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListStateMachineVersions.</param>
        /// 
        /// <returns>Returns a  ListStateMachineVersionsResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListStateMachineVersions">REST API Reference for ListStateMachineVersions Operation</seealso>
        ListStateMachineVersionsResponse EndListStateMachineVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  ListTagsForResource


        /// <summary>
        /// List tags for a given resource.
        /// 
        ///  
        /// <para>
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <code>_
        /// . : / = + - @</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult);

        #endregion
        
        #region  PublishStateMachineVersion


        /// <summary>
        /// Creates a <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>
        /// from the current revision of a state machine. Use versions to create immutable snapshots
        /// of your state machine. You can start executions from versions either directly or with
        /// an alias. To create an alias, use <a>CreateStateMachineAlias</a>.
        /// 
        ///  
        /// <para>
        /// You can publish up to 1000 versions for each state machine. You must manually delete
        /// unused versions using the <a>DeleteStateMachineVersion</a> API action.
        /// </para>
        ///  
        /// <para>
        ///  <code>PublishStateMachineVersion</code> is an idempotent API. It doesn't create a
        /// duplicate state machine version if it already exists for the current revision. Step
        /// Functions bases <code>PublishStateMachineVersion</code>'s idempotency check on the
        /// <code>stateMachineArn</code>, <code>name</code>, and <code>revisionId</code> parameters.
        /// Requests with the same parameters return a successful idempotent response. If you
        /// don't specify a <code>revisionId</code>, Step Functions checks for a previously published
        /// version of the state machine's current revision.
        /// </para>
        ///  
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>DeleteStateMachineVersion</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineVersions</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PublishStateMachineVersion service method.</param>
        /// 
        /// <returns>The response from the PublishStateMachineVersion service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/PublishStateMachineVersion">REST API Reference for PublishStateMachineVersion Operation</seealso>
        PublishStateMachineVersionResponse PublishStateMachineVersion(PublishStateMachineVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PublishStateMachineVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PublishStateMachineVersion operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPublishStateMachineVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/PublishStateMachineVersion">REST API Reference for PublishStateMachineVersion Operation</seealso>
        IAsyncResult BeginPublishStateMachineVersion(PublishStateMachineVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PublishStateMachineVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPublishStateMachineVersion.</param>
        /// 
        /// <returns>Returns a  PublishStateMachineVersionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/PublishStateMachineVersion">REST API Reference for PublishStateMachineVersion Operation</seealso>
        PublishStateMachineVersionResponse EndPublishStateMachineVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  SendTaskFailure


        /// <summary>
        /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern to report that the task identified by the <code>taskToken</code> failed.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskFailure service method.</param>
        /// 
        /// <returns>The response from the SendTaskFailure service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        SendTaskFailureResponse SendTaskFailure(SendTaskFailureRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskFailure operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskFailure operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTaskFailure
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        IAsyncResult BeginSendTaskFailure(SendTaskFailureRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskFailure operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskFailure.</param>
        /// 
        /// <returns>Returns a  SendTaskFailureResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskFailure">REST API Reference for SendTaskFailure Operation</seealso>
        SendTaskFailureResponse EndSendTaskFailure(IAsyncResult asyncResult);

        #endregion
        
        #region  SendTaskHeartbeat


        /// <summary>
        /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern to report to Step Functions that the task represented by the specified <code>taskToken</code>
        /// is still making progress. This action resets the <code>Heartbeat</code> clock. The
        /// <code>Heartbeat</code> threshold is specified in the state machine's Amazon States
        /// Language definition (<code>HeartbeatSeconds</code>). This action does not in itself
        /// create an event in the execution history. However, if the task times out, the execution
        /// history contains an <code>ActivityTimedOut</code> entry for activities, or a <code>TaskTimedOut</code>
        /// entry for for tasks using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-sync">job
        /// run</a> or <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern.
        /// 
        ///  <note> 
        /// <para>
        /// The <code>Timeout</code> of a task, defined in the state machine's Amazon States Language
        /// definition, is its maximum allowed duration, regardless of the number of <a>SendTaskHeartbeat</a>
        /// requests received. Use <code>HeartbeatSeconds</code> to configure the timeout interval
        /// for heartbeats.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskHeartbeat service method.</param>
        /// 
        /// <returns>The response from the SendTaskHeartbeat service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        SendTaskHeartbeatResponse SendTaskHeartbeat(SendTaskHeartbeatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskHeartbeat operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTaskHeartbeat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        IAsyncResult BeginSendTaskHeartbeat(SendTaskHeartbeatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskHeartbeat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskHeartbeat.</param>
        /// 
        /// <returns>Returns a  SendTaskHeartbeatResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskHeartbeat">REST API Reference for SendTaskHeartbeat Operation</seealso>
        SendTaskHeartbeatResponse EndSendTaskHeartbeat(IAsyncResult asyncResult);

        #endregion
        
        #region  SendTaskSuccess


        /// <summary>
        /// Used by activity workers and task states using the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/connect-to-resource.html#connect-wait-token">callback</a>
        /// pattern to report that the task identified by the <code>taskToken</code> completed
        /// successfully.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the SendTaskSuccess service method.</param>
        /// 
        /// <returns>The response from the SendTaskSuccess service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidOutputException">
        /// The provided JSON output data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTokenException">
        /// The provided token is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskDoesNotExistException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TaskTimedOutException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        SendTaskSuccessResponse SendTaskSuccess(SendTaskSuccessRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the SendTaskSuccess operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SendTaskSuccess operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndSendTaskSuccess
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        IAsyncResult BeginSendTaskSuccess(SendTaskSuccessRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  SendTaskSuccess operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginSendTaskSuccess.</param>
        /// 
        /// <returns>Returns a  SendTaskSuccessResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/SendTaskSuccess">REST API Reference for SendTaskSuccess Operation</seealso>
        SendTaskSuccessResponse EndSendTaskSuccess(IAsyncResult asyncResult);

        #endregion
        
        #region  StartExecution


        /// <summary>
        /// Starts a state machine execution.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <code>mapStateLabel</code> in a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <code>ValidationException</code>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to an alias named <code>PROD</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
        /// ARN, the request starts execution for that version or alias.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If you start an execution with an unqualified state machine ARN, Step Functions uses
        /// the latest revision of the state machine for the execution.
        /// </para>
        ///  
        /// <para>
        /// To start executions of a state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>,
        /// call <code>StartExecution</code> and provide the version ARN or the ARN of an <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// that points to the version.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>StartExecution</code> is idempotent for <code>STANDARD</code> workflows. For
        /// a <code>STANDARD</code> workflow, if you call <code>StartExecution</code> with the
        /// same name and input as a running execution, the call succeeds and return the same
        /// response as the original request. If the execution is closed or if the input is different,
        /// it returns a <code>400 ExecutionAlreadyExists</code> error. You can reuse names after
        /// 90 days. 
        /// </para>
        ///  
        /// <para>
        ///  <code>StartExecution</code> isn't idempotent for <code>EXPRESS</code> workflows.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartExecution service method.</param>
        /// 
        /// <returns>The response from the StartExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionAlreadyExistsException">
        /// The execution has the same <code>name</code> as another execution (but a different
        /// <code>input</code>).
        /// 
        ///  <note> 
        /// <para>
        /// Executions with the same <code>name</code> and <code>input</code> are considered idempotent.
        /// </para>
        ///  </note>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionLimitExceededException">
        /// The maximum number of running executions has been reached. Running executions must
        /// end or be stopped before a new execution can be started.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        StartExecutionResponse StartExecution(StartExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        IAsyncResult BeginStartExecution(StartExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartExecution.</param>
        /// 
        /// <returns>Returns a  StartExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartExecution">REST API Reference for StartExecution Operation</seealso>
        StartExecutionResponse EndStartExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  StartSyncExecution


        /// <summary>
        /// Starts a Synchronous Express state machine execution. <code>StartSyncExecution</code>
        /// is not available for <code>STANDARD</code> workflows.
        /// 
        ///  <note> 
        /// <para>
        ///  <code>StartSyncExecution</code> will return a <code>200 OK</code> response, even
        /// if your execution fails, because the status code in the API response doesn't reflect
        /// function errors. Error codes are reserved for errors that prevent your execution from
        /// running, such as permissions errors, limit errors, or issues with your state machine
        /// code and configuration. 
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This API action isn't logged in CloudTrail.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartSyncExecution service method.</param>
        /// 
        /// <returns>The response from the StartSyncExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidExecutionInputException">
        /// The provided JSON input data is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidNameException">
        /// The provided name is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineTypeNotSupportedException">
        /// 
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        StartSyncExecutionResponse StartSyncExecution(StartSyncExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartSyncExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartSyncExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartSyncExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        IAsyncResult BeginStartSyncExecution(StartSyncExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartSyncExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartSyncExecution.</param>
        /// 
        /// <returns>Returns a  StartSyncExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StartSyncExecution">REST API Reference for StartSyncExecution Operation</seealso>
        StartSyncExecutionResponse EndStartSyncExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  StopExecution


        /// <summary>
        /// Stops an execution.
        /// 
        ///  
        /// <para>
        /// This API action is not supported by <code>EXPRESS</code> state machines.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopExecution service method.</param>
        /// 
        /// <returns>The response from the StopExecution service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ExecutionDoesNotExistException">
        /// The specified execution does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        StopExecutionResponse StopExecution(StopExecutionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopExecution operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopExecution operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopExecution
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        IAsyncResult BeginStopExecution(StopExecutionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopExecution operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopExecution.</param>
        /// 
        /// <returns>Returns a  StopExecutionResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/StopExecution">REST API Reference for StopExecution Operation</seealso>
        StopExecutionResponse EndStopExecution(IAsyncResult asyncResult);

        #endregion
        
        #region  TagResource


        /// <summary>
        /// Add a tag to a Step Functions resource.
        /// 
        ///  
        /// <para>
        /// An array of key-value pairs. For more information, see <a href="https://docs.aws.amazon.com/awsaccountbilling/latest/aboutv2/cost-alloc-tags.html">Using
        /// Cost Allocation Tags</a> in the <i>Amazon Web Services Billing and Cost Management
        /// User Guide</i>, and <a href="https://docs.aws.amazon.com/IAM/latest/UserGuide/access_iam-tags.html">Controlling
        /// Access Using IAM Tags</a>.
        /// </para>
        ///  
        /// <para>
        /// Tags may only contain Unicode letters, digits, white space, or these symbols: <code>_
        /// . : / = + - @</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.TooManyTagsException">
        /// You've exceeded the number of tags allowed for a resource. See the <a href="https://docs.aws.amazon.com/step-functions/latest/dg/limits.html">
        /// Limits Topic</a> in the Step Functions Developer Guide.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse TagResource(TagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/TagResource">REST API Reference for TagResource Operation</seealso>
        TagResourceResponse EndTagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UntagResource


        /// <summary>
        /// Remove a tag from a Step Functions resource
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse UntagResource(UntagResourceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UntagResource">REST API Reference for UntagResource Operation</seealso>
        UntagResourceResponse EndUntagResource(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateMapRun


        /// <summary>
        /// Updates an in-progress Map Run's configuration to include changes to the settings
        /// that control maximum concurrency and Map Run failure.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateMapRun service method.</param>
        /// 
        /// <returns>The response from the UpdateMapRun service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        UpdateMapRunResponse UpdateMapRun(UpdateMapRunRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateMapRun operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateMapRun operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateMapRun
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        IAsyncResult BeginUpdateMapRun(UpdateMapRunRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateMapRun operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateMapRun.</param>
        /// 
        /// <returns>Returns a  UpdateMapRunResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateMapRun">REST API Reference for UpdateMapRun Operation</seealso>
        UpdateMapRunResponse EndUpdateMapRun(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStateMachine


        /// <summary>
        /// Updates an existing state machine by modifying its <code>definition</code>, <code>roleArn</code>,
        /// or <code>loggingConfiguration</code>. Running executions will continue to use the
        /// previous <code>definition</code> and <code>roleArn</code>. You must include at least
        /// one of <code>definition</code> or <code>roleArn</code> or you will receive a <code>MissingRequiredParameter</code>
        /// error.
        /// 
        ///  
        /// <para>
        /// A qualified state machine ARN refers to a <i>Distributed Map state</i> defined within
        /// a state machine. For example, the qualified state machine ARN <code>arn:partition:states:region:account-id:stateMachine:stateMachineName/mapStateLabel</code>
        /// refers to a <i>Distributed Map state</i> with a label <code>mapStateLabel</code> in
        /// the state machine named <code>stateMachineName</code>.
        /// </para>
        ///  
        /// <para>
        /// A qualified state machine ARN can either refer to a <i>Distributed Map state</i> defined
        /// within a state machine, a version ARN, or an alias ARN.
        /// </para>
        ///  
        /// <para>
        /// The following are some examples of qualified and unqualified state machine ARNs:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to a <i>Distributed Map state</i>
        /// with a label <code>mapStateLabel</code> in a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:partition:states:region:account-id:stateMachine:myStateMachine/mapStateLabel</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a <i>Distributed Map state</i>,
        /// the request fails with <code>ValidationException</code>.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following qualified state machine ARN refers to an alias named <code>PROD</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine:PROD&gt;</code>
        /// 
        /// </para>
        ///  <note> 
        /// <para>
        /// If you provide a qualified state machine ARN that refers to a version ARN or an alias
        /// ARN, the request starts execution for that version or alias.
        /// </para>
        ///  </note> </li> <li> 
        /// <para>
        /// The following unqualified state machine ARN refers to a state machine named <code>myStateMachine</code>.
        /// </para>
        ///  
        /// <para>
        ///  <code>arn:&lt;partition&gt;:states:&lt;region&gt;:&lt;account-id&gt;:stateMachine:&lt;myStateMachine&gt;</code>
        /// 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// After you update your state machine, you can set the <code>publish</code> parameter
        /// to <code>true</code> in the same action to publish a new <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-version.html">version</a>.
        /// This way, you can opt-in to strict versioning of your state machine.
        /// </para>
        ///  <note> 
        /// <para>
        /// Step Functions assigns monotonically increasing integers for state machine versions,
        /// starting at version number 1.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// All <code>StartExecution</code> calls within a few seconds use the updated <code>definition</code>
        /// and <code>roleArn</code>. Executions started immediately after you call <code>UpdateStateMachine</code>
        /// may use the previous state machine <code>definition</code> and <code>roleArn</code>.
        /// 
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachine service method.</param>
        /// 
        /// <returns>The response from the UpdateStateMachine service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidDefinitionException">
        /// The provided Amazon States Language definition is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidLoggingConfigurationException">
        /// 
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidTracingConfigurationException">
        /// Your <code>tracingConfiguration</code> key does not match, or <code>enabled</code>
        /// has not been set to <code>true</code> or <code>false</code>.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.MissingRequiredParameterException">
        /// Request is missing a required parameter. This error occurs if both <code>definition</code>
        /// and <code>roleArn</code> are not specified.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ServiceQuotaExceededException">
        /// The request would cause a service quota to be exceeded.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 402
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDeletingException">
        /// The specified state machine is being deleted.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.StateMachineDoesNotExistException">
        /// The specified state machine does not exist.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        UpdateStateMachineResponse UpdateStateMachine(UpdateStateMachineRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachine operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStateMachine
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        IAsyncResult BeginUpdateStateMachine(UpdateStateMachineRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStateMachine operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStateMachine.</param>
        /// 
        /// <returns>Returns a  UpdateStateMachineResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachine">REST API Reference for UpdateStateMachine Operation</seealso>
        UpdateStateMachineResponse EndUpdateStateMachine(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateStateMachineAlias


        /// <summary>
        /// Updates the configuration of an existing state machine <a href="https://docs.aws.amazon.com/step-functions/latest/dg/concepts-state-machine-alias.html">alias</a>
        /// by modifying its <code>description</code> or <code>routingConfiguration</code>.
        /// 
        ///  
        /// <para>
        /// You must specify at least one of the <code>description</code> or <code>routingConfiguration</code>
        /// parameters to update a state machine alias.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <code>UpdateStateMachineAlias</code> is an idempotent API. Step Functions bases the
        /// idempotency check on the <code>stateMachineAliasArn</code>, <code>description</code>,
        /// and <code>routingConfiguration</code> parameters. Requests with the same parameters
        /// return an idempotent response.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This operation is eventually consistent. All <a>StartExecution</a> requests made within
        /// a few seconds use the latest alias configuration. Executions started immediately after
        /// calling <code>UpdateStateMachineAlias</code> may use the previous routing configuration.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Related operations:</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <a>CreateStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DescribeStateMachineAlias</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>ListStateMachineAliases</a> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <a>DeleteStateMachineAlias</a> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachineAlias service method.</param>
        /// 
        /// <returns>The response from the UpdateStateMachineAlias service method, as returned by StepFunctions.</returns>
        /// <exception cref="Amazon.StepFunctions.Model.ConflictException">
        /// Updating or deleting a resource can cause an inconsistent state. This error occurs
        /// when there're concurrent requests for <a>DeleteStateMachineVersion</a>, <a>PublishStateMachineVersion</a>,
        /// or <a>UpdateStateMachine</a> with the <code>publish</code> parameter set to <code>true</code>.
        /// 
        ///  
        /// <para>
        /// HTTP Status Code: 409
        /// </para>
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.InvalidArnException">
        /// The provided Amazon Resource Name (ARN) is not valid.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ResourceNotFoundException">
        /// Could not find the referenced resource.
        /// </exception>
        /// <exception cref="Amazon.StepFunctions.Model.ValidationException">
        /// The input does not satisfy the constraints specified by an Amazon Web Services service.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachineAlias">REST API Reference for UpdateStateMachineAlias Operation</seealso>
        UpdateStateMachineAliasResponse UpdateStateMachineAlias(UpdateStateMachineAliasRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateStateMachineAlias operation on AmazonStepFunctionsClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateStateMachineAlias
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachineAlias">REST API Reference for UpdateStateMachineAlias Operation</seealso>
        IAsyncResult BeginUpdateStateMachineAlias(UpdateStateMachineAliasRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateStateMachineAlias operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateStateMachineAlias.</param>
        /// 
        /// <returns>Returns a  UpdateStateMachineAliasResult from StepFunctions.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/states-2016-11-23/UpdateStateMachineAlias">REST API Reference for UpdateStateMachineAlias Operation</seealso>
        UpdateStateMachineAliasResponse EndUpdateStateMachineAlias(IAsyncResult asyncResult);

        #endregion
        
    }
}