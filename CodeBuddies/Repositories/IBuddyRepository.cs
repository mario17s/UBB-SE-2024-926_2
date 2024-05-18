﻿using CodeBuddies.Models.Entities;

namespace CodeBuddies.Repositories
{
    public interface IBuddyRepository
    {
        List<IBuddy> GetActiveBuddies();
        List<IBuddy> GetAllBuddies();
        List<IBuddy> GetInactiveBuddies();
        IBuddy UpdateBuddyStatus(IBuddy buddy);
        void AddBuddy(long buddyId, string buddyName, string buddyProfile, string status);
        void ClearDatabase();
    }
}