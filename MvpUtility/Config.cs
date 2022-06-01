// -----------------------------------------------------------------------
// <copyright file="Config.cs" company="Undid-Iridium">
// Copyright (c) Undid-Iridium. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace MvpUtility
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using Exiled.API.Interfaces;

    /// <summary>
    /// Config file.
    /// </summary>
    public class Config : IConfig
    {
        /// <inheritdoc />
        public bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether control over to enable or disable debug information.
        /// </summary>
        [Description("控制以启用或禁用调试信息")]
        public bool EnableDebug { get; set; } = false;

        /// <summary>
        /// Gets or sets what types of end round outputs should be shown.
        /// </summary>
        [Description("控制要显示的类型")]
        public RoundEndConfigurations RoundEndBehaviors { get; set; } = new RoundEndConfigurations();

        /// <summary>
        /// Gets or sets interval from user settings.
        /// </summary>
        [Description("检查Scp106的频率")]
        public float CheckInterval { get; set; } = 10f;

        /// <summary>
        /// Gets or sets a value indicating whether to track suicides.
        /// </summary>
        [Description("是否追踪自杀事件。")]
        public bool TrackSuicides { get; set; } = false;

        /// <summary>
        /// Gets or sets how long to display hint.
        /// </summary>
        [Description("显示提示的时间。")]
        public float HintDisplayLimit { get; set; } = 10f;

        /// <summary>
        /// Gets or sets a value indicating whether whether or not to show the MVP screen the following round start.
        /// </summary>
        [Description("显示MVP屏幕下一轮开始")]
        public bool ShowOnRoundStart { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether whether or not to show the MVP screen on round end.
        /// </summary>
        [Description("下一轮结束时显示MVP屏幕")]
        public bool ShowOnRoundEnd { get; set; } = true;

        /// <summary>
        /// Control over what types to show, whether its first come or random per round.
        /// </summary>
        [Description("控制要显示的类型，无论是第一次显示还是每轮随机显示")]
        public class RoundEndConfigurations
        {
            /// <summary>
            /// Gets or sets a value indicating whether control over what types to show, whether its first come or random per round.
            /// </summary>
            [Description("控制要显示的类型，无论是第一次显示还是每轮随机显示")]
            public bool RandomOutputs { get; set; } = true;

            /// <summary>
            /// Gets or sets whether to show first player escape.
            /// </summary>
            [Description("是否显示第一个玩家转义，只需要两个参数, Player, Float ( use {0} {1})")]
            public Dictionary<bool, string> ShowFirstEscape { get; set; } = new Dictionary<bool, string> { { true, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show who killed the most entities.
            /// </summary>
            [Description("是否显示谁杀死了最多的实体，只需要两个参数 Player, Int ( use {0} {1})")]
            public Dictionary<bool, string> ShowMostKillsKiller { get; set; } = new Dictionary<bool, string> { { true, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show who killed the most humans as SCP on team.
            /// </summary>
            [Description("是否以SCP的形式显示谁杀的人最多，只需要三个参数")]
            public Dictionary<bool, string> ShowMostKillsScpTeam { get; set; } = new Dictionary<bool, string> { { true, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show who killed the most humans as MTF on team.
            /// </summary>
            [Description("是否以MTF的形式显示谁杀的人最多，只需要三个参数")]
            public Dictionary<bool, string> ShowMostKillsMtfTeam { get; set; } = new Dictionary<bool, string> { { true, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show who killed the most humans as CHAOS on team.
            /// </summary>
            [Description("是否显示混沌中谁杀的人最多，只需要三个参数")]
            public Dictionary<bool, string> ShowMostKillsChaosTeam { get; set; } = new Dictionary<bool, string> { { true, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show who killed the most humans as human.
            /// </summary>
            [Description("是否显示谁作为人类杀死了最多的人，只需要三个参数")]
            public Dictionary<bool, string> ShowMostKillsHumanOnHuman { get; set; } = new Dictionary<bool, string> { { true, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show who killed the least humans as human.
            /// </summary>
            [Description("是否显示谁杀的人最少，只需要三个参数")]
            public Dictionary<bool, string> ShowLeastKillsHuman { get; set; } = new Dictionary<bool, string> { { false, string.Empty } };

            /// <summary>
            /// Gets or sets whether to show what to default to.
            /// </summary>
            [Description("无人转义时的默认输出（无参数）")]
            public Dictionary<bool, string> NoEscapeString { get; set; } = new Dictionary<bool, string> { { false, string.Empty } };

            /// <summary>
            /// Gets a value indicating whether gets or sets whether to show what to default to.
            /// </summary>
            [Description("是否强制持续更新")]
            public bool ForceConstantUpdate { get; internal set; } = false;

            /// <summary>
            /// Gets whether to show what to default to.
            /// </summary>
            [Description("提示限制")]
            public ushort HintLimit { get; internal set; } = 3;
        }
    }
}
