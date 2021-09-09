using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyBitOperationHelper
{
    class BitOperation
    {
        public static void GetBitStatus(Char Value, int BitPosition, out bool BitStatus)
        {
            Char result = Convert.ToChar(((Char)Value >> BitPosition) & 1);

            if (result == (Char)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(Byte Value, int BitPosition, out bool BitStatus)
        {
            Byte result = Convert.ToByte(((Byte)Value >> BitPosition) & 1);

            if (result == (Byte)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(Int16 Value, int BitPosition, out bool BitStatus)
        {
            Int16 result = Convert.ToInt16(((Int16)Value >> BitPosition) & 1);

            if (result == (Int16)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(Int32 Value, int BitPosition, out bool BitStatus)
        {
            Int32 result = Convert.ToInt32(((Int32)Value >> BitPosition) & 1);

            if (result == (Int32)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(Int64 Value, int BitPosition, out bool BitStatus)
        {
            Int64 result = Convert.ToInt64(((Int64)Value >> BitPosition) & 1);

            if (result == (Int64)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(UInt16 Value, int BitPosition, out bool BitStatus)
        {
            UInt16 result = Convert.ToUInt16(((UInt16)Value >> BitPosition) & 1);

            if (result == (UInt16)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(UInt32 Value, int BitPosition, out bool BitStatus)
        {
            UInt32 result = Convert.ToUInt32(((UInt32)Value >> BitPosition) & 1);

            if (result == (UInt32)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void GetBitStatus(UInt64 Value, int BitPosition, out bool BitStatus)
        {
            UInt64 result = Convert.ToUInt64(((UInt64)Value >> BitPosition) & 1);

            if (result == (UInt64)1)
                BitStatus = true;
            else
                BitStatus = false;

        }

        public static void SetBitStatus(ref Char Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToChar((Char)Value | ((Char)1 << BitPosition));
            else
                Value = Convert.ToChar((Char)Value & (~((Char)1 << BitPosition)));
        }

        public static void SetBitStatus(ref Byte Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToByte((Byte)Value | ((Byte)1 << BitPosition));
            else
                Value = Convert.ToByte((Byte)Value & (~((Byte)1 << BitPosition)));
        }

        public static void SetBitStatus(ref Int16 Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToInt16((UInt16)Value | ((UInt16)1 << BitPosition));
            else
                Value = Convert.ToInt16((UInt16)Value & (~((UInt16)1 << BitPosition)));

        }

        public static void SetBitStatus(ref Int32 Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToInt32((Int32)Value | ((Int32)1 << BitPosition));
            else
                Value = Convert.ToInt32((Int32)Value & (~((Int32)1 << BitPosition)));
        }

        public static void SetBitStatus(ref Int64 Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToInt64((Int64)Value | ((Int64)1 << BitPosition));
            else
                Value = Convert.ToInt64((Int64)Value & (~((Int64)1 << BitPosition)));
        }

        public static void SetBitStatus(ref UInt16 Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToUInt16((UInt16)Value | ((UInt16)1 << BitPosition));
            else
                Value = Convert.ToUInt16((UInt16)Value & (~((UInt16)1 << BitPosition)));
        }

        public static void SetBitStatus(ref UInt32 Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToUInt32((UInt32)Value | ((UInt32)1 << BitPosition));
            else
                Value = Convert.ToUInt32((UInt32)Value & (~((UInt32)1 << BitPosition)));
        }

        public static void SetBitStatus(ref UInt64 Value, int BitPosition, bool BitStatus)
        {
            if (BitStatus)
                Value = Convert.ToUInt64((UInt64)Value | ((UInt64)1 << BitPosition));
            else
                Value = Convert.ToUInt64((UInt64)Value & (~((UInt64)1 << BitPosition)));
        }

        



    }

}
