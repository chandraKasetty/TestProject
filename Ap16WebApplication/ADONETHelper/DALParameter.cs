using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace ADONETHelper
{

    public class DalParameter
    {
        string _parameterName;
        ParameterDirection _parameterDirection;
        DbType _parameterType;
        object _parameterValue;
        int _parameterSize;

        public DalParameter(string parameterName, ParameterDirection parameterDirection, object parameterValue, int paramSize=-1)
        {
            _parameterName = parameterName;
            _parameterDirection = parameterDirection;
            _parameterValue = parameterValue;
            _parameterType = GetDbTypeFromType()[parameterValue.GetType()];
            _parameterSize = paramSize;

        }

        private Dictionary<Type, DbType> GetDbTypeFromType()
        {
            var typeMap = new Dictionary<Type, DbType>
            {
                [typeof(byte)] = DbType.Byte,
                [typeof(sbyte)] = DbType.SByte,
                [typeof(short)] = DbType.Int16,
                [typeof(ushort)] = DbType.UInt16,
                [typeof(int)] = DbType.Int32,
                [typeof(uint)] = DbType.UInt32,
                [typeof(long)] = DbType.Int64,
                [typeof(ulong)] = DbType.UInt64,
                [typeof(float)] = DbType.Single,
                [typeof(double)] = DbType.Double,
                [typeof(decimal)] = DbType.Decimal,
                [typeof(bool)] = DbType.Boolean,
                [typeof(string)] = DbType.String,
                [typeof(char)] = DbType.StringFixedLength,
                [typeof(Guid)] = DbType.Guid,
                [typeof(DateTime)] = DbType.DateTime,
                [typeof(DateTimeOffset)] = DbType.DateTimeOffset,
                [typeof(byte[])] = DbType.Binary,
                [typeof(byte?)] = DbType.Byte,
                [typeof(sbyte?)] = DbType.SByte,
                [typeof(short?)] = DbType.Int16,
                [typeof(ushort?)] = DbType.UInt16,
                [typeof(int?)] = DbType.Int32,
                [typeof(uint?)] = DbType.UInt32,
                [typeof(long?)] = DbType.Int64,
                [typeof(ulong?)] = DbType.UInt64,
                [typeof(float?)] = DbType.Single,
                [typeof(double?)] = DbType.Double,
                [typeof(decimal?)] = DbType.Decimal,
                [typeof(bool?)] = DbType.Boolean,
                [typeof(char?)] = DbType.StringFixedLength,
                [typeof(Guid?)] = DbType.Guid,
                [typeof(DateTime?)] = DbType.DateTime,
                [typeof(DateTimeOffset?)] = DbType.DateTimeOffset
            };
            return typeMap;
        }

        public DbParameter CreateDbParamater(DbParameter parameter)
        {
            parameter.DbType = _parameterType;
            parameter.ParameterName = _parameterName;
            parameter.Value = _parameterValue;
            parameter.Direction = _parameterDirection;
            if (_parameterSize != -1)
            {
                parameter.Size = _parameterSize;
            }
            return parameter;
        }

    }
}
