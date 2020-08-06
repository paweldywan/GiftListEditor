using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.BLL.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    [DataContract]
    public enum Folder
    {
        [EnumMember(Value = "Inbox")]
        Inbox = 1,

        [EnumMember(Value = "Archive")]
        Archive,

        [EnumMember(Value = "Sent")]
        Sent,

        [EnumMember(Value = "Spam")]
        Spam
    }
}
