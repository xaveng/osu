﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using OpenTK.Input;
using osu.Game.Modes.Taiko.Objects.Drawable.Pieces;
using osu.Framework.Allocation;
using osu.Game.Graphics;

namespace osu.Game.Modes.Taiko.Objects.Drawable
{
    public class DrawableStrongCentreHit : DrawableStrongHit
    {
        protected override Key[] HitKeys { get; } = { Key.F, Key.J };

        private readonly CirclePiece circlePiece;

        public DrawableStrongCentreHit(Hit hit)
            : base(hit)
        {
            Add(circlePiece = new StrongCirclePiece
            {
                Children = new []
                {
                    new CentreHitSymbolPiece()
                }
            });
        }

        [BackgroundDependencyLoader]
        private void load(OsuColour colours)
        {
            circlePiece.AccentColour = colours.PinkDarker;
        }
    }
}
