using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RekdFileCompiler.File
{
	public class FileConverter
	{
		public static byte[] Serialize(BaseFormat value)
		{
			List<byte> bytes = new List<byte>();
			bytes.Add(1);
			bytes.Add(3);
			bytes.Add(3);
			bytes.Add(7);

			Type type = value.GetType();
			type.GetProperties().ToList().ForEach(property =>
			{
				Type propType = property.PropertyType;
				if (propType.IsEnum)
				{
					property.GetValue(value);
				}
				else if (propType == typeof(Int16))
				{
				}
				else if (propType == typeof(Int32))
				{
				}
				else if (propType == typeof(Int64))
				{
				}
				else if (propType == typeof(Single))
				{
				}
				else if (propType == typeof(Double))
				{
				}
				else if (Type.GetTypeCode(propType) == TypeCode.String)
				{
				}
			});

			return bytes.ToArray();
		}

		private static IEnumerable toByteArray(string str)
		{
			return Encoding.UTF8.GetBytes(str);
		}

		public static bool IsNumericType(Type type)
		{
			if (type == null)
			{
				return false;
			}

			switch (Type.GetTypeCode(type))
			{
				case TypeCode.Byte:
				case TypeCode.Decimal:
				case TypeCode.Double:
				case TypeCode.Int16:
				case TypeCode.Int32:
				case TypeCode.Int64:
				case TypeCode.SByte:
				case TypeCode.Single:
				case TypeCode.UInt16:
				case TypeCode.UInt32:
				case TypeCode.UInt64:
					return true;

				case TypeCode.Object:
					if (type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>))
					{
						return IsNumericType(Nullable.GetUnderlyingType(type));
					}
					return false;
			}
			return false;
		}
	}
}