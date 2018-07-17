using System;
namespace ITCastOCSS.Model
{
	/// <summary>
	/// Notice:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Notice
	{
		public Notice()
		{}
		#region Model
		private int _nid;
		private string _ntitle;
		private string _ncontent;
		private string _nauthor;
		private DateTime? _ntime= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int NID
		{
			set{ _nid=value;}
			get{return _nid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NTitle
		{
			set{ _ntitle=value;}
			get{return _ntitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NContent
		{
			set{ _ncontent=value;}
			get{return _ncontent;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string NAuthor
		{
			set{ _nauthor=value;}
			get{return _nauthor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? NTime
		{
			set{ _ntime=value;}
			get{return _ntime;}
		}
		#endregion Model

	}
}

