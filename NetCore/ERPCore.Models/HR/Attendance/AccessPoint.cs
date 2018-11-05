﻿using ERPCore.Models.Helpers;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPCore.Models.HR.Attendance
{
    public class AccessPoint
    {
        [BsonId]
        [JsonConverter(typeof(ObjectIdConverter))]
        public ObjectId _objetId { get; set; }

        public int ID { get; set; }

        public string Name { get; set; }

        public string IpAddress { get; set; }

    }
}
