using CborSerialization;

namespace Argus.Sync.Data.Models.Datums;

[CborSerialize(typeof(CardanoIntCborConvert<Lovelace>))]
public record Lovelace(ulong Value) : CardanoInt(Value);