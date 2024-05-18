﻿using CodeBuddies.Models.Entities;
using CodeBuddies.MVVM;
using CodeBuddies.Repositories;
using CodeBuddies.Resources.Data;
using CodeBuddies.Services;
using static CodeBuddies.Models.Validators.ValidationForNewSession;

namespace CodeBuddies.ViewModels
{
    public class CreateNewSessionPopUpViewModel : ViewModelBase
    {
        private ISessionService sessionService;
        public CreateNewSessionPopUpViewModel()
        {
            ISessionRepository sessionRepository = new SessionRepository();
            sessionService = new SessionService(sessionRepository);
        }

        public void AddNewSession(string sessionName, string maxParticipants)
        {
            long sessionId =  sessionService.AddNewSession(sessionName, maxParticipants);
            GlobalEvents.RaiseBuddyAddedToSessionEvent(Constants.CLIENT_BUDDY_ID, sessionId);
        }
    }
}
