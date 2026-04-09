using System;
using System.Collections.Generic;

namespace racman
{
    public class LBP2Addresses : IAddresses
    {
        // BCES00850 (PAL Multi-Language Disc) v1.00

        public uint loadvalue1 = 0xC8DDB8;
        public uint loadvalue2 = 0xCF8E6C;
        public uint loadvalue3 = 0xD08408;

        public uint boltCount => throw new NotImplementedException();

        public uint playerCoords => throw new NotImplementedException();

        public uint inputOffset => throw new NotImplementedException();

        public uint analogOffset => throw new NotImplementedException();

        public uint loadPlanet => throw new NotImplementedException();

        public uint currentPlanet => throw new NotImplementedException();

        public uint mobyInstances => throw new NotImplementedException();
    }

    public class lbp2 : IGame, IAutosplitterAvailable
    {
        public lbp2(IPS3API api) : base(api)
        {
        }

        public static LBP2Addresses addr = new LBP2Addresses();

        public IEnumerable<(uint addr, uint size)> AutosplitterAddresses => new (uint, uint)[]
        {
            (addr.loadvalue1, 4),
            (addr.loadvalue2, 4),
            (addr.loadvalue3, 4),
        };

        public override void CheckInputs(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        public override void ResetLevelFlags()
        {
            throw new NotImplementedException();
        }

        public override void SetFastLoads(bool enabled = false)
        {
            throw new NotImplementedException();
        }

        public override void SetupFile()
        {
            throw new NotImplementedException();
        }

        public override void ToggleInfiniteAmmo(bool toggle = false)
        {
            throw new NotImplementedException();
        }
    }
}
