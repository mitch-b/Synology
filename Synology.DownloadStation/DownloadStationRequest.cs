﻿using Synology.Attributes;
using Synology.Classes;

namespace Synology.DownloadStation
{
    [Request("DownloadStation")]
    public abstract class DownloadStationRequest : SynologyRequest
    {
        protected DownloadStationRequest(SynologyApi parentApi, string cgiPath, string api) : base(parentApi, $"DownloadStation/{cgiPath}", $"DownloadStation.{api}")
        {
        }
    }
}