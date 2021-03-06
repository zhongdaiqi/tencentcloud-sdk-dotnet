/*
 * Copyright (c) 2018 THL A29 Limited, a Tencent company. All Rights Reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing,
 * software distributed under the License is distributed on an
 * "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY
 * KIND, either express or implied.  See the License for the
 * specific language governing permissions and limitations
 * under the License.
 */

namespace TencentCloud.Monitor.V20180724
{

   using Newtonsoft.Json;
   using System.Threading.Tasks;
   using TencentCloud.Common;
   using TencentCloud.Common.Profile;
   using TencentCloud.Monitor.V20180724.Models;

   public class MonitorClient : AbstractClient{

       private const string endpoint = "monitor.tencentcloudapi.com";
       private const string version = "2018-07-24";

        /// <summary>
        /// Client constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        public MonitorClient(Credential credential, string region)
            : this(credential, region, new ClientProfile())
        {

        }

        /// <summary>
        /// Client Constructor.
        /// </summary>
        /// <param name="credential">Credentials.</param>
        /// <param name="region">Region name, such as "ap-guangzhou".</param>
        /// <param name="profile">Client profiles.</param>
        public MonitorClient(Credential credential, string region, ClientProfile profile)
            : base(endpoint, version, credential, region, profile)
        {

        }

        /// <summary>
        /// 将告警策略绑定到特定对象
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public async Task<BindingPolicyObjectResponse> BindingPolicyObject(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 将告警策略绑定到特定对象
        /// </summary>
        /// <param name="req"><see cref="BindingPolicyObjectRequest"/></param>
        /// <returns><see cref="BindingPolicyObjectResponse"/></returns>
        public BindingPolicyObjectResponse BindingPolicyObjectSync(BindingPolicyObjectRequest req)
        {
             JsonResponseModel<BindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "BindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<BindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加策略组
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public async Task<CreatePolicyGroupResponse> CreatePolicyGroup(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 增加策略组
        /// </summary>
        /// <param name="req"><see cref="CreatePolicyGroupRequest"/></param>
        /// <returns><see cref="CreatePolicyGroupResponse"/></returns>
        public CreatePolicyGroupResponse CreatePolicyGroupSync(CreatePolicyGroupRequest req)
        {
             JsonResponseModel<CreatePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "CreatePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<CreatePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略组
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public async Task<DeletePolicyGroupResponse> DeletePolicyGroup(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除告警策略组
        /// </summary>
        /// <param name="req"><see cref="DeletePolicyGroupRequest"/></param>
        /// <returns><see cref="DeletePolicyGroupResponse"/></returns>
        public DeletePolicyGroupResponse DeletePolicyGroupSync(DeletePolicyGroupRequest req)
        {
             JsonResponseModel<DeletePolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DeletePolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DeletePolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public async Task<DescribeAccidentEventListResponse> DescribeAccidentEventList(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取平台事件列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAccidentEventListRequest"/></param>
        /// <returns><see cref="DescribeAccidentEventListResponse"/></returns>
        public DescribeAccidentEventListResponse DescribeAccidentEventListSync(DescribeAccidentEventListRequest req)
        {
             JsonResponseModel<DescribeAccidentEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAccidentEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAccidentEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警2.0-告警历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public async Task<DescribeAlarmHistoriesResponse> DescribeAlarmHistories(DescribeAlarmHistoriesRequest req)
        {
             JsonResponseModel<DescribeAlarmHistoriesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAlarmHistories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmHistoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 告警2.0-告警历史列表
        /// </summary>
        /// <param name="req"><see cref="DescribeAlarmHistoriesRequest"/></param>
        /// <returns><see cref="DescribeAlarmHistoriesResponse"/></returns>
        public DescribeAlarmHistoriesResponse DescribeAlarmHistoriesSync(DescribeAlarmHistoriesRequest req)
        {
             JsonResponseModel<DescribeAlarmHistoriesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAlarmHistories");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAlarmHistoriesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取所有名字空间
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public async Task<DescribeAllNamespacesResponse> DescribeAllNamespaces(DescribeAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 拉取所有名字空间
        /// </summary>
        /// <param name="req"><see cref="DescribeAllNamespacesRequest"/></param>
        /// <returns><see cref="DescribeAllNamespacesResponse"/></returns>
        public DescribeAllNamespacesResponse DescribeAllNamespacesSync(DescribeAllNamespacesRequest req)
        {
             JsonResponseModel<DescribeAllNamespacesResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeAllNamespaces");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeAllNamespacesResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础指标详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public async Task<DescribeBaseMetricsResponse> DescribeBaseMetrics(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础指标详情
        /// </summary>
        /// <param name="req"><see cref="DescribeBaseMetricsRequest"/></param>
        /// <returns><see cref="DescribeBaseMetricsResponse"/></returns>
        public DescribeBaseMetricsResponse DescribeBaseMetricsSync(DescribeBaseMetricsRequest req)
        {
             JsonResponseModel<DescribeBaseMetricsResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBaseMetrics");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBaseMetricsResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public async Task<DescribeBasicAlarmListResponse> DescribeBasicAlarmList(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBasicAlarmListRequest"/></param>
        /// <returns><see cref="DescribeBasicAlarmListResponse"/></returns>
        public DescribeBasicAlarmListResponse DescribeBasicAlarmListSync(DescribeBasicAlarmListRequest req)
        {
             JsonResponseModel<DescribeBasicAlarmListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBasicAlarmList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBasicAlarmListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取已绑定对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public async Task<DescribeBindingPolicyObjectListResponse> DescribeBindingPolicyObjectList(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取已绑定对象列表
        /// </summary>
        /// <param name="req"><see cref="DescribeBindingPolicyObjectListRequest"/></param>
        /// <returns><see cref="DescribeBindingPolicyObjectListResponse"/></returns>
        public DescribeBindingPolicyObjectListResponse DescribeBindingPolicyObjectListSync(DescribeBindingPolicyObjectListRequest req)
        {
             JsonResponseModel<DescribeBindingPolicyObjectListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeBindingPolicyObjectList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeBindingPolicyObjectListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警策略条件
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public async Task<DescribePolicyConditionListResponse> DescribePolicyConditionList(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础告警策略条件
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyConditionListRequest"/></param>
        /// <returns><see cref="DescribePolicyConditionListResponse"/></returns>
        public DescribePolicyConditionListResponse DescribePolicyConditionListSync(DescribePolicyConditionListRequest req)
        {
             JsonResponseModel<DescribePolicyConditionListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyConditionList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyConditionListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略组详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public async Task<DescribePolicyGroupInfoResponse> DescribePolicyGroupInfo(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略组详情
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupInfoRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupInfoResponse"/></returns>
        public DescribePolicyGroupInfoResponse DescribePolicyGroupInfoSync(DescribePolicyGroupInfoRequest req)
        {
             JsonResponseModel<DescribePolicyGroupInfoResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupInfo");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupInfoResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略告警组列表
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public async Task<DescribePolicyGroupListResponse> DescribePolicyGroupList(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取基础策略告警组列表
        /// </summary>
        /// <param name="req"><see cref="DescribePolicyGroupListRequest"/></param>
        /// <returns><see cref="DescribePolicyGroupListResponse"/></returns>
        public DescribePolicyGroupListResponse DescribePolicyGroupListSync(DescribePolicyGroupListRequest req)
        {
             JsonResponseModel<DescribePolicyGroupListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribePolicyGroupList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribePolicyGroupListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页获取产品事件的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public async Task<DescribeProductEventListResponse> DescribeProductEventList(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 分页获取产品事件的列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductEventListRequest"/></param>
        /// <returns><see cref="DescribeProductEventListResponse"/></returns>
        public DescribeProductEventListResponse DescribeProductEventListSync(DescribeProductEventListRequest req)
        {
             JsonResponseModel<DescribeProductEventListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductEventList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductEventListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云监控产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public async Task<DescribeProductListResponse> DescribeProductList(DescribeProductListRequest req)
        {
             JsonResponseModel<DescribeProductListResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "DescribeProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 查询云监控产品列表
        /// </summary>
        /// <param name="req"><see cref="DescribeProductListRequest"/></param>
        /// <returns><see cref="DescribeProductListResponse"/></returns>
        public DescribeProductListResponse DescribeProductListSync(DescribeProductListRequest req)
        {
             JsonResponseModel<DescribeProductListResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "DescribeProductList");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<DescribeProductListResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云产品的监控数据。传入产品的命名空间、对象维度描述和监控指标即可获得相应的监控数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求最多可支持批量拉取10个实例的监控数据，单请求的数据点数限制为1440个。
        /// 若您需要调用的指标、对象较多，可能存在因限频出现拉取失败的情况，建议尽量将请求按时间维度均摊。
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public async Task<GetMonitorDataResponse> GetMonitorData(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 获取云产品的监控数据。传入产品的命名空间、对象维度描述和监控指标即可获得相应的监控数据。
        /// 接口调用频率限制为：20次/秒，1200次/分钟。单请求最多可支持批量拉取10个实例的监控数据，单请求的数据点数限制为1440个。
        /// 若您需要调用的指标、对象较多，可能存在因限频出现拉取失败的情况，建议尽量将请求按时间维度均摊。
        /// </summary>
        /// <param name="req"><see cref="GetMonitorDataRequest"/></param>
        /// <returns><see cref="GetMonitorDataResponse"/></returns>
        public GetMonitorDataResponse GetMonitorDataSync(GetMonitorDataRequest req)
        {
             JsonResponseModel<GetMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "GetMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<GetMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public async Task<ModifyAlarmReceiversResponse> ModifyAlarmReceivers(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 修改告警接收人
        /// </summary>
        /// <param name="req"><see cref="ModifyAlarmReceiversRequest"/></param>
        /// <returns><see cref="ModifyAlarmReceiversResponse"/></returns>
        public ModifyAlarmReceiversResponse ModifyAlarmReceiversSync(ModifyAlarmReceiversRequest req)
        {
             JsonResponseModel<ModifyAlarmReceiversResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyAlarmReceivers");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyAlarmReceiversResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新策略组
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public async Task<ModifyPolicyGroupResponse> ModifyPolicyGroup(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 更新策略组
        /// </summary>
        /// <param name="req"><see cref="ModifyPolicyGroupRequest"/></param>
        /// <returns><see cref="ModifyPolicyGroupResponse"/></returns>
        public ModifyPolicyGroupResponse ModifyPolicyGroupSync(ModifyPolicyGroupRequest req)
        {
             JsonResponseModel<ModifyPolicyGroupResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "ModifyPolicyGroup");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<ModifyPolicyGroupResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 默认接口请求频率限制：50次/秒。
        /// 默认单租户指标上限：100个。
        /// 单次上报最多 30 个指标/值对，请求返回错误时，请求中所有的指标/值均不会被保存。
        /// 
        /// 上报的时间戳为期望保存的时间戳，建议构造整数分钟时刻的时间戳。
        /// 时间戳时间范围必须为当前时间到 300 秒前之间。
        /// 同一 IP 指标对的数据需按分钟先后顺序上报。
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public async Task<PutMonitorDataResponse> PutMonitorData(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 默认接口请求频率限制：50次/秒。
        /// 默认单租户指标上限：100个。
        /// 单次上报最多 30 个指标/值对，请求返回错误时，请求中所有的指标/值均不会被保存。
        /// 
        /// 上报的时间戳为期望保存的时间戳，建议构造整数分钟时刻的时间戳。
        /// 时间戳时间范围必须为当前时间到 300 秒前之间。
        /// 同一 IP 指标对的数据需按分钟先后顺序上报。
        /// </summary>
        /// <param name="req"><see cref="PutMonitorDataRequest"/></param>
        /// <returns><see cref="PutMonitorDataResponse"/></returns>
        public PutMonitorDataResponse PutMonitorDataSync(PutMonitorDataRequest req)
        {
             JsonResponseModel<PutMonitorDataResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "PutMonitorData");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<PutMonitorDataResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送自定义消息告警
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public async Task<SendCustomAlarmMsgResponse> SendCustomAlarmMsg(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 发送自定义消息告警
        /// </summary>
        /// <param name="req"><see cref="SendCustomAlarmMsgRequest"/></param>
        /// <returns><see cref="SendCustomAlarmMsgResponse"/></returns>
        public SendCustomAlarmMsgResponse SendCustomAlarmMsgSync(SendCustomAlarmMsgRequest req)
        {
             JsonResponseModel<SendCustomAlarmMsgResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "SendCustomAlarmMsg");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<SendCustomAlarmMsgResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public async Task<UnBindingAllPolicyObjectResponse> UnBindingAllPolicyObject(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除全部的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingAllPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingAllPolicyObjectResponse"/></returns>
        public UnBindingAllPolicyObjectResponse UnBindingAllPolicyObjectSync(UnBindingAllPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingAllPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingAllPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingAllPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public async Task<UnBindingPolicyObjectResponse> UnBindingPolicyObject(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = await this.InternalRequest(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

        /// <summary>
        /// 删除策略的关联对象
        /// </summary>
        /// <param name="req"><see cref="UnBindingPolicyObjectRequest"/></param>
        /// <returns><see cref="UnBindingPolicyObjectResponse"/></returns>
        public UnBindingPolicyObjectResponse UnBindingPolicyObjectSync(UnBindingPolicyObjectRequest req)
        {
             JsonResponseModel<UnBindingPolicyObjectResponse> rsp = null;
             try
             {
                 var strResp = this.InternalRequestSync(req, "UnBindingPolicyObject");
                 rsp = JsonConvert.DeserializeObject<JsonResponseModel<UnBindingPolicyObjectResponse>>(strResp);
             }
             catch (JsonSerializationException e)
             {
                 throw new TencentCloudSDKException(e.Message);
             }
             return rsp.Response;
        }

    }
}
