﻿using System.ComponentModel.DataAnnotations;

namespace Soccer.Web.Data.Entities
{
    public class GroupEntity
    {
        public int Id { get; set; }

        [MaxLength(30, ErrorMessage = "The field {0} can not have more than {1} characters.")]
        [Required(ErrorMessage = "The field {0} is mandatory.")]
        public string Name { get; set; }
        public TournamentEntity Tournament { get; set; }
    }
}