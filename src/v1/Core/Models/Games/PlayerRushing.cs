﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace mdryden.cflapi.v1.Models.Games
{
	public class PlayerRushing : Rushing
	{
		[JsonIgnore]
		public int GameId { get; set; }

		[JsonIgnore]
		public int PlayerId
		{
			get { return Player.CflCentralId; }
			set { Player.CflCentralId = value; }
		}

		[JsonProperty("player")]
		public PlayerSummary Player { get; set; }
	}
}
