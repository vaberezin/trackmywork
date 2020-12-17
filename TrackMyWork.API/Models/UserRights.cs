using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMyWork.API.Models
{
    public class UserRights
    {
        public int Id { get; set; } //PK
        public int UserId { get; set; } //FK
        public bool CreateProject { get; set; }
        public bool ManageUsers { get; set; }
        public bool CommentAnyTask { get; set; }
        public bool AccessHiddenCatalogue { get; set; }
        public bool Analysis { get; set; }
        public bool RSS { get; set; }
        public bool ChangeUserPermissions { get; set; }
        public bool ActivateUser { get; set; }
        public bool BlockUser { get; set; }
        public bool WatchUserStats { get; set; }
        public bool WatchUserSessions { get; set; }
        public bool ChangeStatusOfAnyTask { get; set; }
        public bool ChangeUserRoleOnProject { get; set; }


    }
}
