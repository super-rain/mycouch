﻿using System;

namespace MyCouch.Requests
{
#if !NETFX_CORE
    [Serializable]
#endif
    public class GetDatabaseRequest : Request { }
}