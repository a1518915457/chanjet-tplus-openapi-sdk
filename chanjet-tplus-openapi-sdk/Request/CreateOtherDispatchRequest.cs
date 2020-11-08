﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPlus.Api.Domain;
using TPlus.Api.Response;

namespace TPlus.Api.Request
{
    public class CreateOtherDispatchRequest : IRequest<CreateOtherDispatchResponse>
    {
        public string GetResourceMethod()
        {
            return "otherDispatch/Create";
        }

        [JsonProperty("dto")]
        public RDRecordDTO OtherDispatch { get; set; }
    }
}