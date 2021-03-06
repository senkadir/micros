﻿using System;

namespace micros.services.infrastructure
{
    public class ServiceConfig
    {
        public Uri ServiceDiscoveryAddress { get; set; }
        public Uri ServiceAddress { get; set; }
        public string ServiceName { get; set; }
        public string ServiceId { get; set; }
        public int HealthCheckInterval { get; set; } = 10;
    }
}
