﻿using System.Runtime.Serialization;

namespace Contract_Report2.ModelDataLayer.Repository
{
    [Serializable]
    internal class EntityNotFoundException : Exception
    {
        private Type type;
        private object id;

        public EntityNotFoundException()
        {
        }

        public EntityNotFoundException(string? message) : base(message)
        {
        }

        public EntityNotFoundException(Type type, object id)
        {
            this.type = type;
            this.id = id;
        }

        public EntityNotFoundException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected EntityNotFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}