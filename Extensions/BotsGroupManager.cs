using System.Collections.Generic;

namespace SeparateHostility.Extensions;

internal class BotsGroupManager : GClass575
{
    internal readonly Dictionary<BotSpawnParams, BotsGroup> _spawnGroups = [];
}