using System;
using System.Collections.Generic;

namespace racman
{
    public class LBP1Addresses : IAddresses
    {
        // BCUS98208 (NTSC Game of the Year Edition) v1.21

        public uint loadvalue1 = 0xA07010;
        public uint loadvalue2 = 0xA07004;

        public uint boltCount => throw new NotImplementedException();

        public uint playerCoords => throw new NotImplementedException();

        public uint inputOffset => throw new NotImplementedException();

        public uint analogOffset => throw new NotImplementedException();

        public uint loadPlanet => throw new NotImplementedException();

        public uint currentPlanet => throw new NotImplementedException();

        public uint mobyInstances => throw new NotImplementedException();
    }

    public class lbp1 : IGame, IAutosplitterAvailable
    {
        public lbp1(IPS3API api) : base(api)
        {
        }

        public static LBP1Addresses addr = new LBP1Addresses();

        public IEnumerable<(uint addr, uint size)> AutosplitterAddresses => new (uint, uint)[]
        {
            (addr.loadvalue1, 4),
            (addr.loadvalue2, 4),
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
