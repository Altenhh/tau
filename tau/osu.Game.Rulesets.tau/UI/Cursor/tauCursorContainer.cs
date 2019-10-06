﻿// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

using osu.Framework.Graphics;
using osu.Framework.Input.Events;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.tau.UI.Cursor
{
    public class TauCursorContainer : GameplayCursorContainer
    {
        protected override Drawable CreateCursor() => new TauCursor();

        protected override bool OnMouseMove(MouseMoveEvent e)
        {
            // Overrides mouse movement handling
            return false;
        }
    }
}