﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Requests.UserRequests
{
    public class UpdateUserRequest
    {
        public int Id { get; set; }
        public string NationalIdentity { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public int ImageId { get; set; }
        public DateTime BirthDate { get; set; }
        public string Password { get; set; }
    }
}
