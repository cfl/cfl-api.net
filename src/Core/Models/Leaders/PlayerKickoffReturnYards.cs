﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mdryden.cflapi.v1.Models.Leaders
{
	public class PlayerKickoffReturnYards : PlayerLeader
	{
		[JsonProperty("kickoff_return_yards")]
		public int KickoffReturnYards { get; set; }
	}
}
