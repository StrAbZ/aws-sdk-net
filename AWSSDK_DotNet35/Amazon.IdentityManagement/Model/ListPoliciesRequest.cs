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
 * Do not modify this file. This file is generated from the iam-2010-05-08.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.IdentityManagement.Model
{
    /// <summary>
    /// Container for the parameters to the ListPolicies operation.
    /// Lists all the managed policies that are available to your account, including your
    /// own customer managed policies and all AWS managed policies. 
    /// 
    ///  
    /// <para>
    /// You can filter the list of policies that is returned using the optional <code>OnlyAttached</code>,
    /// <code>Scope</code>, and <code>PathPrefix</code> parameters. For example, to list only
    /// the customer managed policies in your AWS account, set <code>Scope</code> to <code>Local</code>.
    /// To list only AWS managed policies, set <code>Scope</code> to <code>AWS</code>. 
    /// </para>
    ///  
    /// <para>
    /// You can paginate the results using the <code>MaxItems</code> and <code>Marker</code>
    /// parameters. 
    /// </para>
    ///  
    /// <para>
    /// For more information about managed policies, refer to <a href="http://docs.aws.amazon.com/IAM/latest/UserGuide/policies-managed-vs-inline.html">Managed
    /// Policies and Inline Policies</a> in the <i>Using IAM</i> guide. 
    /// </para>
    /// </summary>
    public partial class ListPoliciesRequest : AmazonIdentityManagementServiceRequest
    {
        private string _marker;
        private int? _maxItems;
        private bool? _onlyAttached;
        private string _pathPrefix;
        private PolicyScopeType _scope;

        /// <summary>
        /// Gets and sets the property Marker. 
        /// <para>
        /// Use this parameter only when paginating results, and only in a subsequent request
        /// after you've received a response where the results are truncated. Set it to the value
        /// of the <code>Marker</code> element in the response you just received.
        /// </para>
        /// </summary>
        public string Marker
        {
            get { return this._marker; }
            set { this._marker = value; }
        }

        // Check to see if Marker property is set
        internal bool IsSetMarker()
        {
            return this._marker != null;
        }

        /// <summary>
        /// Gets and sets the property MaxItems. 
        /// <para>
        /// Use this parameter only when paginating results to indicate the maximum number of
        /// policies you want in the response. If there are additional policies beyond the maximum
        /// you specify, the <code>IsTruncated</code> response element is <code>true</code>. This
        /// parameter is optional. If you do not include it, it defaults to 100.
        /// </para>
        /// </summary>
        public int MaxItems
        {
            get { return this._maxItems.GetValueOrDefault(); }
            set { this._maxItems = value; }
        }

        // Check to see if MaxItems property is set
        internal bool IsSetMaxItems()
        {
            return this._maxItems.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OnlyAttached. 
        /// <para>
        /// A flag to filter the results to only the attached policies. 
        /// </para>
        ///  
        /// <para>
        /// When <code>OnlyAttached</code> is <code>true</code>, the returned list contains only
        /// the policies that are attached to a user, group, or role. When <code>OnlyAttached</code>
        /// is <code>false</code>, or when the parameter is not included, all policies are returned.
        /// </para>
        /// </summary>
        public bool OnlyAttached
        {
            get { return this._onlyAttached.GetValueOrDefault(); }
            set { this._onlyAttached = value; }
        }

        // Check to see if OnlyAttached property is set
        internal bool IsSetOnlyAttached()
        {
            return this._onlyAttached.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PathPrefix. 
        /// <para>
        /// The path prefix for filtering the results. This parameter is optional. If it is not
        /// included, it defaults to a slash (/), listing all policies.
        /// </para>
        /// </summary>
        public string PathPrefix
        {
            get { return this._pathPrefix; }
            set { this._pathPrefix = value; }
        }

        // Check to see if PathPrefix property is set
        internal bool IsSetPathPrefix()
        {
            return this._pathPrefix != null;
        }

        /// <summary>
        /// Gets and sets the property Scope. 
        /// <para>
        /// The scope to use for filtering the results. 
        /// </para>
        ///  
        /// <para>
        /// To list only AWS managed policies, set <code>Scope</code> to <code>AWS</code>. To
        /// list only the customer managed policies in your AWS account, set <code>Scope</code>
        /// to <code>Local</code>. 
        /// </para>
        ///  
        /// <para>
        /// This parameter is optional. If it is not included, or if it is set to <code>All</code>,
        /// all policies are returned.
        /// </para>
        /// </summary>
        public PolicyScopeType Scope
        {
            get { return this._scope; }
            set { this._scope = value; }
        }

        // Check to see if Scope property is set
        internal bool IsSetScope()
        {
            return this._scope != null;
        }

    }
}