using System;
namespace ITCastOCSS.Model
{
	/// <summary>
	/// Course:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Course
	{
		public Course()
		{}
		#region Model
		private int _cid;
		private string _description;
		private string _grade;
		private string _term;
		private int? _credit;
		private string _cname;
		/// <summary>
		/// 
		/// </summary>
		public int CID
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Grade
		{
			set{ _grade=value;}
			get{return _grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Term
		{
			set{ _term=value;}
			get{return _term;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Credit
		{
			set{ _credit=value;}
			get{return _credit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CName
		{
			set{ _cname=value;}
			get{return _cname;}
		}
		#endregion Model

	}
}

