/**
* Copyright 2018 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
*/

using Newtonsoft.Json;

namespace IBM.WatsonDeveloperCloud.Assistant.v2.Model
{
    /// <summary>
    /// State information for the conversation.
    /// </summary>
    public class MessageContext : BaseModel
    {
        /// <summary>
        /// Contains information that can be shared by all skills within the Assistant.
        /// </summary>
        [JsonProperty("global", NullValueHandling = NullValueHandling.Ignore)]
        public MessageContextGlobal Global { get; set; }
        /// <summary>
        /// Contains information specific to particular skills within the Assistant.
        /// </summary>
        [JsonProperty("skills", NullValueHandling = NullValueHandling.Ignore)]
        public dynamic Skills { get; set; }
    }

}
