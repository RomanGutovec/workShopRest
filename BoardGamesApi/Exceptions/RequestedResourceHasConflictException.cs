﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace BoardGamesApi.Services
{
    [Serializable]
    public class RequestedResourceHasConflictException : Exception
    {
        public RequestedResourceHasConflictException()
        {
        }

        public RequestedResourceHasConflictException(string message)
            : base(message)
        {
        }

        public RequestedResourceHasConflictException(string message, Exception inner)
            : base(message, inner)
        {
        }

        protected RequestedResourceHasConflictException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
