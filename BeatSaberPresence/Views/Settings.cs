﻿using Zenject;
using BeatSaberPresence.Config;
using BeatSaberMarkupLanguage.Attributes;
using BeatSaberMarkupLanguage.ViewControllers;

namespace BeatSaberPresence {
    [HotReload("Settings.bsml")]
    [ViewDefinition("BeatSaberPresence.Views.Settings.bsml")]
    internal class Settings : BSMLAutomaticViewController {
        private PluginConfig pluginConfig;
        private PresenceController presenceController;

        [Inject]
        protected void Construct(PluginConfig pluginConfig, PresenceController presenceController) {
            this.pluginConfig = pluginConfig;
            this.presenceController = presenceController;
        }

        [UIValue("enabled")]
        public bool Enable {
            get => pluginConfig.Enabled;
            set {
                pluginConfig.Enabled = value;
                presenceController.ClearActivity();
            }
        }

        [UIValue("large-image")]
        public bool LargeImage {
            get => pluginConfig.ShowImages;
            set => pluginConfig.ShowImages = value;
        }

        [UIValue("use-cover-image")]
        public bool UseCoverImage {
            get => pluginConfig.UseCoverImage;
            set => pluginConfig.UseCoverImage = value;
        }

        [UIValue("small-image")]
        public bool SmallImage {
            get => pluginConfig.ShowSmallImages;
            set => pluginConfig.ShowSmallImages = value;
        }

        [UIValue("show-diff")]
        public bool ShowDiff
        {
            get => pluginConfig.ShowDifficulty;
            set => pluginConfig.ShowDifficulty = value;
        }

        [UIValue("show-char")]
        public bool ShowChar
        {
            get => pluginConfig.ShowCharacteristic;
            set => pluginConfig.ShowCharacteristic = value;
        }

        [UIValue("timer")]
        public bool Timer {
            get => pluginConfig.ShowTimes;
            set => pluginConfig.ShowTimes = value;
        }

        [UIValue("countdown")]
        public bool Countdown {
            get => pluginConfig.InGameCountDown;
            set => pluginConfig.InGameCountDown = value;
        }

        [UIValue("join")]
        public bool Join {
            get => pluginConfig.AllowMultiplayerJoin;
            set => pluginConfig.AllowMultiplayerJoin = value;
        }
    }
}