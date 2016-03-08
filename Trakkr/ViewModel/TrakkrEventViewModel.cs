﻿using Trakkr.Core;
using Trakkr.Core.Events;

namespace Trakkr.ViewModel
{
    public class TrakkrEventViewModel : Event<IRepositoryPayload>
    {
        public string Time
        {
            get { return Timestamp.ToShortTimeString(); }
        }

        public string Kind
        {
            get
            {
                string result = "stop";
                if (Type == EventType.Start)
                {
                    result = "start";
                }
                return result;
            }
        }
    }
}