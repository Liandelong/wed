using System;
namespace ITCastOCSS.Model
{
	/// <summary>
	/// Elective:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Elective
	{
		public Elective()
		{}
		#region Model
		private int _eid;
		private int? _sid;
		private int? _cid;
		private decimal? _score;
		/// <summary>
		/// 
		/// </summary>
		public int EID
		{
			set{ _eid=value;}
			get{return _eid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? SID
		{
			set{ _sid=value;}
			get{return _sid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? CID
		{
			set{ _cid=value;}
			get{return _cid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? Score
		{
			set{ _score=value;}
			get{return _score;}
		}
		#endregion Model

	}
}

