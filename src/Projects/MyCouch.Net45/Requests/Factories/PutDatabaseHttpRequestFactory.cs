﻿using System.Net.Http;
using MyCouch.Net;

namespace MyCouch.Requests.Factories
{
    public class PutDatabaseHttpRequestFactory : DatabaseHttpRequestFactoryBase
    {
        public PutDatabaseHttpRequestFactory(IConnection connection) : base(connection) { }

        public virtual HttpRequest Create(PutDatabaseRequest request)
        {
            var httpRequest = CreateFor<PutDatabaseRequest>(HttpMethod.Put, GenerateRequestUrl());

            return httpRequest;
        }
    }
}