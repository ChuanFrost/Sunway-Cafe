﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunway_Cafe.Model;


namespace Sunway_Cafe.Model
{


    public class Account
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string GivenName { get; set; }

        public string FamilyName { get; set; }

        public string Gender { get; set; }

        public int Contact { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }

    }
}
