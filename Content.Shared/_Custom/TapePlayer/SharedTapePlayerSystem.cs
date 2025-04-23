using Robust.Shared.Audio.Systems;

namespace Content.Shared._Custom.TapePlayer;

public abstract class SharedTapePlayerSystem : EntitySystem
{
    [Dependency] protected readonly SharedAudioSystem Audio = default!;
}
