using FluentValidation;
using danske.scheduler.common.domain.models;

namespace danske.scheduler.producer.api.validators
{
    public class CompanyValidator : AbstractValidator<CompanyDto>
	{
		public CompanyValidator()
		{
			RuleFor(x => x.Name).NotEmpty().NotNull();
			RuleFor(x => x.Number).Must(x => x != null || x.Length == 10).Matches(@"^[\d]+$");
		}
	}
}
