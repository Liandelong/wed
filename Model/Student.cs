using System;
namespace ITCastOCSS.Model
{
	/// <summary>
	/// Student:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Student
	{
		public Student()
		{}
		#region Model
		private int _sid;
		private string _sno;
		private string _sname;
		private string _spwd;
		private string _ssex;
		private string _sclass;
		private string _stype;
		private string _sdepartment;
		private string _smajor;
		private int? _smaxnum;
		private int? _sactualnum;
		private DateTime? _sbirthday;
		private DateTime? _sintime;
		private string _sgrade;
		private string _snote;
		/// <summary>
		/// 
		/// </summary>
		public int SID
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SNo
		{
			set{ _sno=value;}
			get{return _sno;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SName
		{
			set{ _sname=value;}
			get{return _sname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SPwd
		{
			set{ _spwd=value;}
			get{return _spwd;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SSex
		{
			set{ _ssex=value;}
			get{return _ssex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SClass
		{
			set{ _sclass=value;}
			get{return _sclass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SType
		{
			set{ _stype=value;}
			get{return _stype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SDepartment
		{
			set{ _sdepartment=value;}
			get{return _sdepartment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SMajor
		{
			set{ _smajor=value;}
			get{return _smajor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SMaxNum
		{
			set{ _smaxnum=value;}
			get{return _smaxnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SActualNum
		{
			set{ _sactualnum=value;}
			get{return _sactualnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SBirthday
		{
			set{ _sbirthday=value;}
			get{return _sbirthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? SInTime
		{
			set{ _sintime=value;}
			get{return _sintime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SGrade
		{
			set{ _sgrade=value;}
			get{return _sgrade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SNote
		{
			set{ _snote=value;}
			get{return _snote;}
		}
		#endregion Model

	}
}

