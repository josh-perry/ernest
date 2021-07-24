using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Ernest.Api.Models.Requests;

namespace Ernest.Api.Services.Interfaces
{
    public interface IEventValidator
    {
        IEnumerable<ValidationResult> ValidateEventPost(EventPostRequest request);
    }
}
