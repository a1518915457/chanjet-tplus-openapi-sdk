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
    public class QueryWarehouseRequest : IRequest<QueryWarehouseResponse>
    {
        public string GetResourceMethod()
        {
            return "warehouse/Query";
        }

        [JsonProperty("param")]
        public WarehouseEntityDTO Param { get; set; }
    }
}