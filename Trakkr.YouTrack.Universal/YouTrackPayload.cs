﻿using Trakkr.Core;

namespace Trakkr.YouTrack
{
    public class YouTrackPayload : IRepositoryPayload
    {
        public string Query { get; set; }
        public string TicketId { get; set; }
        public string WorkItemId { get; set; }
    }
}