using System;
namespace ITCastOCSS.Model
{
	/// <summary>
	/// Teaching:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Teaching
	{
		public Teaching()
		{}
		#region Model
		private int _id;
		private int? _tid;
		private int? _cid;
		private string _week;
		private string _timeperiod;
		private string _place;
		private int? _maxnum;
		private int? _actualnum=0;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? TID
		{
			set{ _tid=value;}
			get{return _tid;}
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
		public string Week
		{
			set{ _week=value;}
			get{return _week;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Timeperiod
		{
			set{ _timeperiod=value;}
			get{return _timeperiod;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Place
		{
			set{ _place=value;}
			get{return _place;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MaxNum
		{
			set{ _maxnum=value;}
			get{return _maxnum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? ActualNum
		{
			set{ _actualnum=value;}
			get{return _actualnum;}
		}
		#endregion Model

	}
}

