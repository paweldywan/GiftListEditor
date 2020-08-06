using GiftListEditor.BLL.Models;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace GiftListEditor.DAL.DTO
{
    [DataContract]
    public class TaskDtos
    {
        [DataMember(Name = "tasks")]
        public List<Task> Tasks { get; set; }

        public static implicit operator TaskDtos(List<Task> t) => new TaskDtos { Tasks = t };
    }
}
