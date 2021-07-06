using FluentValidation;
using danske.scheduler.common.domain.models;

namespace danske.scheduler.producer.api.validators
{
    public class NotificationValidator : AbstractValidator<NotificationDto>
	{
		public NotificationValidator()
		{
			RuleFor(x => x.SendDate).NotNull();
		}
	}
}
