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

namespace TencentCloud.Tsf.V20180326.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class DeployGroupRequest : AbstractModel
    {
        
        /// <summary>
        /// 部署组ID
        /// </summary>
        [JsonProperty("GroupId")]
        public string GroupId{ get; set; }

        /// <summary>
        /// 程序包ID
        /// </summary>
        [JsonProperty("PkgId")]
        public string PkgId{ get; set; }

        /// <summary>
        /// 部署组启动参数
        /// </summary>
        [JsonProperty("StartupParameters")]
        public string StartupParameters{ get; set; }

        /// <summary>
        /// 部署应用描述信息
        /// </summary>
        [JsonProperty("DeployDesc")]
        public string DeployDesc{ get; set; }

        /// <summary>
        /// 是否允许强制启动
        /// </summary>
        [JsonProperty("ForceStart")]
        public bool? ForceStart{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "GroupId", this.GroupId);
            this.SetParamSimple(map, prefix + "PkgId", this.PkgId);
            this.SetParamSimple(map, prefix + "StartupParameters", this.StartupParameters);
            this.SetParamSimple(map, prefix + "DeployDesc", this.DeployDesc);
            this.SetParamSimple(map, prefix + "ForceStart", this.ForceStart);
        }
    }
}

