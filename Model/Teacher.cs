using System;
namespace ITCastOCSS.Model
{
	/// <summary>
	/// Teacher:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Teacher : IConvertible
    {
		public Teacher()
		{}
		#region Model
		private int _tid;
		private string _tno;
		private string _tname;
		private string _tsex;
		private string _tmajor;
		private string _tpwd;
		private string _tdepartment;
		private string _ttitle;
		private int? _tisadmin=0;
		/// <summary>
		/// 
		/// </summary>
		public int TID
		{
			set{ _tid=value;}
			get{return _tid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TNo
		{
			set{ _tno=value;}
			get{return _tno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TName
		{
			set{ _tname=value;}
			get{return _tname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TSex
		{
			set{ _tsex=value;}
			get{return _tsex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TMajor
		{
			set{ _tmajor=value;}
			get{return _tmajor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TPwd
		{
			set{ _tpwd=value;}
			get{return _tpwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TDepartment
		{
			set{ _tdepartment=value;}
			get{return _tdepartment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string TTitle
		{
			set{ _ttitle=value;}
			get{return _ttitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TIsAdmin
		{
			set{ _tisadmin=value;}
			get{return _tisadmin;}
		}

        public TypeCode GetTypeCode()
        {
            throw new NotImplementedException();
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public int ToInt32(IFormatProvider provider)
        {
            return this.TID;
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public string ToString(IFormatProvider provider)
        {
            throw new NotImplementedException();
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new NotImplementedException();
        }
        #endregion Model

    }
}

