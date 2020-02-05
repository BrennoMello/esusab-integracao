/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;

namespace br.gov.saude.esusab.ras.atividadecoletiva
{

  #if !SILVERLIGHT
  [Serializable]
  #endif
  public partial class ParticipanteRowItemThrift : TBase
  {
    private string _cnsParticipante;
    private long _dataNascimento;
    private bool _avaliacaoAlterada;
    private double _peso;
    private double _altura;
    private bool _cessouHabitoFumar;
    private bool _abandonouGrupo;
    private long _sexo;
    private string _cpfParticipante;

    public string CnsParticipante
    {
      get
      {
        return _cnsParticipante;
      }
      set
      {
        __isset.cnsParticipante = true;
        this._cnsParticipante = value;
      }
    }

    public long DataNascimento
    {
      get
      {
        return _dataNascimento;
      }
      set
      {
        __isset.dataNascimento = true;
        this._dataNascimento = value;
      }
    }

    public bool AvaliacaoAlterada
    {
      get
      {
        return _avaliacaoAlterada;
      }
      set
      {
        __isset.avaliacaoAlterada = true;
        this._avaliacaoAlterada = value;
      }
    }

    public double Peso
    {
      get
      {
        return _peso;
      }
      set
      {
        __isset.peso = true;
        this._peso = value;
      }
    }

    public double Altura
    {
      get
      {
        return _altura;
      }
      set
      {
        __isset.altura = true;
        this._altura = value;
      }
    }

    public bool CessouHabitoFumar
    {
      get
      {
        return _cessouHabitoFumar;
      }
      set
      {
        __isset.cessouHabitoFumar = true;
        this._cessouHabitoFumar = value;
      }
    }

    public bool AbandonouGrupo
    {
      get
      {
        return _abandonouGrupo;
      }
      set
      {
        __isset.abandonouGrupo = true;
        this._abandonouGrupo = value;
      }
    }

    public long Sexo
    {
      get
      {
        return _sexo;
      }
      set
      {
        __isset.sexo = true;
        this._sexo = value;
      }
    }

    public string CpfParticipante
    {
      get
      {
        return _cpfParticipante;
      }
      set
      {
        __isset.cpfParticipante = true;
        this._cpfParticipante = value;
      }
    }


    public Isset __isset;
    #if !SILVERLIGHT
    [Serializable]
    #endif
    public struct Isset {
      public bool cnsParticipante;
      public bool dataNascimento;
      public bool avaliacaoAlterada;
      public bool peso;
      public bool altura;
      public bool cessouHabitoFumar;
      public bool abandonouGrupo;
      public bool sexo;
      public bool cpfParticipante;
    }

    public ParticipanteRowItemThrift() {
    }

    public void Read (TProtocol iprot)
    {
      iprot.IncrementRecursionDepth();
      try
      {
        TField field;
        iprot.ReadStructBegin();
        while (true)
        {
          field = iprot.ReadFieldBegin();
          if (field.Type == TType.Stop) { 
            break;
          }
          switch (field.ID)
          {
            case 1:
              if (field.Type == TType.String) {
                CnsParticipante = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 2:
              if (field.Type == TType.I64) {
                DataNascimento = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 3:
              if (field.Type == TType.Bool) {
                AvaliacaoAlterada = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 4:
              if (field.Type == TType.Double) {
                Peso = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 5:
              if (field.Type == TType.Double) {
                Altura = iprot.ReadDouble();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 6:
              if (field.Type == TType.Bool) {
                CessouHabitoFumar = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 7:
              if (field.Type == TType.Bool) {
                AbandonouGrupo = iprot.ReadBool();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 8:
              if (field.Type == TType.I64) {
                Sexo = iprot.ReadI64();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            case 9:
              if (field.Type == TType.String) {
                CpfParticipante = iprot.ReadString();
              } else { 
                TProtocolUtil.Skip(iprot, field.Type);
              }
              break;
            default: 
              TProtocolUtil.Skip(iprot, field.Type);
              break;
          }
          iprot.ReadFieldEnd();
        }
        iprot.ReadStructEnd();
      }
      finally
      {
        iprot.DecrementRecursionDepth();
      }
    }

    public void Write(TProtocol oprot) {
      oprot.IncrementRecursionDepth();
      try
      {
        TStruct struc = new TStruct("ParticipanteRowItemThrift");
        oprot.WriteStructBegin(struc);
        TField field = new TField();
        if (CnsParticipante != null && __isset.cnsParticipante) {
          field.Name = "cnsParticipante";
          field.Type = TType.String;
          field.ID = 1;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CnsParticipante);
          oprot.WriteFieldEnd();
        }
        if (__isset.dataNascimento) {
          field.Name = "dataNascimento";
          field.Type = TType.I64;
          field.ID = 2;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(DataNascimento);
          oprot.WriteFieldEnd();
        }
        if (__isset.avaliacaoAlterada) {
          field.Name = "avaliacaoAlterada";
          field.Type = TType.Bool;
          field.ID = 3;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(AvaliacaoAlterada);
          oprot.WriteFieldEnd();
        }
        if (__isset.peso) {
          field.Name = "peso";
          field.Type = TType.Double;
          field.ID = 4;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(Peso);
          oprot.WriteFieldEnd();
        }
        if (__isset.altura) {
          field.Name = "altura";
          field.Type = TType.Double;
          field.ID = 5;
          oprot.WriteFieldBegin(field);
          oprot.WriteDouble(Altura);
          oprot.WriteFieldEnd();
        }
        if (__isset.cessouHabitoFumar) {
          field.Name = "cessouHabitoFumar";
          field.Type = TType.Bool;
          field.ID = 6;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(CessouHabitoFumar);
          oprot.WriteFieldEnd();
        }
        if (__isset.abandonouGrupo) {
          field.Name = "abandonouGrupo";
          field.Type = TType.Bool;
          field.ID = 7;
          oprot.WriteFieldBegin(field);
          oprot.WriteBool(AbandonouGrupo);
          oprot.WriteFieldEnd();
        }
        if (__isset.sexo) {
          field.Name = "sexo";
          field.Type = TType.I64;
          field.ID = 8;
          oprot.WriteFieldBegin(field);
          oprot.WriteI64(Sexo);
          oprot.WriteFieldEnd();
        }
        if (CpfParticipante != null && __isset.cpfParticipante) {
          field.Name = "cpfParticipante";
          field.Type = TType.String;
          field.ID = 9;
          oprot.WriteFieldBegin(field);
          oprot.WriteString(CpfParticipante);
          oprot.WriteFieldEnd();
        }
        oprot.WriteFieldStop();
        oprot.WriteStructEnd();
      }
      finally
      {
        oprot.DecrementRecursionDepth();
      }
    }

    public override string ToString() {
      StringBuilder __sb = new StringBuilder("ParticipanteRowItemThrift(");
      bool __first = true;
      if (CnsParticipante != null && __isset.cnsParticipante) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CnsParticipante: ");
        __sb.Append(CnsParticipante);
      }
      if (__isset.dataNascimento) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("DataNascimento: ");
        __sb.Append(DataNascimento);
      }
      if (__isset.avaliacaoAlterada) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AvaliacaoAlterada: ");
        __sb.Append(AvaliacaoAlterada);
      }
      if (__isset.peso) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Peso: ");
        __sb.Append(Peso);
      }
      if (__isset.altura) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Altura: ");
        __sb.Append(Altura);
      }
      if (__isset.cessouHabitoFumar) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CessouHabitoFumar: ");
        __sb.Append(CessouHabitoFumar);
      }
      if (__isset.abandonouGrupo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("AbandonouGrupo: ");
        __sb.Append(AbandonouGrupo);
      }
      if (__isset.sexo) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("Sexo: ");
        __sb.Append(Sexo);
      }
      if (CpfParticipante != null && __isset.cpfParticipante) {
        if(!__first) { __sb.Append(", "); }
        __first = false;
        __sb.Append("CpfParticipante: ");
        __sb.Append(CpfParticipante);
      }
      __sb.Append(")");
      return __sb.ToString();
    }

  }

}
