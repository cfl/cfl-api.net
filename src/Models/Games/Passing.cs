﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class Passing
	{
		[JsonProperty(PropertyName = "pass_attempts")]
		public int PassAttempts { get; set; }

		[JsonProperty(PropertyName = "pass_completions")]
		public int PassCompletions { get; set; }

		[JsonProperty(PropertyName = "pass_net_yards")]
		public int NetYards { get; set; }

		[JsonProperty(PropertyName = "pass_long")]
		public int PassLong { get; set; }

		[JsonProperty(PropertyName = "pass_touchdowns")]
		public int PassTouchdowns { get; set; }

		[JsonProperty(PropertyName = "pass_completion_percentage")]
		public string PassCompletionPercentage { get; set; }

		[JsonProperty(PropertyName = "pass_efficiency")]
		public string PassEfficiency { get; set; }

		[JsonProperty(PropertyName = "pass_interceptions")]
		public int PassInterceptions { get; set; }

	}
}