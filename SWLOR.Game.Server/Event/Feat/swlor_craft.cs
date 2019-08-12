﻿using SWLOR.Game.Server;
using SWLOR.Game.Server.Event.Feat;
using SWLOR.Game.Server.Messaging;

// ReSharper disable once CheckNamespace
namespace NWN.Scripts
{
#pragma warning disable IDE1006 // Naming Styles
    internal class swlor_craft
#pragma warning restore IDE1006 // Naming Styles
    {
        // ReSharper disable once UnusedMember.Local
        private static void Main()
        {
            MessageHub.Instance.Publish(new OnUseCraftingFeat());
        }
    }
}