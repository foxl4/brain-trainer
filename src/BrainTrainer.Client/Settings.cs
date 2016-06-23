﻿using System;
using BrainTrainer.Client.Enums;
using BrainTrainer.Client.Extensions;

namespace BrainTrainer.Client
{
    public class Settings
    {
        public Mode Mode { get; set; } = Mode.Random;
        public Competition Competition { get; set; } = Competition.BrainRing;
        public Complexity Complexity { get; set; } = Complexity.None;
        public int Limit { get; set; } = 1;
        public bool ShowAnswers { get; set; } = true;

        public override string ToString()
        {
            return base.ToString();
        }

        public string ToUrlString()
        {
            //ToDO: Implement ToUrlString method
            return String.Empty;
        }
    }
}