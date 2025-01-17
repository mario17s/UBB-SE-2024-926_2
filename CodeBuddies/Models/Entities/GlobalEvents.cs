﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBuddies.Models.Entities
{
    public static class GlobalEvents
    {
        public delegate void BuddyAddedToSessionEventHandler(long buddyId, long sessionId);

        public static event BuddyAddedToSessionEventHandler BuddyAddedToSession;

        public static void RaiseBuddyAddedToSessionEvent(long buddyId, long sessionId)
        {
            BuddyAddedToSession?.Invoke(buddyId, sessionId);
        }

        public delegate void BuddyPinnedHandler();

        public static event BuddyPinnedHandler BuddyPinned;

        public static void RaiseBuddyPinned()
        {
            BuddyPinned?.Invoke();
        }
    }

}
