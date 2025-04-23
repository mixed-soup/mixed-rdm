﻿using Robust.Shared.Audio;
using Robust.Shared.GameStates;

namespace Content.Shared._Custom.TapePlayer
{
    [RegisterComponent, NetworkedComponent]
    public sealed partial class MusicTapeComponent : Component
    {
        [DataField(customTypeSerializer: typeof(SoundSpecifierTypeSerializer), required: true)]
        public SoundSpecifier Sound;

        [DataField]
        public string SongName = "";
    }
}
