using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrackMyWork.API.Models
{
    public class UserRoles
    {
        public int Id { get; set; }

        public int UserId { get; set; } //FK to User
        public int Admin { get; set; } //SuperUser
        public int Executor { get; set; } //Lower personnel
        public int LineManager { get; set; } //Managers
        public int GroupManager { get; set; } //TeamChief

    }
}
