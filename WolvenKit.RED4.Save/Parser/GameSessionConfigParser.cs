using WolvenKit.Core.Extensions;
using WolvenKit.RED4.Save.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Save;

public class GameSessionConfig : IParseableBuffer
{
    public ulong Hash1 { get; set; }
    public ulong Hash2 { get; set; }
    public string TextValue { get; set; }
    public ulong Hash3 { get; set; }
    public byte[] TrailingBytes { get; set; }

}

public class GameSessionConfigParser : INodeParser
{
    public static string NodeName => Constants.NodeNames.GAME_SESSION_CONFIG_NODE;

    public void Read(BinaryReader reader, NodeEntry node)
    {
        node.Value = new GameSessionConfig
            {
                Hash1 = reader.ReadUInt64(),
                Hash2 = reader.ReadUInt64(),
                TextValue = reader.ReadLengthPrefixedString(),
                Hash3 = reader.ReadUInt64(),
                TrailingBytes = reader.ReadBytes(node.TrailingSize)
            };
    }

    public void Write(NodeWriter writer, NodeEntry node)
    {
        var value = (GameSessionConfig)node.Value;

        writer.Write(value.Hash1);
        writer.Write(value.Hash2);
        writer.WriteLengthPrefixedString(value.TextValue);
        writer.Write(value.Hash3);
        writer.Write(value.TrailingBytes);
    }
}
