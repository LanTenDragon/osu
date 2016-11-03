﻿using System;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.UserInterface;

namespace osu.Game.Overlays.Options
{
    public class LayoutOptions : OptionsSubsection
    {
        public LayoutOptions()
        {
            Header = "Layout";
            Children = new Drawable[]
            {
                new SpriteText { Text = "Resolution: TODO dropdown" },
                new BasicCheckBox { LabelText = "Fullscreen mode" },
                new BasicCheckBox { LabelText = "Letterboxing" },
                new SpriteText { Text = "Horizontal position" },
                new SpriteText { Text = "TODO: slider" },
                new SpriteText { Text = "Vertical position" },
                new SpriteText { Text = "TODO: slider" },
            };
        }
    }
}