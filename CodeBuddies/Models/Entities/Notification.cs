﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBuddies.Models.Entities
{
    public abstract class Notification : INotification
    {
        protected long notificationId;

        public long NotificationId
        {
            get { return notificationId; }
            set { notificationId = value; }
        }
        protected DateTime timeStamp;

        public DateTime TimeStamp
        {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        protected string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        protected string status;

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        protected string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        protected long senderId;
        public long SenderId
        {
            get { return senderId; }
            set { senderId = value; }
        }

        protected long receiverId;
        public long ReceiverId
        {
            get { return receiverId; }
            set { receiverId = value; }
        }

        protected long sessionId;
        public long SessionId
        {
            get { return sessionId; }
            set { sessionId = value; }
        }


        public Notification(long notificationId, DateTime timeStamp, string type, string status, string description, long senderId, long receiverId, long sessionId)
        {
            NotificationId = notificationId;
            TimeStamp = timeStamp;
            Type = type;
            Status = status;
            Description = description;
            SenderId = senderId;
            ReceiverId = receiverId;
            SessionId = sessionId;
        }

        public Notification()
        {

        }

        protected abstract void MarkNotification();
    }
}
