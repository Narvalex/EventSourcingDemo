﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EventSourcingDemo.Domain;

namespace EventSourcingDemo.Snapshot
{
    public interface ISnapshottable
    {
        Snapshot GetSnapshot();
        void SetSnapshot(Snapshot snapshot);
    }
}
