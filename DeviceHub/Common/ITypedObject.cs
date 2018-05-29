using System;
using System.Collections.Generic;

namespace Alkl.DeviceHub.Common
{
    public interface ITypedObject : IDictionary<string, ITypedObject>
    {
        Type Type { get; }

        bool? GetBool();

        int? GetInt();

        double? GetDouble();

        string GetString();
    }
}