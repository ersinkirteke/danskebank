using AutoMapper;
using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.models;
using System;

namespace danske.scheduler.producer.api.profiles
{
    public class NotificationProfile:Profile
    {
        public NotificationProfile()
        {
            CreateMap<Notification, NotificationDto>().ForMember(x => x.SendDate,
            opt => opt.MapFrom(src => ((DateTime)src.SendDate).ToString("dd/MM/yyyy")));
        }
    }
}
