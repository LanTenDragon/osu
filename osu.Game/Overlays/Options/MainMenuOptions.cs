﻿using System;
using osu.Framework.Graphics.UserInterface;

namespace osu.Game.Overlays.Options
{
    public class MainMenuOptions : OptionsSubsection
    {
        public MainMenuOptions()
        {
            Header = "Main Menu";
            Children = new[]
            {
                new BasicCheckBox { LabelText = "Snow" },
                new BasicCheckBox { LabelText = "Parallax" },
                new BasicCheckBox { LabelText = "Menu tips" },
                new BasicCheckBox { LabelText = "Interface voices" },
                new BasicCheckBox { LabelText = "osu! music theme" },
            };
        }
    }
}