using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiftListEditor.BLL.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Folder
    {
        Inbox = 1,
        Archive,
        Sent,
        Spam
    }
}
