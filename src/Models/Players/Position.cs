﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Players
{
	public class Position
	{
		[JsonProperty(PropertyName = "position_id")]
		public int PositionId { get; set; }

		[JsonProperty(PropertyName = "offence_defence_or_special")]
		public string OffenseDefenceOrSpecial { get; set; }

		[JsonProperty(PropertyName = "abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty(PropertyName = "description")]
		public string Description { get; set; }

	}
}