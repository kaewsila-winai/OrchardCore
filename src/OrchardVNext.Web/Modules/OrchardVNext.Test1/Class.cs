﻿using System;

namespace OrchardVNext.Test1 {
    public interface ITestDependency : IDependency{}

    public class Class : ITestDependency {
        public Class() {
        }
    }
}