using AutoMapper;
using danske.scheduler.api.strategy;
using danske.scheduler.common.domain.entities;
using danske.scheduler.common.domain.models;
using danske.scheduler.common.infrastructure;
using danske.scheduler.common.infrastructure.repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace danske.scheduler.api.services
{
    public class ScheduleService : IScheduleService
    {
        private readonly IRepository<Notification> _notificationRepository;
        private readonly IRepository<Company> _companyRepository;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public ScheduleService(IMapper mapper, IUnitOfWork unitOfWork)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
            _notificationRepository = _unitOfWork.GetRepository<Notification>();
            _companyRepository = _unitOfWork.GetRepository<Company>();
        }

        public ScheduleResponse CreateNotifications(ScheduleRequest schedule)
        {
            var _notificationFactory = new NotificationFactory();
            var _notificationOperation = _notificationFactory.CreateNotificationOperation(schedule.Company.Market);

            var notifications = _notificationOperation.CreateNotifications(schedule.Company.Type);
            var company = _mapper.Map<Company>(schedule.Company);

            _companyRepository.Add(company);

            foreach (var notif in notifications)
            {
                notif.Company = company;
                notif.CompanyId = company.Id;
            }

            _notificationRepository.AddRange(notifications);

            _unitOfWork.Commit();

            return new ScheduleResponse()
            {
                CompanyId = company.Id,
                Notifications = _mapper.Map<List<NotificationDto>>(notifications)
            };
        }
    }
}
