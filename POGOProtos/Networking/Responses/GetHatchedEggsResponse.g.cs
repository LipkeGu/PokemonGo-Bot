// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Networking/Responses/GetHatchedEggsResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Networking.Responses {

  /// <summary>Holder for reflection information generated from POGOProtos/Networking/Responses/GetHatchedEggsResponse.proto</summary>
  public static partial class GetHatchedEggsResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Networking/Responses/GetHatchedEggsResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GetHatchedEggsResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxQT0dPUHJvdG9zL05ldHdvcmtpbmcvUmVzcG9uc2VzL0dldEhhdGNoZWRF",
            "Z2dzUmVzcG9uc2UucHJvdG8SH1BPR09Qcm90b3MuTmV0d29ya2luZy5SZXNw",
            "b25zZXMaIVBPR09Qcm90b3MvRGF0YS9Qb2tlbW9uRGF0YS5wcm90byLcAQoW",
            "R2V0SGF0Y2hlZEVnZ3NSZXNwb25zZRIPCgdzdWNjZXNzGAEgASgIEhYKCnBv",
            "a2Vtb25faWQYAiADKAZCAhABEhoKEmV4cGVyaWVuY2VfYXdhcmRlZBgDIAMo",
            "BRIVCg1jYW5keV9hd2FyZGVkGAQgAygFEhgKEHN0YXJkdXN0X2F3YXJkZWQY",
            "BSADKAUSFQoNZWdnX2ttX3dhbGtlZBgGIAMoAhI1Cg9oYXRjaGVkX3Bva2Vt",
            "b24YByADKAsyHC5QT0dPUHJvdG9zLkRhdGEuUG9rZW1vbkRhdGFiBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Data.PokemonDataReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Networking.Responses.GetHatchedEggsResponse), global::POGOProtos.Networking.Responses.GetHatchedEggsResponse.Parser, new[]{ "Success", "PokemonId", "ExperienceAwarded", "CandyAwarded", "StardustAwarded", "EggKmWalked", "HatchedPokemon" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class GetHatchedEggsResponse : pb::IMessage<GetHatchedEggsResponse> {
    private static readonly pb::MessageParser<GetHatchedEggsResponse> _parser = new pb::MessageParser<GetHatchedEggsResponse>(() => new GetHatchedEggsResponse());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetHatchedEggsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Networking.Responses.GetHatchedEggsResponseReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHatchedEggsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHatchedEggsResponse(GetHatchedEggsResponse other) : this() {
      success_ = other.success_;
      pokemonId_ = other.pokemonId_.Clone();
      experienceAwarded_ = other.experienceAwarded_.Clone();
      candyAwarded_ = other.candyAwarded_.Clone();
      stardustAwarded_ = other.stardustAwarded_.Clone();
      eggKmWalked_ = other.eggKmWalked_.Clone();
      hatchedPokemon_ = other.hatchedPokemon_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetHatchedEggsResponse Clone() {
      return new GetHatchedEggsResponse(this);
    }

    /// <summary>Field number for the "success" field.</summary>
    public const int SuccessFieldNumber = 1;
    private bool success_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Success {
      get { return success_; }
      set {
        success_ = value;
      }
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 2;
    private static readonly pb::FieldCodec<ulong> _repeated_pokemonId_codec
        = pb::FieldCodec.ForFixed64(18);
    private readonly pbc::RepeatedField<ulong> pokemonId_ = new pbc::RepeatedField<ulong>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<ulong> PokemonId {
      get { return pokemonId_; }
    }

    /// <summary>Field number for the "experience_awarded" field.</summary>
    public const int ExperienceAwardedFieldNumber = 3;
    private static readonly pb::FieldCodec<int> _repeated_experienceAwarded_codec
        = pb::FieldCodec.ForInt32(26);
    private readonly pbc::RepeatedField<int> experienceAwarded_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> ExperienceAwarded {
      get { return experienceAwarded_; }
    }

    /// <summary>Field number for the "candy_awarded" field.</summary>
    public const int CandyAwardedFieldNumber = 4;
    private static readonly pb::FieldCodec<int> _repeated_candyAwarded_codec
        = pb::FieldCodec.ForInt32(34);
    private readonly pbc::RepeatedField<int> candyAwarded_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> CandyAwarded {
      get { return candyAwarded_; }
    }

    /// <summary>Field number for the "stardust_awarded" field.</summary>
    public const int StardustAwardedFieldNumber = 5;
    private static readonly pb::FieldCodec<int> _repeated_stardustAwarded_codec
        = pb::FieldCodec.ForInt32(42);
    private readonly pbc::RepeatedField<int> stardustAwarded_ = new pbc::RepeatedField<int>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<int> StardustAwarded {
      get { return stardustAwarded_; }
    }

    /// <summary>Field number for the "egg_km_walked" field.</summary>
    public const int EggKmWalkedFieldNumber = 6;
    private static readonly pb::FieldCodec<float> _repeated_eggKmWalked_codec
        = pb::FieldCodec.ForFloat(50);
    private readonly pbc::RepeatedField<float> eggKmWalked_ = new pbc::RepeatedField<float>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<float> EggKmWalked {
      get { return eggKmWalked_; }
    }

    /// <summary>Field number for the "hatched_pokemon" field.</summary>
    public const int HatchedPokemonFieldNumber = 7;
    private static readonly pb::FieldCodec<global::POGOProtos.Data.PokemonData> _repeated_hatchedPokemon_codec
        = pb::FieldCodec.ForMessage(58, global::POGOProtos.Data.PokemonData.Parser);
    private readonly pbc::RepeatedField<global::POGOProtos.Data.PokemonData> hatchedPokemon_ = new pbc::RepeatedField<global::POGOProtos.Data.PokemonData>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Data.PokemonData> HatchedPokemon {
      get { return hatchedPokemon_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetHatchedEggsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetHatchedEggsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Success != other.Success) return false;
      if(!pokemonId_.Equals(other.pokemonId_)) return false;
      if(!experienceAwarded_.Equals(other.experienceAwarded_)) return false;
      if(!candyAwarded_.Equals(other.candyAwarded_)) return false;
      if(!stardustAwarded_.Equals(other.stardustAwarded_)) return false;
      if(!eggKmWalked_.Equals(other.eggKmWalked_)) return false;
      if(!hatchedPokemon_.Equals(other.hatchedPokemon_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Success != false) hash ^= Success.GetHashCode();
      hash ^= pokemonId_.GetHashCode();
      hash ^= experienceAwarded_.GetHashCode();
      hash ^= candyAwarded_.GetHashCode();
      hash ^= stardustAwarded_.GetHashCode();
      hash ^= eggKmWalked_.GetHashCode();
      hash ^= hatchedPokemon_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Success != false) {
        output.WriteRawTag(8);
        output.WriteBool(Success);
      }
      pokemonId_.WriteTo(output, _repeated_pokemonId_codec);
      experienceAwarded_.WriteTo(output, _repeated_experienceAwarded_codec);
      candyAwarded_.WriteTo(output, _repeated_candyAwarded_codec);
      stardustAwarded_.WriteTo(output, _repeated_stardustAwarded_codec);
      eggKmWalked_.WriteTo(output, _repeated_eggKmWalked_codec);
      hatchedPokemon_.WriteTo(output, _repeated_hatchedPokemon_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Success != false) {
        size += 1 + 1;
      }
      size += pokemonId_.CalculateSize(_repeated_pokemonId_codec);
      size += experienceAwarded_.CalculateSize(_repeated_experienceAwarded_codec);
      size += candyAwarded_.CalculateSize(_repeated_candyAwarded_codec);
      size += stardustAwarded_.CalculateSize(_repeated_stardustAwarded_codec);
      size += eggKmWalked_.CalculateSize(_repeated_eggKmWalked_codec);
      size += hatchedPokemon_.CalculateSize(_repeated_hatchedPokemon_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetHatchedEggsResponse other) {
      if (other == null) {
        return;
      }
      if (other.Success != false) {
        Success = other.Success;
      }
      pokemonId_.Add(other.pokemonId_);
      experienceAwarded_.Add(other.experienceAwarded_);
      candyAwarded_.Add(other.candyAwarded_);
      stardustAwarded_.Add(other.stardustAwarded_);
      eggKmWalked_.Add(other.eggKmWalked_);
      hatchedPokemon_.Add(other.hatchedPokemon_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            Success = input.ReadBool();
            break;
          }
          case 18:
          case 17: {
            pokemonId_.AddEntriesFrom(input, _repeated_pokemonId_codec);
            break;
          }
          case 26:
          case 24: {
            experienceAwarded_.AddEntriesFrom(input, _repeated_experienceAwarded_codec);
            break;
          }
          case 34:
          case 32: {
            candyAwarded_.AddEntriesFrom(input, _repeated_candyAwarded_codec);
            break;
          }
          case 42:
          case 40: {
            stardustAwarded_.AddEntriesFrom(input, _repeated_stardustAwarded_codec);
            break;
          }
          case 50:
          case 53: {
            eggKmWalked_.AddEntriesFrom(input, _repeated_eggKmWalked_codec);
            break;
          }
          case 58: {
            hatchedPokemon_.AddEntriesFrom(input, _repeated_hatchedPokemon_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code