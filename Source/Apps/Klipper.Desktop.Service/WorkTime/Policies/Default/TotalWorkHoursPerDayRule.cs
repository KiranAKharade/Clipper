﻿using System;
using System.Collections.Generic;

namespace Klipper.Desktop.Service.WorkTime.Policies.Default
{
    internal class TotalWorkHoursPerDayRule : IWorkTimeRule
    {
        public bool Validate(WorkDay context)
        {


            return true;
        }
    }
}