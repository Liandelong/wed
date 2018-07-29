using System;
namespace ITCastOCSS.Model
{
    /// <summary>
    /// v_Teaching:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class v_Teaching
    {
        public v_Teaching()
        { }
        #region Model
        private int _sid;
        private string _sno;
        private string _sname;
        private int _cid;
        private int? _credit;
        private string _cname;
        private string _week;
        private string _timeperiod;
        private string _place;
        private int? _maxnum;
        private int? _actualnum;
        private decimal? _score;
        private int _tid;
        /// <summary>
        /// 
        /// </summary>
        public int SID
        {
            set { _sid = value; }
            get { return _sid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SNo
        {
            set { _sno = value; }
            get { return _sno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string SName
        {
            set { _sname = value; }
            get { return _sname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int CID
        {
            set { _cid = value; }
            get { return _cid; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? Credit
        {
            set { _credit = value; }
            get { return _credit; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string CName
        {
            set { _cname = value; }
            get { return _cname; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Week
        {
            set { _week = value; }
            get { return _week; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Timeperiod
        {
            set { _timeperiod = value; }
            get { return _timeperiod; }
        }
        /// <summary>
        /// 
        /// </summary>
        public string Place
        {
            set { _place = value; }
            get { return _place; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? MaxNum
        {
            set { _maxnum = value; }
            get { return _maxnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int? ActualNum
        {
            set { _actualnum = value; }
            get { return _actualnum; }
        }
        /// <summary>
        /// 
        /// </summary>
        public decimal? Score
        {
            set { _score = value; }
            get { return _score; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int TID
        {
            set { _tid = value; }
            get { return _tid; }
        }
        #endregion Model

    }
}

