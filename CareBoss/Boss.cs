﻿using System;

namespace CareBoss
{
    internal class Boss : ISubject
    {
        public event Action Update;

        // 通知
        public string SubjectState { get; set; }

        public void Notify()
        {
            Update?.Invoke();
        }
    }
}