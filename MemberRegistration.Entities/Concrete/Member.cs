﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DevFramework.Core.Entities;
namespace MemberRegistration.Entities.Concrete
{
    public class Member:IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int DateOfBirth { get; set; }
        public string TcNo { get; set; }

    }
}
