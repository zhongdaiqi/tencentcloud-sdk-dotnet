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

namespace TencentCloud.Nlp.V20190408.Models
{
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using TencentCloud.Common;

    public class SentimentAnalysisResponse : AbstractModel
    {
        
        /// <summary>
        /// 负面情感概率
        /// </summary>
        [JsonProperty("Negative")]
        public float? Negative{ get; set; }

        /// <summary>
        /// 中性情感概率，当输入参数Mode取值为3class时有效，否则值为空
        /// </summary>
        [JsonProperty("Neutral")]
        public float? Neutral{ get; set; }

        /// <summary>
        /// 正面情感概率
        /// </summary>
        [JsonProperty("Positive")]
        public float? Positive{ get; set; }

        /// <summary>
        /// 情感分类结果：
        /// 1、positive，表示正面情感
        /// 2、negative，表示负面情感
        /// 3、neutral，表示中性、无情感
        /// </summary>
        [JsonProperty("Sentiment")]
        public string Sentiment{ get; set; }

        /// <summary>
        /// 唯一请求 ID，每次请求都会返回。定位问题时需要提供该次请求的 RequestId。
        /// </summary>
        [JsonProperty("RequestId")]
        public string RequestId{ get; set; }


        /// <summary>
        /// For internal usage only. DO NOT USE IT.
        /// </summary>
        internal override void ToMap(Dictionary<string, string> map, string prefix)
        {
            this.SetParamSimple(map, prefix + "Negative", this.Negative);
            this.SetParamSimple(map, prefix + "Neutral", this.Neutral);
            this.SetParamSimple(map, prefix + "Positive", this.Positive);
            this.SetParamSimple(map, prefix + "Sentiment", this.Sentiment);
            this.SetParamSimple(map, prefix + "RequestId", this.RequestId);
        }
    }
}

