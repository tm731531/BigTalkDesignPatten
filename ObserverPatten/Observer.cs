﻿namespace ObserverPatten
{
    /// <summary>
    ///     抽象观察者，为所有的具体观察者定义一个接口，在得到主题的通知时更新自己
    /// </summary>
    public abstract class Observer
    {
        public abstract void Update();
    }
}