﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UCP.AICharacters
{
    /// <summary>
    /// Crusader-intern military unit IDs
    /// </summary>
    public enum Unit
    {
        None = 0x00,
        Tunneler = 0x05,
        EuropArcher = 0x16,
        Crossbowman = 0x17,
        Spearman = 0x18,
        Pikeman = 0x19,
        Maceman = 0x1A,
        Swordsman = 0x1B,
        Knight = 0x1C,
        Ladderman = 0x1D,
        Engineer = 0x1E,
        Monk = 0x25,
        ArabArcher = 0x46,
        Slave = 0x47,
        Slinger = 0x48,
        Assassin = 0x49,
        HorseArcher = 0x4A,
        ArabSwordsman = 0x4B,
        FireThrower = 0x4C
    }

    public enum DiggingUnit
    {
        None = 0x00,
        EuropArcher = 0x16,
        Spearman = 0x18,
        Pikeman = 0x19,
        Maceman = 0x1A,
        Engineer = 0x1E,
        Slave = 0x47
    }

    public enum MeleeUnit
    {
        None = 0x00,
        Tunneler = 0x05,
        Spearman = 0x18,
        Pikeman = 0x19,
        Maceman = 0x1A,
        Swordsman = 0x1B,
        Knight = 0x1C,
        //Ladderman = 0x1D,
        //Engineer = 0x1E,
        Monk = 0x25,
        Slave = 0x47,
        Assassin = 0x49,
        ArabSwordsman = 0x4B
    }

    public enum RangedUnit
    {
        None = 0x00,
        EuropArcher = 0x16,
        Crossbowman = 0x17,
        ArabArcher = 0x46,
        Slinger = 0x48,
        HorseArcher = 0x4A,
        FireThrower = 0x4C
    }
}
