using System;
using FluentValidation;
using Zeats.Error.Extensions;
using Zeats.Error.FluentValidation.Extensions;

namespace Zeats.Error.Parser.Extensions;

public static class ExceptionExtensions
{
    public static ErrorInfo ErrorInfo(this Exception exception)
    {
        if (exception is ValidationException validationException)
            return validationException.ToErrorInfo();

        return exception.ToErrorInfo();
    }
}