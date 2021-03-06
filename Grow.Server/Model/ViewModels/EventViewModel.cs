﻿using Grow.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Grow.Server.Model.ViewModels
{
    public class EventViewModel
    {
        [Required]
        public int Id { get; set; }

        [DisplayName("Event")]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime Start { get; set; }

        public DateTime End { get; set; }

        public bool HasTimesSet { get; set; }
        
        [DisplayName("Link to the online event page")]
        public string ExternalEventUrl { get; set; }

        public string Location { get; set; }

        public string Address { get; set; }

        [DisplayName("Target audience")]
        public string Visibility { get; set; }

        public string Type { get; set; }

        [DisplayName("Is mandatory for teams?")]
        public bool IsMandatory { get; set; }

        [DisplayName("Can visitors register?")]
        public bool CanVisitorsRegister { get; set; }

        [DisplayName("Can teams register?")]
        public bool CanTeamsRegister { get; set; }

        public TeamRegistrationOptions TeamRegistrationOptions { get; set; }

        [DisplayName("Link to the event logo")]
        public string ImageUrl { get; set; }

        [DisplayName("Held by")]
        public string HeldByName { get; set; }

        [DisplayName("Partner Website")]
        public string HeldByUrl { get; set; }

        public EventViewModel()
        {
        }

        public EventViewModel(Event evnt)
        {
            CopyPropertiesFrom(evnt);
        }

        private void CopyPropertiesFrom(Event evnt)
        {
            Id = evnt.Id;
            Name = evnt.Name;
            Description = evnt.Description;
            Start = evnt.Start;
            End = evnt.End;
            HasTimesSet = evnt.HasTimesSet;
            ExternalEventUrl = evnt.ExternalEventUrl;
            Location = evnt.Location;
            Address = evnt.Address;
            IsMandatory = evnt.IsMandatory;
            CanTeamsRegister = evnt.CanTeamsRegister;
            CanVisitorsRegister = evnt.CanVisitorsRegister;
            TeamRegistrationOptions = evnt.TeamRegistrationOptions;

            ImageUrl = evnt.Image?.Url;
            HeldByName = evnt.HeldBy?.Name;
            HeldByUrl = evnt.HeldBy?.WebsiteUrl;
            
            switch (evnt.Visibility)
            {
                case Event.EventVisibility.ForActiveTeams:
                    Visibility = "Private - Only for actively enrolled teams";
                    break;
                case Event.EventVisibility.ForAllTeams:
                    Visibility = "Private - For all registered teams";
                    break;
                default:
                    Visibility = "Public - Everyone can come and watch";
                    break;
            }
            switch (evnt.Type)
            {
                case Event.EventType.MainEvent:
                    Type = "Main event";
                    break;
                default:
                    Type = evnt.Type.ToString();
                    break;
            }
        }
    }
}
