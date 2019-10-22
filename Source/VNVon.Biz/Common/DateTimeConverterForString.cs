using AutoMapper;
using System;
using System.Globalization;

namespace VNVon.Service.Common
{
    public class DateTimeConverterForString : ITypeConverter<string, DateTime>
    {
        public DateTime Convert(string source, DateTime destination, ResolutionContext context)
        {
            return DateTime.ParseExact(source, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        }
    }
}
