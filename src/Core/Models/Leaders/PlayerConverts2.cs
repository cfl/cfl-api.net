﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerConverts2 : PlayerLeader
	{
		[JsonProperty("converts_2pt")]
		public int Converts2 { get; set; }
	}
}
