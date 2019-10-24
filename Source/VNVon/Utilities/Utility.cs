using FluentValidation.Results;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using VNVon.Service.CustomException;

namespace VNVon.Utilities
{
    public static class Utility
    {
        public static object GetModelMessage(IList<ValidationFailure> errors)
        {
            var invalidMessages = new List<string>();

            foreach (var error in errors)
            {
                invalidMessages.Add(error.ErrorMessage);
            }

            return invalidMessages;
        }
    }
}
