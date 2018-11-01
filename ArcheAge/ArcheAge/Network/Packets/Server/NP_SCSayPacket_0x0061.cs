using ArcheAge.ArcheAge.Network.Connections;
using LocalCommons.Network;
using System;

namespace ArcheAge.ArcheAge.Network
{
    public sealed class NP_SCSayPacket_0x0061 : NetPacket
    {
        public NP_SCSayPacket_0x0061(ClientConnection net, string name) : base(05, 0xcfb4)
        {
            /*
            2d00dd055ed5c000d2a2724212e3b3832963f4c6fd66340fdd30754516e2b6c7244395c697414010e0b09176c1f020

            2d00dd05CFB4F10100000000000000007A4000026902000A0895000000      0400    41736462    0100    31 00000000     1027    000000

                                                                             4       Asdb        1       1              1000    0

                                                                dword 游戏昵称    长度 内容
                                                                */
            ns.WriteHex("F10100000000000000007A4000026902000A0895000000040041736462010031000000001027000000");
        }
    }
}
 